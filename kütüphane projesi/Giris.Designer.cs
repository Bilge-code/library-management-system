namespace kütüphane_projesi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblHata = new System.Windows.Forms.Label();
            this.lblHatagiris = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtGuvenlik = new System.Windows.Forms.TextBox();
            this.lblGuvenlik = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblKod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYazı = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblYada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Lavender;
            this.lblAd.Font = new System.Drawing.Font("Elephant", 9F);
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(802, 256);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(133, 24);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Kullanıcı adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Lavender;
            this.lblSifre.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(871, 306);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(60, 24);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGiris.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(992, 453);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(188, 52);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Lavender;
            this.txtAd.Location = new System.Drawing.Point(989, 254);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(188, 26);
            this.txtAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Lavender;
            this.txtSifre.Location = new System.Drawing.Point(989, 306);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(188, 26);
            this.txtSifre.TabIndex = 2;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(976, 530);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 20);
            this.lblHata.TabIndex = 5;
            this.lblHata.Visible = false;
            // 
            // lblHatagiris
            // 
            this.lblHatagiris.AutoSize = true;
            this.lblHatagiris.BackColor = System.Drawing.Color.Lavender;
            this.lblHatagiris.Location = new System.Drawing.Point(1006, 530);
            this.lblHatagiris.Name = "lblHatagiris";
            this.lblHatagiris.Size = new System.Drawing.Size(140, 20);
            this.lblHatagiris.TabIndex = 6;
            this.lblHatagiris.Text = "hatalı giriş yaptınız!";
            this.lblHatagiris.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(920, 88);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 7;
            // 
            // txtGuvenlik
            // 
            this.txtGuvenlik.BackColor = System.Drawing.Color.Lavender;
            this.txtGuvenlik.Location = new System.Drawing.Point(989, 411);
            this.txtGuvenlik.Name = "txtGuvenlik";
            this.txtGuvenlik.Size = new System.Drawing.Size(188, 26);
            this.txtGuvenlik.TabIndex = 3;
            // 
            // lblGuvenlik
            // 
            this.lblGuvenlik.AutoSize = true;
            this.lblGuvenlik.BackColor = System.Drawing.Color.Lavender;
            this.lblGuvenlik.Location = new System.Drawing.Point(1026, 370);
            this.lblGuvenlik.Name = "lblGuvenlik";
            this.lblGuvenlik.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGuvenlik.Size = new System.Drawing.Size(67, 20);
            this.lblGuvenlik.TabIndex = 10;
            this.lblGuvenlik.Text = "fbcgngn";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Transparent;
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYenile.Image = global::kütüphane_projesi.Properties.Resources.icons8_update_left_rotation_48;
            this.btnYenile.Location = new System.Drawing.Point(1115, 355);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(62, 50);
            this.btnYenile.TabIndex = 11;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.BackColor = System.Drawing.Color.Lavender;
            this.lblKod.Font = new System.Drawing.Font("Elephant", 9F);
            this.lblKod.ForeColor = System.Drawing.Color.Black;
            this.lblKod.Location = new System.Drawing.Point(784, 411);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(147, 24);
            this.lblKod.TabIndex = 12;
            this.lblKod.Text = "Güvenlik kodu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::kütüphane_projesi.Properties.Resources.icons8_customer_96__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(924, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 226);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblYazı
            // 
            this.lblYazı.AutoSize = true;
            this.lblYazı.BackColor = System.Drawing.Color.Transparent;
            this.lblYazı.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazı.Location = new System.Drawing.Point(458, 28);
            this.lblYazı.Name = "lblYazı";
            this.lblYazı.Size = new System.Drawing.Size(543, 41);
            this.lblYazı.TabIndex = 15;
            this.lblYazı.Text = "KÜTÜPHANEYE HOŞGELDİNİZ";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnKayit.Font = new System.Drawing.Font("Elephant", 9F);
            this.btnKayit.Location = new System.Drawing.Point(989, 569);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(188, 89);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kayıt Ol veya Değiştir";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblYada
            // 
            this.lblYada.AutoSize = true;
            this.lblYada.BackColor = System.Drawing.Color.Transparent;
            this.lblYada.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYada.Location = new System.Drawing.Point(1186, 498);
            this.lblYada.Name = "lblYada";
            this.lblYada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYada.Size = new System.Drawing.Size(48, 20);
            this.lblYada.TabIndex = 17;
            this.lblYada.Text = "ya da";
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1333, 693);
            this.Controls.Add(this.lblYada);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblYazı);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblGuvenlik);
            this.Controls.Add(this.txtGuvenlik);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblHatagiris);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label lblHatagiris;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtGuvenlik;
        private System.Windows.Forms.Label lblGuvenlik;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYazı;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblYada;
    }
}