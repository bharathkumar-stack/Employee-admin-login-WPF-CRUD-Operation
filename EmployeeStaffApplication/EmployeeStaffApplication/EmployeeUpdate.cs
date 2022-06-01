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
    public partial class EmployeeUpdate : Form
    {
        SqlConnection conn;
        public EmployeeUpdate()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = numempid.Value.ToString();
            try
            {
                conn.Open();
                string sql = "Select * from EmployeeDetails where EmpId=" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    EmpPoco emp = new EmpPoco();
                    //  emp.EmpId = Convert.ToInt32(reader[0].ToString());
                    emp.EmpName = reader[1].ToString();
                    emp.EmpPhone = reader[2].ToString();
                    emp.EmpGender = reader[3].ToString();
                    emp.EmpPosition = reader[4].ToString();
                    emp.EmpEducation = reader[5].ToString();
                    emp.EmpDob = reader[6].ToString();
                    emp.EmpAddress = reader[7].ToString();
                    emp.EmpLocation = reader[8].ToString();
                    emp.EmpPass = "**********";
                    update(emp);
                }
                else
                {
                    MessageBox.Show("Emnployee is not present.");
                }

            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }

          
            conn.Close();
        }

        private void update(EmpPoco emp)
        {
           // txtempname.Text = emp.EmpName;
            txtphone.Text = emp.EmpPhone;
           // comgen.Text = emp.EmpGender;
            emppos.Text = emp.EmpPosition;
            empeducation.Text = emp.EmpEducation;
           // dateTimePickerdob.Text = emp.EmpDob;
            empaddress.Text = emp.EmpAddress;
            emplocation.Text = emp.EmpLocation;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query;
            string id = numempid.Value.ToString();
            query = "update EmployeeDetails set EmpPhone='" + txtphone.Text + "',EmpPosition='" + emppos.SelectedItem.ToString() + "',EmpAddress='" + empaddress.Text + "',EmpLocation='" + emplocation.SelectedItem.ToString() + "' where Empid='" + id + "'";
            MessageBox.Show(query);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated");
                conn.Close();

            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
        }
    }
}
