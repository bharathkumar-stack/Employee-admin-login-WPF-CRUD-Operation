using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeStaffApplication
{
    public partial class EmployeeDisplay : Form
    {
        SqlConnection conn;
        public EmployeeDisplay()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        }

        private void EmployeeDisplay_Load(object sender, EventArgs e)
        {
            List<EmpPoco> l = new List<EmpPoco>();
          
            try
            {
                conn.Open();
                string sql = "Select Empid,Empname,EmpPhone,EmpGender,EmpPosition,EmpEducation,Empdob,EmpAddress,EmpLocation from EmployeeDetails";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    EmpPoco emp = new EmpPoco();
                    emp.EmpId = Convert.ToInt32(reader[0].ToString());
                    emp.EmpName = reader[1].ToString();
                    emp.EmpPhone = reader[2].ToString();
                    emp.EmpGender = reader[3].ToString();
                    emp.EmpPosition = reader[4].ToString();
                    emp.EmpEducation = reader[5].ToString();
                    emp.EmpDob = reader[6].ToString();
                    emp.EmpAddress = reader[7].ToString();
                    emp.EmpLocation = reader[8].ToString();
                    emp.EmpPass = "**********";
                    l.Add(emp);
                    empgridview.DataSource = l;
                } 
                conn.Close();
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
        }

        private void empgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
