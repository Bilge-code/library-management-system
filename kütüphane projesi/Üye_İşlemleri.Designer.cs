namespace kütüphane_projesi
{
    partial class Üye_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_İşlemleri));
            this.grpüye = new System.Windows.Forms.GroupBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtPasNo = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblPasNo = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtCeza = new System.Windows.Forms.TextBox();
            this.lblCeza = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAdı = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGonder = new System.Windows.Forms.Button();
            this.grpüye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpüye
            // 
            this.grpüye.BackColor = System.Drawing.Color.Linen;
            this.grpüye.Controls.Add(this.lblBilgi);
            this.grpüye.Controls.Add(this.richtxtAdres);
            this.grpüye.Controls.Add(this.txtPasNo);
            this.grpüye.Controls.Add(this.txtTc);
            this.grpüye.Controls.Add(this.lblPasNo);
            this.grpüye.Controls.Add(this.lblTc);
            this.grpüye.Controls.Add(this.txtCeza);
            this.grpüye.Controls.Add(this.lblCeza);
            this.grpüye.Controls.Add(this.btnKaydet);
            this.grpüye.Controls.Add(this.txtPosta);
            this.grpüye.Controls.Add(this.txtTel);
            this.grpüye.Controls.Add(this.txtSoyad);
            this.grpüye.Controls.Add(this.txtAd);
            this.grpüye.Controls.Add(this.lblAdres);
            this.grpüye.Controls.Add(this.lblPosta);
            this.grpüye.Controls.Add(this.lbltel);
            this.grpüye.Controls.Add(this.lblSoyad);
            this.grpüye.Controls.Add(this.lblAdı);
            this.grpüye.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpüye.Location = new System.Drawing.Point(87, 63);
            this.grpüye.Name = "grpüye";
            this.grpüye.Size = new System.Drawing.Size(433, 602);
            this.grpüye.TabIndex = 0;
            this.grpüye.TabStop = false;
            this.grpüye.Text = "Üye Ekleme";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Gadugi", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Purple;
            this.lblBilgi.Location = new System.Drawing.Point(177, 232);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(139, 16);
            this.lblBilgi.TabIndex = 17;
            this.lblBilgi.Text = "Tc vatandaşı değilseniz;";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(180, 359);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(199, 96);
            this.richtxtAdres.TabIndex = 6;
            this.richtxtAdres.Text = "";
            this.richtxtAdres.TextChanged += new System.EventHandler(this.richtxtAdres_TextChanged);
            // 
            // txtPasNo
            // 
            this.txtPasNo.Location = new System.Drawing.Point(180, 251);
            this.txtPasNo.Name = "txtPasNo";
            this.txtPasNo.Size = new System.Drawing.Size(199, 29);
            this.txtPasNo.TabIndex = 16;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(180, 186);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(199, 29);
            this.txtTc.TabIndex = 4;
            // 
            // lblPasNo
            // 
            this.lblPasNo.AutoSize = true;
            this.lblPasNo.Location = new System.Drawing.Point(12, 254);
            this.lblPasNo.Name = "lblPasNo";
            this.lblPasNo.Size = new System.Drawing.Size(140, 19);
            this.lblPasNo.TabIndex = 14;
            this.lblPasNo.Text = "Pasaport Seri No:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(122, 187);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(30, 19);
            this.lblTc.TabIndex = 13;
            this.lblTc.Text = "Tc:";
            // 
            // txtCeza
            // 
            this.txtCeza.Location = new System.Drawing.Point(180, 480);
            this.txtCeza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeza.Name = "txtCeza";
            this.txtCeza.Size = new System.Drawing.Size(199, 29);
            this.txtCeza.TabIndex = 7;
            this.txtCeza.Text = "0";
            // 
            // lblCeza
            // 
            this.lblCeza.AutoSize = true;
            this.lblCeza.Location = new System.Drawing.Point(96, 485);
            this.lblCeza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeza.Name = "lblCeza";
            this.lblCeza.Size = new System.Drawing.Size(49, 19);
            this.lblCeza.TabIndex = 11;
            this.lblCeza.Text = "Ceza:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.BackgroundImage = global::kütüphane_projesi.Properties.Resources.icons8_save_48;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Font = new System.Drawing.Font("Gadugi", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(180, 526);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(199, 57);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(180, 313);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(199, 29);
            this.txtPosta.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(180, 138);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(199, 29);
            this.txtTel.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(180, 90);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(199, 29);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(180, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(199, 29);
            this.txtAd.TabIndex = 1;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(96, 378);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(56, 19);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosta.Location = new System.Drawing.Point(75, 313);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(70, 19);
            this.lblPosta.TabIndex = 3;
            this.lblPosta.Text = "E-posta:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(81, 142);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(71, 19);
            this.lbltel.TabIndex = 2;
            this.lbltel.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(92, 97);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 19);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdı.Location = new System.Drawing.Point(79, 45);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(73, 19);
            this.lblAdı.TabIndex = 0;
            this.lblAdı.Text = "Üye Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(576, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(726, 397);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlarToolStripMenuItem,
            this.UyeToolStripMenuItem,
            this.emanetToolStripMenuItem,
            this.hakkındaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.raporlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.raporlarToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_comic_book_48;
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.raporlarToolStripMenuItem.Text = "&Kitap";
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
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
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
            this.emanetVerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.emanetVerToolStripMenuItem.Text = "Emanet Ver";
            this.emanetVerToolStripMenuItem.Click += new System.EventHandler(this.emanetVerToolStripMenuItem_Click);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hakkındaToolStripMenuItem1.Image = global::kütüphane_projesi.Properties.Resources.icons8_info_48;
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(126, 29);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGonder.BackgroundImage = global::kütüphane_projesi.Properties.Resources.icons8_send_hot_list_48;
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGonder.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGonder.Location = new System.Drawing.Point(811, 477);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(256, 59);
            this.btnGonder.TabIndex = 11;
            this.btnGonder.Text = "Kütüphaneye Üye Ekle";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Visible = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Üye_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.pexels_wendel_moretti_1850022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 710);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpüye);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Üye_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye_İşlemleri";
            this.Load += new System.EventHandler(this.Üye_İşlemleri_Load);
            this.grpüye.ResumeLayout(false);
            this.grpüye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpüye;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UyeToolStripMenuItem;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtCeza;
        private System.Windows.Forms.Label lblCeza;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtPasNo;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblPasNo;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richtxtAdres;
    }
}