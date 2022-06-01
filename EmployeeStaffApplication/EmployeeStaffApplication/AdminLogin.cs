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
    public partial class AdminLogin : Form
    {
        SqlConnection conn;
        public AdminLogin()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "select * from AdminTable where AdminUser ='"+txtadmin.Text+"'and AdminPassWord='"+txtadminpass.Text+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Log in successful ");
                HomeNaviage();
                conn.Close();
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }

        }

        private void HomeNaviage()
        {
            Home h = new Home();
            h.Show();
        }
    }
}
