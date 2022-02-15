using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetUygulama
{
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageProducts prod = new ManageProducts();
            prod.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManageCustomers cust =new ManageCustomers();
            cust.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageOrders order = new ManageOrders();
            order.Show();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {

        }

        private void extButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pctMaximize.Visible = false;
            pctRestore.Visible = true;
        }

        private void pctRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pctRestore.Visible = false;
            pctMaximize.Visible = true;
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManagePay pay = new ManagePay();
            pay.Show();
        }
    }
}
