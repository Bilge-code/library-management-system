namespace kütüphane_projesi
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btnUyeList = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnkitaplist = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTarayici = new System.Windows.Forms.Button();
            this.btnGerial = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsstSon = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslGiris = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnkitap = new System.Windows.Forms.Button();
            this.btnüye = new System.Windows.Forms.Button();
            this.btnemanetver = new System.Windows.Forms.Button();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUyeList
            // 
            this.btnUyeList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUyeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUyeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeList.ImageIndex = 2;
            this.btnUyeList.ImageList = this.ımageList1;
            this.btnUyeList.Location = new System.Drawing.Point(699, 371);
            this.btnUyeList.Name = "btnUyeList";
            this.btnUyeList.Size = new System.Drawing.Size(192, 209);
            this.btnUyeList.TabIndex = 5;
            this.btnUyeList.Text = "Üye Listeleme";
            this.btnUyeList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUyeList.UseVisualStyleBackColor = false;
            this.btnUyeList.Click += new System.EventHandler(this.btnUyeList_Click);
            this.btnUyeList.MouseEnter += new System.EventHandler(this.btnUyeList_MouseEnter);
            this.btnUyeList.MouseLeave += new System.EventHandler(this.btnUyeList_MouseLeave);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngwing.com.png");
            this.ımageList1.Images.SetKeyName(1, "pngwing.com (1).png");
            this.ımageList1.Images.SetKeyName(2, "pngwing.com (2).png");
            this.ımageList1.Images.SetKeyName(3, "icons8-customer-96.png");
            this.ımageList1.Images.SetKeyName(4, "—Pngtree—round creative library bookshelf_5304269.png");
            this.ımageList1.Images.SetKeyName(5, "pngwing.com (3).png");
            this.ımageList1.Images.SetKeyName(6, "icons8-check-book-48.png");
            // 
            // btnkitaplist
            // 
            this.btnkitaplist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnkitaplist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkitaplist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitaplist.ImageIndex = 4;
            this.btnkitaplist.ImageList = this.ımageList1;
            this.btnkitaplist.Location = new System.Drawing.Point(338, 371);
            this.btnkitaplist.Name = "btnkitaplist";
            this.btnkitaplist.Size = new System.Drawing.Size(192, 209);
            this.btnkitaplist.TabIndex = 4;
            this.btnkitaplist.Text = "Kitap Listeleme";
            this.btnkitaplist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnkitaplist.UseVisualStyleBackColor = false;
            this.btnkitaplist.Click += new System.EventHandler(this.btnkitaplist_Click);
            this.btnkitaplist.MouseEnter += new System.EventHandler(this.btnkitaplist_MouseEnter);
            this.btnkitaplist.MouseLeave += new System.EventHandler(this.btnkitaplist_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1428, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnTarayici
            // 
            this.btnTarayici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTarayici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTarayici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnTarayici.Image = global::kütüphane_projesi.Properties.Resources.icons8_globe_48;
            this.btnTarayici.Location = new System.Drawing.Point(0, 499);
            this.btnTarayici.Name = "btnTarayici";
            this.btnTarayici.Size = new System.Drawing.Size(102, 97);
            this.btnTarayici.TabIndex = 8;
            this.btnTarayici.Text = "Tarayıcı";
            this.btnTarayici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTarayici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTarayici.UseVisualStyleBackColor = false;
            this.btnTarayici.Click += new System.EventHandler(this.btnTarayici_Click);
            // 
            // btnGerial
            // 
            this.btnGerial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnGerial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerial.ImageIndex = 6;
            this.btnGerial.ImageList = this.ımageList1;
            this.btnGerial.Location = new System.Drawing.Point(1060, 364);
            this.btnGerial.Name = "btnGerial";
            this.btnGerial.Size = new System.Drawing.Size(192, 209);
            this.btnGerial.TabIndex = 6;
            this.btnGerial.Text = "Emaneti Geri Al";
            this.btnGerial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerial.UseVisualStyleBackColor = false;
            this.btnGerial.Click += new System.EventHandler(this.btnGerial_Click);
            this.btnGerial.MouseEnter += new System.EventHandler(this.btnGerial_MouseEnter);
            this.btnGerial.MouseLeave += new System.EventHandler(this.btnGerial_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslKullanici,
            this.tsstSon,
            this.tsslGiris});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1428, 32);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslKullanici
            // 
            this.tsslKullanici.Name = "tsslKullanici";
            this.tsslKullanici.Size = new System.Drawing.Size(0, 25);
            // 
            // tsstSon
            // 
            this.tsstSon.Name = "tsstSon";
            this.tsstSon.Size = new System.Drawing.Size(145, 25);
            this.tsstSon.Text = "Son Başarılı Giriş:";
            // 
            // tsslGiris
            // 
            this.tsslGiris.Name = "tsslGiris";
            this.tsslGiris.Size = new System.Drawing.Size(179, 25);
            this.tsslGiris.Text = "toolStripStatusLabel1";
            // 
            // btnkitap
            // 
            this.btnkitap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnkitap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkitap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitap.ForeColor = System.Drawing.Color.Black;
            this.btnkitap.ImageIndex = 0;
            this.btnkitap.ImageList = this.ımageList1;
            this.btnkitap.Location = new System.Drawing.Point(232, 130);
            this.btnkitap.Name = "btnkitap";
            this.btnkitap.Size = new System.Drawing.Size(192, 198);
            this.btnkitap.TabIndex = 1;
            this.btnkitap.Text = "Kitap İşlemleri";
            this.btnkitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnkitap.UseVisualStyleBackColor = false;
            this.btnkitap.Click += new System.EventHandler(this.btnkitap_Click);
            this.btnkitap.MouseEnter += new System.EventHandler(this.btnkitap_MouseEnter);
            this.btnkitap.MouseLeave += new System.EventHandler(this.btnkitap_MouseLeave);
            this.btnkitap.MouseHover += new System.EventHandler(this.btnkitap_MouseHover);
            // 
            // btnüye
            // 
            this.btnüye.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnüye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnüye.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnüye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnüye.ForeColor = System.Drawing.Color.Black;
            this.btnüye.ImageIndex = 3;
            this.btnüye.ImageList = this.ımageList1;
            this.btnüye.Location = new System.Drawing.Point(585, 119);
            this.btnüye.Name = "btnüye";
            this.btnüye.Size = new System.Drawing.Size(192, 198);
            this.btnüye.TabIndex = 2;
            this.btnüye.Text = "Üye İşlemleri";
            this.btnüye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnüye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnüye.UseVisualStyleBackColor = false;
            this.btnüye.Click += new System.EventHandler(this.btnüye_Click);
            this.btnüye.MouseEnter += new System.EventHandler(this.btnüye_MouseEnter);
            this.btnüye.MouseLeave += new System.EventHandler(this.btnüye_MouseLeave);
            // 
            // btnemanetver
            // 
            this.btnemanetver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnemanetver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnemanetver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnemanetver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnemanetver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnemanetver.ImageIndex = 5;
            this.btnemanetver.ImageList = this.ımageList1;
            this.btnemanetver.Location = new System.Drawing.Point(938, 119);
            this.btnemanetver.Name = "btnemanetver";
            this.btnemanetver.Size = new System.Drawing.Size(192, 198);
            this.btnemanetver.TabIndex = 3;
            this.btnemanetver.Text = "\r\nEmanet Ver";
            this.btnemanetver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnemanetver.UseVisualStyleBackColor = false;
            this.btnemanetver.Click += new System.EventHandler(this.btnemanet_Click);
            this.btnemanetver.MouseEnter += new System.EventHandler(this.btnemanetver_MouseEnter);
            this.btnemanetver.MouseLeave += new System.EventHandler(this.btnemanetver_MouseLeave);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_exit_sign_48;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click_1);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 631);
            this.Controls.Add(this.btnGerial);
            this.Controls.Add(this.btnemanetver);
            this.Controls.Add(this.btnUyeList);
            this.Controls.Add(this.btnüye);
            this.Controls.Add(this.btnkitaplist);
            this.Controls.Add(this.btnkitap);
            this.Controls.Add(this.btnTarayici);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkitap;
        private System.Windows.Forms.Button btnUyeList;
        private System.Windows.Forms.Button btnkitaplist;
        private System.Windows.Forms.Button btnemanetver;
        private System.Windows.Forms.Button btnüye;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTarayici;
        private System.Windows.Forms.Button btnGerial;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslKullanici;
        private System.Windows.Forms.ToolStripStatusLabel tsstSon;
        private System.Windows.Forms.ToolStripStatusLabel tsslGiris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}