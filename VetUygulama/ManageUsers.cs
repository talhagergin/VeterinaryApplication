using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace VetUygulama
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=.\veteriner.db");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from CustomerTbl";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch 
            {
                MessageBox.Show("Error!");        
            }
        }
      
        private void label3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SQLiteCommand cmd = new SQLiteCommand("insert into CustomerTbl values('" + CustomerIdTb.Text + "','" + CustomerNameTb.Text + "','" + CustomerAdressTb.Text + "','" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri Eklendi");
                Con.Close();
                populate();
                
            }
            catch 
            {
                MessageBox.Show("Error");    
            }
        }
        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerAdressTb.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            CustomerPhoneTb.Text = CustomersGV.SelectedRows[0].Cells[3].Value.ToString();
            Con.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("select Count(*) from OrderTbl where MusteriId = " + CustomerIdTb.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();

            SQLiteDataAdapter sda1 = new SQLiteDataAdapter("select Sum(ToplamHesap) from OrderTbl where MusteriId = " + CustomerIdTb.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();
          
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter("select Max(SiparisTarih) from OrderTbl where MusteriId = " + CustomerIdTb.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(CustomerIdTb.Text == "")
            {
                MessageBox.Show("Müşteri Id Girin!");
            }
            else
            {
                Con.Open();
                string myquerry = "delete from CustomerTbl where MusteriId='" + CustomerIdTb.Text + "';";
                SQLiteCommand cmd = new SQLiteCommand(myquerry, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri Silindi!");
                Con.Close();
                populate();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SQLiteCommand cmd = new SQLiteCommand("update CustomerTbl set MusteriAdSoyad='" + CustomerNameTb.Text + "',MusteriAdres='" + CustomerAdressTb.Text + "',MusteriTelefon='" + CustomerPhoneTb.Text + "' where MusteriId='" + CustomerIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri Güncellendi!");
                Con.Close();
                populate();
            }
            catch 
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeMenu menu = new HomeMenu();
            menu.Show();
            this.Hide();
        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchTb_OnValueChanged(object sender, EventArgs e)
        {
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from CustomerTbl where MusteriAdSoyad like '%" + SearchTb.Text + "%'", Con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CustomersGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void extButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pctRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pctRestore.Visible = false;
            pctMaximize.Visible = true;
        }

        private void pctMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pctMaximize.Visible = false;
            pctRestore.Visible = true;
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
