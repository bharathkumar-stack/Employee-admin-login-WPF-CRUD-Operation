using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeInsert s = new EmployeeInsert();
            s.Show();
            this.Hide();

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            EmployeeDisplay d = new EmployeeDisplay();
            d.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            EmployeeSearch s = new EmployeeSearch();
            s.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            EmployeeUpdate ud = new EmployeeUpdate();
            ud.Show();
            this.Hide();
        }

        private void btnpayslip_Click(object sender, EventArgs e)
        {
            //Emppayslip s = new Emppayslip();
            //s.Show();
            //this.Hide();
        }
    }
}
