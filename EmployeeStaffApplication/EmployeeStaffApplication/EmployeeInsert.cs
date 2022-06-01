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
    public partial class EmployeeInsert : Form
    {
        SqlConnection conn;
        public EmployeeInsert()
        { 
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into EmployeeDetails values('" + numempid.Value + "','" + txtempname.Text + "','" + txtphone.Text + "','" + comgen.SelectedItem.ToString() + "','" + emppos.SelectedItem.ToString() + "','" + empeducation.SelectedItem.ToString() + "','" + dateTimePickerdob.Text + "','" + empaddress.Text + "','"+emplocation.SelectedItem.ToString()+"','"+txtpass.Text+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee successfully Added ");
                conn.Close();
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
            Clear();
        }

        private void EmployeeInsert_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            numempid.Value = 0;
            txtempname.Text = "";
            txtphone.Text = "";
            comgen.Text = "";
            emppos.Text = "";
            empeducation.Text = "";
            dateTimePickerdob.Text = "";
            empaddress.Text = "";
            emplocation.Text = "";
            txtpass.Text = "";
        }
    }
}
