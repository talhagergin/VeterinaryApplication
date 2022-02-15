
namespace VetUygulama
{
    partial class ManagePay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extButton2 = new System.Windows.Forms.PictureBox();
            this.pctRestore = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.pctMaximize = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DebtListGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AmountTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebtListGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.extButton2);
            this.panel1.Controls.Add(this.pctRestore);
            this.panel1.Controls.Add(this.pctMinimize);
            this.panel1.Controls.Add(this.pctMaximize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 100);
            this.panel1.TabIndex = 0;
            // 
            // extButton2
            // 
            this.extButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extButton2.Image = ((System.Drawing.Image)(resources.GetObject("extButton2.Image")));
            this.extButton2.Location = new System.Drawing.Point(906, 11);
            this.extButton2.Margin = new System.Windows.Forms.Padding(2);
            this.extButton2.Name = "extButton2";
            this.extButton2.Size = new System.Drawing.Size(23, 24);
            this.extButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extButton2.TabIndex = 19;
            this.extButton2.TabStop = false;
            this.extButton2.Click += new System.EventHandler(this.extButton2_Click);
            // 
            // pctRestore
            // 
            this.pctRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctRestore.Image = ((System.Drawing.Image)(resources.GetObject("pctRestore.Image")));
            this.pctRestore.Location = new System.Drawing.Point(880, 12);
            this.pctRestore.Margin = new System.Windows.Forms.Padding(2);
            this.pctRestore.Name = "pctRestore";
            this.pctRestore.Size = new System.Drawing.Size(22, 24);
            this.pctRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRestore.TabIndex = 16;
            this.pctRestore.TabStop = false;
            this.pctRestore.Visible = false;
            this.pctRestore.Click += new System.EventHandler(this.pctRestore_Click);
            // 
            // pctMinimize
            // 
            this.pctMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(854, 11);
            this.pctMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(22, 24);
            this.pctMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinimize.TabIndex = 17;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pctMinimize_Click);
            // 
            // pctMaximize
            // 
            this.pctMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pctMaximize.Image")));
            this.pctMaximize.Location = new System.Drawing.Point(880, 11);
            this.pctMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.pctMaximize.Name = "pctMaximize";
            this.pctMaximize.Size = new System.Drawing.Size(22, 24);
            this.pctMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaximize.TabIndex = 18;
            this.pctMaximize.TabStop = false;
            this.pctMaximize.Click += new System.EventHandler(this.pctMaximize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(386, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alacak Listesi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(367, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "YILMAZ VETERİNER";
            // 
            // DebtListGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DebtListGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DebtListGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebtListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DebtListGV.BackgroundColor = System.Drawing.Color.White;
            this.DebtListGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebtListGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DebtListGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DebtListGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DebtListGV.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DebtListGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DebtListGV.EnableHeadersVisualStyles = false;
            this.DebtListGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtListGV.Location = new System.Drawing.Point(12, 162);
            this.DebtListGV.Name = "DebtListGV";
            this.DebtListGV.RowHeadersVisible = false;
            this.DebtListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DebtListGV.Size = new System.Drawing.Size(904, 314);
            this.DebtListGV.TabIndex = 9;
            this.DebtListGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DebtListGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DebtListGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DebtListGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DebtListGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DebtListGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DebtListGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtListGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.DebtListGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DebtListGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DebtListGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DebtListGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DebtListGV.ThemeStyle.HeaderStyle.Height = 20;
            this.DebtListGV.ThemeStyle.ReadOnly = false;
            this.DebtListGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DebtListGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DebtListGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DebtListGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DebtListGV.ThemeStyle.RowsStyle.Height = 22;
            this.DebtListGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtListGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DebtListGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DebtListGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(842, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ödeme Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AmountTb
            // 
            this.AmountTb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AmountTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AmountTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmountTb.HintForeColor = System.Drawing.Color.Empty;
            this.AmountTb.HintText = "";
            this.AmountTb.isPassword = false;
            this.AmountTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.AmountTb.LineIdleColor = System.Drawing.Color.Blue;
            this.AmountTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AmountTb.LineThickness = 3;
            this.AmountTb.Location = new System.Drawing.Point(686, 103);
            this.AmountTb.Margin = new System.Windows.Forms.Padding(4);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(149, 33);
            this.AmountTb.TabIndex = 12;
            this.AmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerIdTb
            // 
            this.CustomerIdTb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerIdTb.HintText = "";
            this.CustomerIdTb.isPassword = false;
            this.CustomerIdTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerIdTb.LineIdleColor = System.Drawing.Color.Blue;
            this.CustomerIdTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerIdTb.LineThickness = 3;
            this.CustomerIdTb.Location = new System.Drawing.Point(137, 108);
            this.CustomerIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIdTb.Name = "CustomerIdTb";
            this.CustomerIdTb.Size = new System.Drawing.Size(149, 33);
            this.CustomerIdTb.TabIndex = 13;
            this.CustomerIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(512, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödenecek Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Müşteri Id:";
            // 
            // PayDate
            // 
            this.PayDate.Checked = true;
            this.PayDate.CheckedState.Parent = this.PayDate;
            this.PayDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PayDate.HoverState.Parent = this.PayDate;
            this.PayDate.Location = new System.Drawing.Point(306, 104);
            this.PayDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PayDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PayDate.Name = "PayDate";
            this.PayDate.ShadowDecoration.Parent = this.PayDate;
            this.PayDate.Size = new System.Drawing.Size(200, 28);
            this.PayDate.TabIndex = 15;
            this.PayDate.Value = new System.DateTime(2022, 2, 8, 14, 33, 30, 605);
            // 
            // AmountLbl
            // 
            this.AmountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AmountLbl.ForeColor = System.Drawing.Color.Black;
            this.AmountLbl.Location = new System.Drawing.Point(700, 479);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(21, 24);
            this.AmountLbl.TabIndex = 33;
            this.AmountLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(546, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Genel Toplam:";
            // 
            // SearchTb
            // 
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
            this.SearchTb.Location = new System.Drawing.Point(137, 466);
            this.SearchTb.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(178, 33);
            this.SearchTb.TabIndex = 34;
            this.SearchTb.Text = "Arama";
            this.SearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTb.OnValueChanged += new System.EventHandler(this.SearchTb_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Müşteri Ad:";
            // 
            // ManagePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PayDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerIdTb);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DebtListGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePay";
            this.Text = "Ödeme ";
            this.Load += new System.EventHandler(this.ManagePay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebtListGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DebtListGV;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AmountTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerIdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker PayDate;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox extButton2;
        private System.Windows.Forms.PictureBox pctRestore;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctMaximize;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTb;
        private System.Windows.Forms.Label label5;
    }
}