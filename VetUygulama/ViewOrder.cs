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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=.\veteriner.db");
        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populateOrder();
            populatePrice();
        }
        void populateOrder()
        {
            try
            {
                Con.Open();
                SQLiteCommand cmd2 = new SQLiteCommand("update OrderTbl set ToplamHesap= REPLACE(TOplamHesap,',','.') + 0.0 where INSTR(ToplamHesap,',')", Con);
                cmd2.ExecuteNonQuery();
                string Myquery = "Select * from OrderTbl";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        void populatePrice()
        {
            Con.Open();
            SQLiteDataAdapter sda1 = new SQLiteDataAdapter("select Sum(ToplamHesap) from OrderTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLbl.Text = dt1.Rows[0][0].ToString();
            Con.Close();
        }
        private void BtnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrder vieww = new ViewOrder();
            vieww.Close();
        }

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Sipariş Özeti", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Sipariş Id:" + OrderGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Müşteri Id:" + OrderGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Müşteri Ad:" + OrderGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Sipariş Tarihi:" + OrderGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Müşteri Hesap:" + OrderGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 226));
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
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