namespace kütüphane_projesi
{
    partial class Kitap_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_İşlemleri));
            this.lstkitaplar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmsSagtus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inceleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.KitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSagtus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBaski)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstkitaplar
            // 
            this.lstkitaplar.BackColor = System.Drawing.Color.Linen;
            this.lstkitaplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstkitaplar.FormattingEnabled = true;
            this.lstkitaplar.ItemHeight = 20;
            this.lstkitaplar.Items.AddRange(new object[] {
            "LİSTELENEN KİTAPLAR"});
            this.lstkitaplar.Location = new System.Drawing.Point(696, 80);
            this.lstkitaplar.Name = "lstkitaplar";
            this.lstkitaplar.Size = new System.Drawing.Size(464, 402);
            this.lstkitaplar.TabIndex = 1;
            this.lstkitaplar.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(696, 529);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 56);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-save-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-cancel-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-send-hot-list-48.png");
            // 
            // cmsSagtus
            // 
            this.cmsSagtus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSagtus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.inceleToolStripMenuItem,
            this.renkDeğiştirToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.cmsSagtus.Name = "cmsSagtus";
            this.cmsSagtus.Size = new System.Drawing.Size(187, 132);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.fontToolStripMenuItem.Text = "Font değiştir";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // inceleToolStripMenuItem
            // 
            this.inceleToolStripMenuItem.Name = "inceleToolStripMenuItem";
            this.inceleToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.inceleToolStripMenuItem.Text = "İncele";
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.renkDeğiştirToolStripMenuItem.Text = "Renk değiştir";
            this.renkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.btnKaydet);
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
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(118, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 545);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAP EKLE";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKaydet.ImageIndex = 0;
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(164, 412);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(202, 48);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // numericSayfa
            // 
            this.numericSayfa.Location = new System.Drawing.Point(164, 262);
            this.numericSayfa.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericSayfa.Name = "numericSayfa";
            this.numericSayfa.Size = new System.Drawing.Size(202, 29);
            this.numericSayfa.TabIndex = 5;
            // 
            // numericBaski
            // 
            this.numericBaski.Location = new System.Drawing.Point(164, 215);
            this.numericBaski.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericBaski.Name = "numericBaski";
            this.numericBaski.Size = new System.Drawing.Size(202, 29);
            this.numericBaski.TabIndex = 4;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(164, 61);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(202, 29);
            this.txtNo.TabIndex = 1;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(32, 68);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(94, 19);
            this.lblNo.TabIndex = 36;
            this.lblNo.Text = "Barkod No:";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(164, 350);
            this.txtTur.Multiline = true;
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(202, 22);
            this.txtTur.TabIndex = 7;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(164, 303);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(202, 29);
            this.txtYayinevi.TabIndex = 6;
            this.txtYayinevi.TextChanged += new System.EventHandler(this.txtYayinevi_TextChanged);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(164, 164);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(202, 29);
            this.txtYazar.TabIndex = 3;
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(164, 112);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(202, 29);
            this.txtKitap.TabIndex = 2;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.Location = new System.Drawing.Point(78, 349);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(48, 19);
            this.lblTur.TabIndex = 34;
            this.lblTur.Text = "Türü:";
            // 
            // lblYayınevi
            // 
            this.lblYayınevi.AutoSize = true;
            this.lblYayınevi.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYayınevi.Location = new System.Drawing.Point(47, 303);
            this.lblYayınevi.Name = "lblYayınevi";
            this.lblYayınevi.Size = new System.Drawing.Size(79, 19);
            this.lblYayınevi.TabIndex = 32;
            this.lblYayınevi.Text = "Yayınevi:";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayfa.Location = new System.Drawing.Point(23, 262);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(103, 19);
            this.lblSayfa.TabIndex = 30;
            this.lblSayfa.Text = "Sayfa Sayısı:";
            // 
            // lblBaskı
            // 
            this.lblBaskı.AutoSize = true;
            this.lblBaskı.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaskı.Location = new System.Drawing.Point(44, 215);
            this.lblBaskı.Name = "lblBaskı";
            this.lblBaskı.Size = new System.Drawing.Size(82, 19);
            this.lblBaskı.TabIndex = 28;
            this.lblBaskı.Text = "Baskı Yılı:";
            // 
            // lblyazar
            // 
            this.lblyazar.AutoSize = true;
            this.lblyazar.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyazar.Location = new System.Drawing.Point(71, 164);
            this.lblyazar.Name = "lblyazar";
            this.lblyazar.Size = new System.Drawing.Size(55, 19);
            this.lblyazar.TabIndex = 26;
            this.lblyazar.Text = "Yazar:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(43, 116);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(83, 19);
            this.lblAd.TabIndex = 24;
            this.lblAd.Text = "Kitap Adı:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 2;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(929, 529);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(231, 56);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Kütüphaneye Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Visible = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KitapToolStripMenuItem,
            this.UyeToolStripMenuItem,
            this.emanetToolStripMenuItem,
            this.hakkındaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1343, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // KitapToolStripMenuItem
            // 
            this.KitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.KitapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KitapToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_comic_book_48;
            this.KitapToolStripMenuItem.Name = "KitapToolStripMenuItem";
            this.KitapToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.KitapToolStripMenuItem.Text = "&Kitap";
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
            // UyeToolStripMenuItem
            // 
            this.UyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.listeleToolStripMenuItem1});
            this.UyeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UyeToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_male_user_48;
            this.UyeToolStripMenuItem.Name = "UyeToolStripMenuItem";
            this.UyeToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.UyeToolStripMenuItem.Text = "&Üye";
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
            this.emanetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hakkındaToolStripMenuItem1.Image = global::kütüphane_projesi.Properties.Resources.icons8_info_48;
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(126, 29);
            this.hakkındaToolStripMenuItem1.Text = "&Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // Kitap_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.pexels_wendel_moretti_1850022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1343, 681);
            this.ContextMenuStrip = this.cmsSagtus;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstkitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kitap_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap_İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kitap_İşlemleri_FormClosing);
            this.Load += new System.EventHandler(this.Kitap_İşlemleri_Load);
            this.cmsSagtus.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBaski)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstkitaplar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ContextMenuStrip cmsSagtus;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inceleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericSayfa;
        private System.Windows.Forms.NumericUpDown numericBaski;
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
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem KitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}