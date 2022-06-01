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
    public partial class EmployeeSearch : Form
    {
        SqlConnection conn;
        public EmployeeSearch()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelemployee.Visible = false;
            string id = txteid.Value.ToString();
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
                    
                    lblname.Text = reader[1].ToString();
                    lblphone.Text = reader[2].ToString();
                    lblgender.Text = reader[3].ToString();
                    lblpos.Text = reader[4].ToString();
                    lbleducation.Text = reader[5].ToString();
                    lbldob.Text = reader[6].ToString();
                    lbladdress.Text = reader[7].ToString();
                    lbllocation.Text = reader[8].ToString();
                    panelemployee.Visible = true;

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

        private void EmployeeSearch_Load(object sender, EventArgs e)
        {
            panelemployee.Visible = false;
        }

        private void panelemployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
