
namespace VetUygulama
{
    partial class ManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductQuanTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pctMaximize = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.pctRestore = new System.Windows.Forms.PictureBox();
            this.extButton2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.extButton2);
            this.panel1.Controls.Add(this.pctRestore);
            this.panel1.Controls.Add(this.pctMinimize);
            this.panel1.Controls.Add(this.pctMaximize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(373, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "YILMAZ VETERİNER";
            // 
            // ProductPriceTb
            // 
            this.ProductPriceTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProductPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceTb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceTb.ForeColor = System.Drawing.Color.Black;
            this.ProductPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductPriceTb.HintText = "";
            this.ProductPriceTb.isPassword = false;
            this.ProductPriceTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductPriceTb.LineIdleColor = System.Drawing.Color.Blue;
            this.ProductPriceTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductPriceTb.LineThickness = 5;
            this.ProductPriceTb.Location = new System.Drawing.Point(142, 275);
            this.ProductPriceTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProductPriceTb.Name = "ProductPriceTb";
            this.ProductPriceTb.Size = new System.Drawing.Size(178, 33);
            this.ProductPriceTb.TabIndex = 9;
            this.ProductPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductQuanTb
            // 
            this.ProductQuanTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProductQuanTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuanTb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuanTb.ForeColor = System.Drawing.Color.Black;
            this.ProductQuanTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductQuanTb.HintText = "";
            this.ProductQuanTb.isPassword = false;
            this.ProductQuanTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductQuanTb.LineIdleColor = System.Drawing.Color.Blue;
            this.ProductQuanTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductQuanTb.LineThickness = 5;
            this.ProductQuanTb.Location = new System.Drawing.Point(142, 234);
            this.ProductQuanTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProductQuanTb.Name = "ProductQuanTb";
            this.ProductQuanTb.Size = new System.Drawing.Size(178, 33);
            this.ProductQuanTb.TabIndex = 8;
            this.ProductQuanTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductNameTb
            // 
            this.ProductNameTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProductNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTb.ForeColor = System.Drawing.Color.Black;
            this.ProductNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductNameTb.HintText = "";
            this.ProductNameTb.isPassword = false;
            this.ProductNameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductNameTb.LineIdleColor = System.Drawing.Color.Blue;
            this.ProductNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductNameTb.LineThickness = 5;
            this.ProductNameTb.Location = new System.Drawing.Point(142, 193);
            this.ProductNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProductNameTb.Name = "ProductNameTb";
            this.ProductNameTb.Size = new System.Drawing.Size(178, 33);
            this.ProductNameTb.TabIndex = 7;
            this.ProductNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductIdTb
            // 
            this.ProductIdTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProductIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductIdTb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdTb.ForeColor = System.Drawing.Color.Black;
            this.ProductIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductIdTb.HintText = "";
            this.ProductIdTb.isPassword = false;
            this.ProductIdTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductIdTb.LineIdleColor = System.Drawing.Color.Blue;
            this.ProductIdTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductIdTb.LineThickness = 5;
            this.ProductIdTb.Location = new System.Drawing.Point(142, 152);
            this.ProductIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProductIdTb.Name = "ProductIdTb";
            this.ProductIdTb.Size = new System.Drawing.Size(178, 33);
            this.ProductIdTb.TabIndex = 6;
            this.ProductIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductDescTb
            // 
            this.ProductDescTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ProductDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductDescTb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescTb.ForeColor = System.Drawing.Color.Black;
            this.ProductDescTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductDescTb.HintText = "";
            this.ProductDescTb.isPassword = false;
            this.ProductDescTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductDescTb.LineIdleColor = System.Drawing.Color.Blue;
            this.ProductDescTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductDescTb.LineThickness = 5;
            this.ProductDescTb.Location = new System.Drawing.Point(142, 316);
            this.ProductDescTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProductDescTb.Name = "ProductDescTb";
            this.ProductDescTb.Size = new System.Drawing.Size(178, 33);
            this.ProductDescTb.TabIndex = 10;
            this.ProductDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDelete.Location = new System.Drawing.Point(91, 417);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 38);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEdit.Location = new System.Drawing.Point(137, 373);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(78, 38);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAdd.Location = new System.Drawing.Point(36, 373);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(78, 38);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(373, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ürün Listesi";
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductsGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductsGV.ColumnHeadersHeight = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProductsGV.EnableHeadersVisualStyles = false;
            this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.Location = new System.Drawing.Point(335, 164);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(535, 411);
            this.ProductsGV.TabIndex = 15;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsGV.ThemeStyle.HeaderStyle.Height = 20;
            this.ProductsGV.ThemeStyle.ReadOnly = false;
            this.ProductsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(91, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 639);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 12);
            this.panel4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ürün İsmi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ürün Miktar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ürün Fiyat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ürün Açıklama";
            // 
            // SearchTb
            // 
            this.SearchTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.ForeColor = System.Drawing.Color.Black;
            this.SearchTb.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTb.HintText = "";
            this.SearchTb.isPassword = false;
            this.SearchTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTb.LineIdleColor = System.Drawing.Color.Purple;
            this.SearchTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTb.LineThickness = 5;
            this.SearchTb.Location = new System.Drawing.Point(653, 124);
            this.SearchTb.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(178, 33);
            this.SearchTb.TabIndex = 28;
            this.SearchTb.Text = "Arama";
            this.SearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTb.OnValueChanged += new System.EventHandler(this.SearchTb_OnValueChanged);
            // 
            // pctMaximize
            // 
            this.pctMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pctMaximize.Image")));
            this.pctMaximize.Location = new System.Drawing.Point(818, 9);
            this.pctMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.pctMaximize.Name = "pctMaximize";
            this.pctMaximize.Size = new System.Drawing.Size(22, 24);
            this.pctMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaximize.TabIndex = 10;
            this.pctMaximize.TabStop = false;
            this.pctMaximize.Click += new System.EventHandler(this.pctMaximize_Click);
            // 
            // pctMinimize
            // 
            this.pctMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(792, 9);
            this.pctMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(22, 24);
            this.pctMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinimize.TabIndex = 9;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pctMinimize_Click);
            // 
            // pctRestore
            // 
            this.pctRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctRestore.Image = ((System.Drawing.Image)(resources.GetObject("pctRestore.Image")));
            this.pctRestore.Location = new System.Drawing.Point(818, 11);
            this.pctRestore.Margin = new System.Windows.Forms.Padding(2);
            this.pctRestore.Name = "pctRestore";
            this.pctRestore.Size = new System.Drawing.Size(22, 24);
            this.pctRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRestore.TabIndex = 8;
            this.pctRestore.TabStop = false;
            this.pctRestore.Visible = false;
            this.pctRestore.Click += new System.EventHandler(this.pctRestore_Click);
            // 
            // extButton2
            // 
            this.extButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extButton2.Image = ((System.Drawing.Image)(resources.GetObject("extButton2.Image")));
            this.extButton2.Location = new System.Drawing.Point(844, 9);
            this.extButton2.Margin = new System.Windows.Forms.Padding(2);
            this.extButton2.Name = "extButton2";
            this.extButton2.Size = new System.Drawing.Size(23, 24);
            this.extButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extButton2.TabIndex = 11;
            this.extButton2.TabStop = false;
            this.extButton2.Click += new System.EventHandler(this.extButton2_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 651);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ProductDescTb);
            this.Controls.Add(this.ProductPriceTb);
            this.Controls.Add(this.ProductQuanTb);
            this.Controls.Add(this.ProductNameTb);
            this.Controls.Add(this.ProductIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünleri Yönet";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductPriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductQuanTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductDescTb;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTb;
        private System.Windows.Forms.PictureBox extButton2;
        private System.Windows.Forms.PictureBox pctRestore;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctMaximize;
    }
}