namespace kütüphane_projesi
{
    partial class Kitap_Listeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Listeleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericSayfa = new System.Windows.Forms.NumericUpDown();
            this.numericBaski = new System.Windows.Forms.NumericUpDown();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitap = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblYayınevi = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblBaskı = new System.Windows.Forms.Label();
            this.lblyazar = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdBtnTur = new System.Windows.Forms.RadioButton();
            this.rdbtnYazar = new System.Windows.Forms.RadioButton();
            this.rdbtnAd = new System.Windows.Forms.RadioButton();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBaski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numericSayfa);
            this.groupBox1.Controls.Add(this.numericBaski);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.txtTur);
            this.groupBox1.Controls.Add(this.txtYayinevi);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtKitap);
            this.groupBox1.Controls.Add(this.lblTur);
            this.groupBox1.Controls.Add(this.lblYayınevi);
            this.groupBox1.Controls.Add(this.lblSayfa);
            this.groupBox1.Controls.Add(this.lblBaskı);
            this.groupBox1.Controls.Add(this.lblyazar);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(24, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // numericSayfa
            // 
            this.numericSayfa.Location = new System.Drawing.Point(501, 29);
            this.numericSayfa.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericSayfa.Name = "numericSayfa";
            this.numericSayfa.Size = new System.Drawing.Size(174, 29);
            this.numericSayfa.TabIndex = 5;
            // 
            // numericBaski
            // 
            this.numericBaski.Location = new System.Drawing.Point(167, 162);
            this.numericBaski.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericBaski.Name = "numericBaski";
            this.numericBaski.Size = new System.Drawing.Size(174, 29);
            this.numericBaski.TabIndex = 4;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(167, 27);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(174, 29);
            this.txtNo.TabIndex = 1;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(20, 29);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(94, 19);
            this.lblNo.TabIndex = 22;
            this.lblNo.Text = "Barkod No:";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(501, 122);
            this.txtTur.Multiline = true;
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(174, 28);
            this.txtTur.TabIndex = 7;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(501, 71);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(174, 29);
            this.txtYayinevi.TabIndex = 6;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(167, 124);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(174, 29);
            this.txtYazar.TabIndex = 3;
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(167, 74);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(174, 29);
            this.txtKitap.TabIndex = 2;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.Location = new System.Drawing.Point(420, 121);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(48, 19);
            this.lblTur.TabIndex = 20;
            this.lblTur.Text = "Türü:";
            // 
            // lblYayınevi
            // 
            this.lblYayınevi.AutoSize = true;
            this.lblYayınevi.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYayınevi.Location = new System.Drawing.Point(386, 80);
            this.lblYayınevi.Name = "lblYayınevi";
            this.lblYayınevi.Size = new System.Drawing.Size(79, 19);
            this.lblYayınevi.TabIndex = 18;
            this.lblYayınevi.Text = "Yayınevi:";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayfa.Location = new System.Drawing.Point(360, 31);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(103, 19);
            this.lblSayfa.TabIndex = 16;
            this.lblSayfa.Text = "Sayfa Sayısı:";
            // 
            // lblBaskı
            // 
            this.lblBaskı.AutoSize = true;
            this.lblBaskı.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaskı.Location = new System.Drawing.Point(37, 163);
            this.lblBaskı.Name = "lblBaskı";
            this.lblBaskı.Size = new System.Drawing.Size(82, 19);
            this.lblBaskı.TabIndex = 14;
            this.lblBaskı.Text = "Baskı Yılı:";
            // 
            // lblyazar
            // 
            this.lblyazar.AutoSize = true;
            this.lblyazar.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyazar.Location = new System.Drawing.Point(63, 124);
            this.lblyazar.Name = "lblyazar";
            this.lblyazar.Size = new System.Drawing.Size(55, 19);
            this.lblyazar.TabIndex = 12;
            this.lblyazar.Text = "Yazar:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(31, 79);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(83, 19);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "Kitap Adı:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 2;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(41, 258);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(148, 52);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-cancel-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-list-view-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-update-left-rotation-48 (1).png");
            this.ımageList1.Images.SetKeyName(3, "icons8-print-48.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-search-48.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(972, 214);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(226, 258);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 52);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1043, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.kitapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.üyeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.listeleToolStripMenuItem1.Click += new System.EventHandler(this.listeleToolStripMenuItem1_Click);
            // 
            // emanetToolStripMenuItem
            // 
            this.emanetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetVerToolStripMenuItem,
            this.geriAlToolStripMenuItem});
            this.emanetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emanetToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_reading_48;
            this.emanetToolStripMenuItem.Name = "emanetToolStripMenuItem";
            this.emanetToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.emanetToolStripMenuItem.Text = "&Emanet";
            this.emanetToolStripMenuItem.Click += new System.EventHandler(this.emanetToolStripMenuItem_Click);
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
            this.hakkındaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hakkındaToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_info_48;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.rdBtnTur);
            this.groupBox2.Controls.Add(this.rdbtnYazar);
            this.groupBox2.Controls.Add(this.rdbtnAd);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(804, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Seçenek";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAra.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageIndex = 4;
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(19, 221);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(148, 52);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(19, 153);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(190, 29);
            this.txtAra.TabIndex = 11;
            // 
            // rdBtnTur
            // 
            this.rdBtnTur.AutoSize = true;
            this.rdBtnTur.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnTur.Location = new System.Drawing.Point(19, 120);
            this.rdBtnTur.Name = "rdBtnTur";
            this.rdBtnTur.Size = new System.Drawing.Size(59, 23);
            this.rdBtnTur.TabIndex = 10;
            this.rdBtnTur.TabStop = true;
            this.rdBtnTur.Text = "Tür";
            this.rdBtnTur.UseVisualStyleBackColor = true;
            // 
            // rdbtnYazar
            // 
            this.rdbtnYazar.AutoSize = true;
            this.rdbtnYazar.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.rdbtnYazar.Location = new System.Drawing.Point(19, 71);
            this.rdbtnYazar.Name = "rdbtnYazar";
            this.rdbtnYazar.Size = new System.Drawing.Size(76, 23);
            this.rdbtnYazar.TabIndex = 9;
            this.rdbtnYazar.TabStop = true;
            this.rdbtnYazar.Text = "Yazar";
            this.rdbtnYazar.UseVisualStyleBackColor = true;
            // 
            // rdbtnAd
            // 
            this.rdbtnAd.AutoSize = true;
            this.rdbtnAd.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.rdbtnAd.Location = new System.Drawing.Point(19, 32);
            this.rdbtnAd.Name = "rdbtnAd";
            this.rdbtnAd.Size = new System.Drawing.Size(104, 23);
            this.rdbtnAd.TabIndex = 8;
            this.rdbtnAd.TabStop = true;
            this.rdbtnAd.Text = "Kitap Adı";
            this.rdbtnAd.UseVisualStyleBackColor = true;
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.LightGray;
            this.btnYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdır.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnYazdır.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdır.ImageIndex = 3;
            this.btnYazdır.ImageList = this.ımageList1;
            this.btnYazdır.Location = new System.Drawing.Point(596, 258);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(148, 52);
            this.btnYazdır.TabIndex = 16;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
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
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.PowderBlue;
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.ImageIndex = 1;
            this.btnListele.ImageList = this.ımageList1;
            this.btnListele.Location = new System.Drawing.Point(411, 258);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(148, 52);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Kitap_Listeleme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.pexels_alexander_kovalev_2847648__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 567);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Kitap_Listeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listeleme";
            this.Load += new System.EventHandler(this.Kitap_Listeleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBaski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitap;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblYayınevi;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblBaskı;
        private System.Windows.Forms.Label lblyazar;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericSayfa;
        private System.Windows.Forms.NumericUpDown numericBaski;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.RadioButton rdBtnTur;
        private System.Windows.Forms.RadioButton rdbtnYazar;
        private System.Windows.Forms.RadioButton rdbtnAd;
        private System.Windows.Forms.Button btnYazdır;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ImageList ımageList1;
    }
}