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
    public partial class ManagePay : Form
    {
        public ManagePay()
        {
            InitializeComponent();
        }
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=.\veteriner.db");
        
        void populateOrder()
        {
            try
           {
                Con.Open();
            SQLiteCommand cmd2 = new SQLiteCommand("update OrderTbl set ToplamHesap = REPLACE(ToplamHesap,',','.') + 0.0 where INSTR(ToplamHesap,',')", Con);
            cmd2.ExecuteNonQuery();
            string Myquery = "Select * from OrderTbl";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DebtListGV.DataSource = ds.Tables[0];
                Con.Close();
            }
           catch
          {
               MessageBox.Show("Error!");
          }
        }
        void populatePrice()
        {
            try
            {
                Con.Open();
                SQLiteDataAdapter sda1 = new SQLiteDataAdapter("select Sum(ToplamHesap) from OrderTbl", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                AmountLbl.Text = dt1.Rows[0][0].ToString();
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void ManagePay_Load(object sender, EventArgs e)
        {
            populateOrder();
            populatePrice();
        }

        private void DebtListGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = DebtListGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        long orderId;
        string custName;
        float kalan,pay=0,debt=0,last=0;

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

        private void SearchTb_OnValueChanged(object sender, EventArgs e)
        {
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from OrderTbl where MusteriAd like '%" + SearchTb.Text + "%'", Con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DebtListGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pctRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pctRestore.Visible = false;
            pctMaximize.Visible = true;
        }

        private void extButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Müşteri Seçiniz!");
            }
            else
            {
                pay = Convert.ToSingle(DebtListGV.SelectedRows[0].Cells[4].Value.ToString());
                debt = Convert.ToSingle(AmountTb.Text);
                last = pay - debt;
               // try
               // {
                    Con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("update OrderTbl set ToplamHesap='" + last + "' where MusteriId='" + CustomerIdTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap Güncellendi!");
                    orderId = Convert.ToInt64(DebtListGV.SelectedRows[0].Cells[0].Value.ToString());
                    custName = DebtListGV.SelectedRows[0].Cells[2].Value.ToString();
                   kalan = Convert.ToSingle(DebtListGV.SelectedRows[0].Cells[4].Value.ToString());                   
                    Con.Close();
                    populateOrder();
                Con.Open();
                /* güncel hesabı veri tabanına yazma
                SQLiteCommand cmd2 = new SQLiteCommand("insert into AmountTbl values('" + orderId + "','" + CustomerIdTb.Text + "','" + custName + "','" + PayDate.Value.Date.ToString("yyyy/MM/dd") + "','" + Convert.ToSingle(AmountTb.Text) + "','" + kalan + "'", Con);
                cmd2.ExecuteNonQuery();
                Con.Close();*/
                //  }
                // catch
                //  {
                  //   MessageBox.Show("Error!");
                // }
            }
        }
      
    }
}
