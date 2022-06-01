using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeStaffApplication
{
    public partial class numslip : Form
    {
        SqlConnection conn;
        public int id = 0;
       
        public numslip()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        }

        private void payslip_Load(object sender, EventArgs e)
        {

        }

        private void PayslipId()
        {
           
            string empid = numpayslip.Value.ToString();
            try
            {
                conn.Open();
                string query = "select * from EmployeeDetails where Empid="+empid;
                SqlCommand s = new SqlCommand(query,conn);
                SqlDataReader reader = s.ExecuteReader();
                if (reader.Read())
                {
                    PaySlipPoco c = new PaySlipPoco();
                    id = int.Parse(reader[0].ToString());
                }
                else
                {
                    MessageBox.Show("we can not genereate Payslip for this empid");
                }
                conn.Close();  
            }catch(Exception ob)
            {
                MessageBox.Show(ob.Message);
            }

            MessageBox.Show(id.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayslipId();
            try
            { conn.Open();
          int perdaysal = 500;
         int totalworkingdays = int.Parse(numworkinddays.Value.ToString());
         int empworkingdays = int.Parse(numempworkindays.Value.ToString());
         int providentfund = int.Parse(numpffund.Value.ToString());
                int employeeleaves = totalworkingdays - empworkingdays;
                int salarydeduction = (perdaysal * employeeleaves) + providentfund;
                int empsalary = (perdaysal * empworkingdays) - salarydeduction;
                
        string query = "insert into EmpPayslip values('" + numpayslip.Value + "','" + totalworkingdays + "','" + empworkingdays + "','" + employeeleaves + "','" + numpffund.Value + "','" + salarydeduction + "','" + empsalary + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("PaySlip Succefully Generted");
                conn.Close();
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
        }
    }
}
