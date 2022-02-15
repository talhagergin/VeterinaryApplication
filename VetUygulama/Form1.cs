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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                PasswordTb.isPassword = true;
            else
                PasswordTb.isPassword = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "yılmaz" && PasswordTb.Text.ToString()== "1")
            {
                HomeMenu home = new HomeMenu();
                home.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void extButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
