namespace kütüphane_projesi
{
    partial class Üye_Listeleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_Listeleme));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAdı = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtPasno = new System.Windows.Forms.TextBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCeza = new System.Windows.Forms.TextBox();
            this.lblCeza = new System.Windows.Forms.Label();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdbtnTc = new System.Windows.Forms.RadioButton();
            this.rdbtnTel = new System.Windows.Forms.RadioButton();
            this.rdbtnAd = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 3;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(62, 360);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(148, 52);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-list-view-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-print-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-cancel-48.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-update-left-rotation-48 (1).png");
            this.ımageList1.Images.SetKeyName(4, "icons8-search-48.png");
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(201, 241);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(182, 29);
            this.txtTel.TabIndex = 18;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(201, 84);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 29);
            this.txtSoyad.TabIndex = 17;
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Location = new System.Drawing.Point(201, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(182, 22);
            this.txtAd.TabIndex = 16;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(450, 94);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(56, 19);
            this.lblAdres.TabIndex = 15;
            this.lblAdres.Text = "Adres:";
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosta.Location = new System.Drawing.Point(436, 37);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(70, 19);
            this.lblPosta.TabIndex = 14;
            this.lblPosta.Text = "E-posta:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(73, 251);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(71, 19);
            this.lbltel.TabIndex = 13;
            this.lbltel.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(86, 84);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 19);
            this.lblSoyad.TabIndex = 12;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdı.Location = new System.Drawing.Point(73, 38);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(73, 19);
            this.lblAdı.TabIndex = 11;
            this.lblAdı.Text = "Üye Adı:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTc.Location = new System.Drawing.Point(116, 142);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(30, 19);
            this.lblTc.TabIndex = 22;
            this.lblTc.Text = "Tc:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(201, 132);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(182, 29);
            this.txtTc.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.richtxtAdres);
            this.groupBox1.Controls.Add(this.txtPasno);
            this.groupBox1.Controls.Add(this.lblBilgi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCeza);
            this.groupBox1.Controls.Add(this.lblCeza);
            this.groupBox1.Controls.Add(this.txtPosta);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblAdı);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lbltel);
            this.groupBox1.Controls.Add(this.lblPosta);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 290);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri Güncelleme";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(551, 81);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(182, 80);
            this.richtxtAdres.TabIndex = 30;
            this.richtxtAdres.Text = "";
            // 
            // txtPasno
            // 
            this.txtPasno.Location = new System.Drawing.Point(201, 186);
            this.txtPasno.Name = "txtPasno";
            this.txtPasno.Size = new System.Drawing.Size(182, 29);
            this.txtPasno.TabIndex = 29;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Gadugi", 6F, System.Drawing.FontStyle.Bold);
            this.lblBilgi.ForeColor = System.Drawing.Color.Purple;
            this.lblBilgi.Location = new System.Drawing.Point(198, 167);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(139, 16);
            this.lblBilgi.TabIndex = 28;
            this.lblBilgi.Text = "Tc vatandaşı değilseniz;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pasaport Seri No:";
            // 
            // txtCeza
            // 
            this.txtCeza.Location = new System.Drawing.Point(551, 187);
            this.txtCeza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeza.Name = "txtCeza";
            this.txtCeza.Size = new System.Drawing.Size(182, 29);
            this.txtCeza.TabIndex = 25;
            // 
            // lblCeza
            // 
            this.lblCeza.AutoSize = true;
            this.lblCeza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCeza.Location = new System.Drawing.Point(457, 190);
            this.lblCeza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeza.Name = "lblCeza";
            this.lblCeza.Size = new System.Drawing.Size(49, 19);
            this.lblCeza.TabIndex = 24;
            this.lblCeza.Text = "Ceza:";
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(551, 34);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(182, 29);
            this.txtPosta.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(9, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 330);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 2;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(287, 360);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 48);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.LightGray;
            this.btnYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdır.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnYazdır.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdır.ImageIndex = 1;
            this.btnYazdır.ImageList = this.ımageList1;
            this.btnYazdır.Location = new System.Drawing.Point(710, 356);
            this.btnYazdır.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(148, 52);
            this.btnYazdır.TabIndex = 28;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapToolStripMenuItem,
            this.üyeToolStripMenuItem,
            this.emanetToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1463, 36);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.kitapToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_comic_book_48;
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.kitapToolStripMenuItem.Text = "&Kitap";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(162, 34);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(162, 34);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.listeleToolStripMenuItem1});
            this.üyeToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_male_user_48;
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.üyeToolStripMenuItem.Text = "&Üye";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(162, 34);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(162, 34);
            this.listeleToolStripMenuItem1.Text = "Listele";
            // 
            // emanetToolStripMenuItem
            // 
            this.emanetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetVerToolStripMenuItem,
            this.geriAlToolStripMenuItem});
            this.emanetToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_reading_48;
            this.emanetToolStripMenuItem.Name = "emanetToolStripMenuItem";
            this.emanetToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.emanetToolStripMenuItem.Text = "&Emanet";
            // 
            // emanetVerToolStripMenuItem
            // 
            this.emanetVerToolStripMenuItem.Name = "emanetVerToolStripMenuItem";
            this.emanetVerToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.emanetVerToolStripMenuItem.Text = "Emanet Ver";
            this.emanetVerToolStripMenuItem.Click += new System.EventHandler(this.emanetVerToolStripMenuItem_Click);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_info_48;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.rdbtnTc);
            this.groupBox2.Controls.Add(this.rdbtnTel);
            this.groupBox2.Controls.Add(this.rdbtnAd);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(953, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 371);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Seçenek";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Image = global::kütüphane_projesi.Properties.Resources.icons8_search_48;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(44, 304);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(152, 47);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(22, 240);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(174, 29);
            this.txtAra.TabIndex = 3;
            // 
            // rdbtnTc
            // 
            this.rdbtnTc.AutoSize = true;
            this.rdbtnTc.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.rdbtnTc.Location = new System.Drawing.Point(22, 159);
            this.rdbtnTc.Name = "rdbtnTc";
            this.rdbtnTc.Size = new System.Drawing.Size(51, 23);
            this.rdbtnTc.TabIndex = 2;
            this.rdbtnTc.TabStop = true;
            this.rdbtnTc.Text = "Tc";
            this.rdbtnTc.UseVisualStyleBackColor = true;
            // 
            // rdbtnTel
            // 
            this.rdbtnTel.AutoSize = true;
            this.rdbtnTel.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.rdbtnTel.Location = new System.Drawing.Point(22, 94);
            this.rdbtnTel.Name = "rdbtnTel";
            this.rdbtnTel.Size = new System.Drawing.Size(96, 23);
            this.rdbtnTel.TabIndex = 1;
            this.rdbtnTel.TabStop = true;
            this.rdbtnTel.Text = "Telefon ";
            this.rdbtnTel.UseVisualStyleBackColor = true;
            // 
            // rdbtnAd
            // 
            this.rdbtnAd.AutoSize = true;
            this.rdbtnAd.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.rdbtnAd.Location = new System.Drawing.Point(22, 28);
            this.rdbtnAd.Name = "rdbtnAd";
            this.rdbtnAd.Size = new System.Drawing.Size(94, 23);
            this.rdbtnAd.TabIndex = 0;
            this.rdbtnAd.TabStop = true;
            this.rdbtnAd.Text = "Üye Adı";
            this.rdbtnAd.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.PowderBlue;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.ImageIndex = 0;
            this.btnListele.ImageList = this.ımageList1;
            this.btnListele.Location = new System.Drawing.Point(516, 356);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(148, 52);
            this.btnListele.TabIndex = 32;
            this.btnListele.Text = "Listele";
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Üye_Listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.pexels_alexander_kovalev_2847648__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 771);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Üye_Listeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye_Listeleme";
            this.Load += new System.EventHandler(this.Üye_Listeleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCeza;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtPasno;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.TextBox txtCeza;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnTc;
        private System.Windows.Forms.RadioButton rdbtnTel;
        private System.Windows.Forms.RadioButton rdbtnAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ImageList ımageList1;
    }
}