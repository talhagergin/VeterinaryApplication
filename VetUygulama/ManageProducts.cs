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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=.\veteriner.db");
        void populate()
        {
            try
            {
                Con.Open();
                SQLiteCommand cmd2 = new SQLiteCommand("update ProductTbl set UrunFiyat = REPLACE(UrunFiyat,',','.') + 0.0 where INSTR(UrunFiyat,',')", Con);
                cmd2.ExecuteNonQuery();
                string Myquery = "Select * from ProductTbl";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Myquery, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);               
                ProductsGV.DataSource = ds.Tables[0];               
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Eror!");
            }
        }
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            populate();
        }

     

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SQLiteCommand cmd = new SQLiteCommand("insert into ProductTbl values('"+ProductIdTb.Text+"','" + ProductNameTb.Text + "','" + ProductQuanTb.Text + "','" + Convert.ToSingle(ProductPriceTb.Text) + "','"+ProductDescTb.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Eklendi");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           // try
           // {
                Con.Open();
                SQLiteCommand cmd = new SQLiteCommand("update ProductTbl set UrunAd='" + ProductNameTb.Text + "',UrunMiktar='" + ProductQuanTb.Text + "',UrunFiyat='" + ProductPriceTb.Text + "',UrunAciklama='" + ProductDescTb.Text + "' where UrunId='" + ProductIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                SQLiteCommand cmd2 = new SQLiteCommand("update ProductTbl set UrunFiyat = REPLACE(UrunFiyat,',','.') + 0.0 where INSTR(UrunFiyat,',')",Con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Ürün Güncellendi!");
                Con.Close();
                populate();
           // }
           // catch (Exception e)
           // {
           //     MessageBox.Show(e.ToString());
           // }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ProductIdTb.Text == "")
            {
                MessageBox.Show("Ürün Id Girin!");
            }
            else
            {
                Con.Open();
                string myquerry = "delete from ProductTbl where UrunId='" + ProductIdTb.Text + "';";
                SQLiteCommand cmd = new SQLiteCommand(myquerry, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi!");
                Con.Close();
                populate();
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuanTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductPriceTb.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            ProductDescTb.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeMenu menu = new HomeMenu();
            menu.Show();
            this.Hide();
        }

        private void SearchTb_OnValueChanged(object sender, EventArgs e)
        {
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from ProductTbl where UrunAd like '%" + SearchTb.Text + "%'", Con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ProductsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void extButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
