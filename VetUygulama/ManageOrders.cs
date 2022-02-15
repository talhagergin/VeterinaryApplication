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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
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
            }
        }
        void populateProduct()
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
            }
        }

        int num = 0;
        float uprice, toprice, qty;
        string product;
        int flag = 0;
        int stock;
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProduct();
        }

    
        float sum = 0;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            if(QtyTb.Text=="")
            {
                MessageBox.Show("Ürün Miktarı Girin!");
            }
            else if(flag == 0)
            {
                MessageBox.Show("Ürün Seçiniz");
            }
            else if (Convert.ToInt32(QtyTb.Text)>stock)
            {
                MessageBox.Show("Yeterli Urun Yok!");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                toprice = qty * uprice;
                OrderGV.Rows.Add(num, product, qty, uprice, toprice);
                //OrderGV.DataSource
                flag = 0;
                sum = sum + toprice;
                TotAmount.Text = sum.ToString();
                updateproduct();
                MessageBox.Show("Sipariş Eklendi!");

            }
            
        }
        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustNameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            OrderIdTb.Text = (Convert.ToInt64(DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds)).ToString();
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
        
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            
            if(OrderIdTb.Text=="" || CustomerIdTb.Text == "" || CustNameTb.Text=="" || TotAmount.Text=="")
            {
                MessageBox.Show("Verileri Doğru Doldurun!");
            }
            else
            {
                Con.Open();
                SQLiteCommand cmd = new SQLiteCommand("insert into OrderTbl values('" + OrderIdTb.Text + "','" + CustomerIdTb.Text + "','" + CustNameTb.Text + "','" + OrderDate.Value.Date.ToString("yyyy/MM/dd") + "','" + TotAmount.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sipariş Eklendi");
                Con.Close();
                try
                {
                   
                  //  populate();
                }
                catch
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeMenu menu = new HomeMenu();
            menu.Show();
            this.Hide();
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

        private void SearchTb2_OnValueChanged(object sender, EventArgs e)
        {
            Con.Open();
            SQLiteCommand cmd2 = new SQLiteCommand("select * from CustomerTbl where MusteriAdSoyad like '%" + SearchTb2.Text + "%'", Con);
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            CustomersGV.DataSource = ds2.Tables[0];
            Con.Close();

        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice= Convert.ToSingle(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            // toprice = qty * uprice;
            flag = 1;
        }
        void updateproduct()
        {
            
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
            { MessageBox.Show("İşlem Hatalı!"); }
            else
            {
                Con.Open();
                string query = "update ProductTbl set UrunMiktar= " + newQty + " where UrunId= '" + id + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateProduct();
            }
        }
       

    }
}
