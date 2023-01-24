
namespace SimpleSupermarketApp
{
    partial class Selling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            this.AddProdButton = new System.Windows.Forms.Button();
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.QtyTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VProgressBar4 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.PriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VProgressBar3 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.ProdNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VProgressBar2 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.BillIDTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.cariTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.BillDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Rp = new System.Windows.Forms.Label();
            this.Rs = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Seller = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SellerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProdButton
            // 
            this.AddProdButton.BackColor = System.Drawing.Color.White;
            this.AddProdButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddProdButton.FlatAppearance.BorderSize = 0;
            this.AddProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProdButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.AddProdButton.ForeColor = System.Drawing.Color.Teal;
            this.AddProdButton.Location = new System.Drawing.Point(26, 204);
            this.AddProdButton.Name = "AddProdButton";
            this.AddProdButton.Size = new System.Drawing.Size(124, 38);
            this.AddProdButton.TabIndex = 43;
            this.AddProdButton.Text = "Tambah";
            this.AddProdButton.UseVisualStyleBackColor = false;
            this.AddProdButton.Click += new System.EventHandler(this.AddProdButton_Click);
            // 
            // SelectCategory
            // 
            this.SelectCategory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategory.ForeColor = System.Drawing.Color.Teal;
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.SelectCategory.Location = new System.Drawing.Point(26, 249);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(161, 24);
            this.SelectCategory.TabIndex = 36;
            this.SelectCategory.Text = "Pilih Kategori";
            this.SelectCategory.SelectionChangeCommitted += new System.EventHandler(this.SelectCategory_SelectionChangeCommitted);
            // 
            // QtyTB
            // 
            this.QtyTB.BorderColor = System.Drawing.Color.White;
            this.QtyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTB.DefaultText = "";
            this.QtyTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTB.FillColor = System.Drawing.Color.Turquoise;
            this.QtyTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTB.ForeColor = System.Drawing.Color.White;
            this.QtyTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTB.Location = new System.Drawing.Point(158, 164);
            this.QtyTB.Margin = new System.Windows.Forms.Padding(7);
            this.QtyTB.Name = "QtyTB";
            this.QtyTB.PasswordChar = '\0';
            this.QtyTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.QtyTB.PlaceholderText = "";
            this.QtyTB.SelectedText = "";
            this.QtyTB.Size = new System.Drawing.Size(161, 31);
            this.QtyTB.TabIndex = 32;
            // 
            // guna2Button4
            // 
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(158, 183);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(161, 2);
            this.guna2Button4.TabIndex = 34;
            // 
            // guna2VProgressBar4
            // 
            this.guna2VProgressBar4.Location = new System.Drawing.Point(48, 204);
            this.guna2VProgressBar4.Name = "guna2VProgressBar4";
            this.guna2VProgressBar4.Size = new System.Drawing.Size(0, 0);
            this.guna2VProgressBar4.TabIndex = 33;
            this.guna2VProgressBar4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Turquoise;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Jumlah";
            // 
            // PriceTB
            // 
            this.PriceTB.BorderColor = System.Drawing.Color.White;
            this.PriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTB.DefaultText = "";
            this.PriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTB.FillColor = System.Drawing.Color.Turquoise;
            this.PriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTB.ForeColor = System.Drawing.Color.White;
            this.PriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTB.Location = new System.Drawing.Point(158, 130);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(7);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.PasswordChar = '\0';
            this.PriceTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.PriceTB.PlaceholderText = "";
            this.PriceTB.ReadOnly = true;
            this.PriceTB.SelectedText = "";
            this.PriceTB.Size = new System.Drawing.Size(161, 31);
            this.PriceTB.TabIndex = 28;
            // 
            // guna2Button3
            // 
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(158, 147);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(161, 2);
            this.guna2Button3.TabIndex = 30;
            // 
            // guna2VProgressBar3
            // 
            this.guna2VProgressBar3.Location = new System.Drawing.Point(48, 172);
            this.guna2VProgressBar3.Name = "guna2VProgressBar3";
            this.guna2VProgressBar3.Size = new System.Drawing.Size(0, 0);
            this.guna2VProgressBar3.TabIndex = 29;
            this.guna2VProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ProdNameTB
            // 
            this.ProdNameTB.BorderColor = System.Drawing.Color.White;
            this.ProdNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdNameTB.DefaultText = "";
            this.ProdNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdNameTB.FillColor = System.Drawing.Color.Turquoise;
            this.ProdNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdNameTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTB.ForeColor = System.Drawing.Color.White;
            this.ProdNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdNameTB.Location = new System.Drawing.Point(158, 97);
            this.ProdNameTB.Margin = new System.Windows.Forms.Padding(7);
            this.ProdNameTB.Name = "ProdNameTB";
            this.ProdNameTB.PasswordChar = '\0';
            this.ProdNameTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.ProdNameTB.PlaceholderText = "";
            this.ProdNameTB.ReadOnly = true;
            this.ProdNameTB.SelectedText = "";
            this.ProdNameTB.Size = new System.Drawing.Size(161, 31);
            this.ProdNameTB.TabIndex = 24;
            // 
            // guna2Button2
            // 
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(158, 112);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(161, 2);
            this.guna2Button2.TabIndex = 26;
            // 
            // guna2VProgressBar2
            // 
            this.guna2VProgressBar2.Location = new System.Drawing.Point(48, 116);
            this.guna2VProgressBar2.Name = "guna2VProgressBar2";
            this.guna2VProgressBar2.Size = new System.Drawing.Size(0, 0);
            this.guna2VProgressBar2.TabIndex = 25;
            this.guna2VProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Turquoise;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nama Prdk";
            // 
            // BillIDTB
            // 
            this.BillIDTB.BackColor = System.Drawing.SystemColors.Window;
            this.BillIDTB.BorderColor = System.Drawing.Color.White;
            this.BillIDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillIDTB.DefaultText = "";
            this.BillIDTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BillIDTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BillIDTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BillIDTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BillIDTB.FillColor = System.Drawing.Color.Turquoise;
            this.BillIDTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BillIDTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIDTB.ForeColor = System.Drawing.Color.White;
            this.BillIDTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BillIDTB.Location = new System.Drawing.Point(158, 63);
            this.BillIDTB.Margin = new System.Windows.Forms.Padding(7);
            this.BillIDTB.Name = "BillIDTB";
            this.BillIDTB.PasswordChar = '\0';
            this.BillIDTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.BillIDTB.PlaceholderText = "";
            this.BillIDTB.SelectedText = "";
            this.BillIDTB.Size = new System.Drawing.Size(161, 31);
            this.BillIDTB.TabIndex = 21;
            // 
            // guna2Button1
            // 
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(158, 77);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(161, 2);
            this.guna2Button1.TabIndex = 22;
            // 
            // guna2VProgressBar1
            // 
            this.guna2VProgressBar1.Location = new System.Drawing.Point(48, 78);
            this.guna2VProgressBar1.Name = "guna2VProgressBar1";
            this.guna2VProgressBar1.Size = new System.Drawing.Size(0, 0);
            this.guna2VProgressBar1.TabIndex = 21;
            this.guna2VProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID Struk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(357, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = "Penjualan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Turquoise;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Harga";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCari);
            this.panel1.Controls.Add(this.cariTB);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.BillDGV);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Rp);
            this.panel1.Controls.Add(this.Rs);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.Seller);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.AddProdButton);
            this.panel1.Controls.Add(this.SelectCategory);
            this.panel1.Controls.Add(this.QtyTB);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2VProgressBar4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.PriceTB);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2VProgressBar3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ProdNameTB);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2VProgressBar2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BillIDTB);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2VProgressBar1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(176, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 532);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nama";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.White;
            this.btnCari.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.Teal;
            this.btnCari.Location = new System.Drawing.Point(844, 63);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(61, 31);
            this.btnCari.TabIndex = 63;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cariTB
            // 
            this.cariTB.BorderColor = System.Drawing.Color.White;
            this.cariTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cariTB.DefaultText = "";
            this.cariTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cariTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cariTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cariTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cariTB.FillColor = System.Drawing.Color.Turquoise;
            this.cariTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cariTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTB.ForeColor = System.Drawing.Color.White;
            this.cariTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cariTB.Location = new System.Drawing.Point(445, 63);
            this.cariTB.Margin = new System.Windows.Forms.Padding(7);
            this.cariTB.Name = "cariTB";
            this.cariTB.PasswordChar = '\0';
            this.cariTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.cariTB.PlaceholderText = "";
            this.cariTB.SelectedText = "";
            this.cariTB.Size = new System.Drawing.Size(389, 31);
            this.cariTB.TabIndex = 61;
            // 
            // guna2Button5
            // 
            this.guna2Button5.FillColor = System.Drawing.Color.White;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(445, 95);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(389, 2);
            this.guna2Button5.TabIndex = 62;
            // 
            // BillDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BillDGV.ColumnHeadersHeight = 30;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.BillDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.Location = new System.Drawing.Point(362, 104);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersVisible = false;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.Size = new System.Drawing.Size(543, 412);
            this.BillDGV.TabIndex = 60;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BillDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.BillDGV.ThemeStyle.ReadOnly = false;
            this.BillDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Teal;
            this.BillDGV.ThemeStyle.RowsStyle.Height = 28;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDGV_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(245, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 59;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(156, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 58;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rp
            // 
            this.Rp.AutoSize = true;
            this.Rp.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rp.ForeColor = System.Drawing.Color.White;
            this.Rp.Location = new System.Drawing.Point(643, 237);
            this.Rp.Name = "Rp";
            this.Rp.Size = new System.Drawing.Size(0, 36);
            this.Rp.TabIndex = 57;
            // 
            // Rs
            // 
            this.Rs.AutoSize = true;
            this.Rs.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rs.ForeColor = System.Drawing.Color.White;
            this.Rs.Location = new System.Drawing.Point(725, 237);
            this.Rs.Name = "Rs";
            this.Rs.Size = new System.Drawing.Size(0, 36);
            this.Rs.TabIndex = 54;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.White;
            this.Amount.Location = new System.Drawing.Point(458, 237);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(0, 36);
            this.Amount.TabIndex = 53;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(735, 17);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(127, 36);
            this.DateLabel.TabIndex = 52;
            this.DateLabel.Text = "Tanggal";
            // 
            // Seller
            // 
            this.Seller.AutoSize = true;
            this.Seller.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller.ForeColor = System.Drawing.Color.White;
            this.Seller.Location = new System.Drawing.Point(20, 17);
            this.Seller.Name = "Seller";
            this.Seller.Size = new System.Drawing.Size(167, 36);
            this.Seller.TabIndex = 51;
            this.Seller.Text = "Pelanggan";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.White;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Teal;
            this.RefreshButton.Location = new System.Drawing.Point(193, 249);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(61, 24);
            this.RefreshButton.TabIndex = 49;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.SellerDGV.ColumnHeadersHeight = 30;
            this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.Location = new System.Drawing.Point(26, 279);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.RowTemplate.Height = 28;
            this.SellerDGV.Size = new System.Drawing.Size(228, 237);
            this.SellerDGV.TabIndex = 48;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.SellerDGV.ThemeStyle.ReadOnly = false;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Teal;
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 28;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(24, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 38);
            this.button4.TabIndex = 48;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = " X";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.Location = new System.Drawing.Point(1112, 6);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(32, 38);
            this.bunifuThinButton22.TabIndex = 44;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 612);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selling";
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.Selling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Button AddProdButton;
        private System.Windows.Forms.ComboBox SelectCategory;
        private Guna.UI2.WinForms.Guna2TextBox QtyTB;
        private Guna.UI2.WinForms.Guna2TextBox NamaTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox PriceTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar3;
        private Guna.UI2.WinForms.Guna2TextBox ProdNameTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox BillIDTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Seller;
        private System.Windows.Forms.Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView SellerDGV;
        private System.Windows.Forms.Label Rs;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label Rp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2DataGridView BillDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCari;
        private Guna.UI2.WinForms.Guna2TextBox cariTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}