namespace kütüphane_projesi
{
    partial class Emanet_GeriAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanet_GeriAl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGerial = new System.Windows.Forms.Button();
            this.btnGecikme = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtCeza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblVerilis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.btnCeza = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.BackgroundColorChanged += new System.EventHandler(this.dataGridView1_BackgroundColorChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGerial
            // 
            this.btnGerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerial.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGerial.Image = global::kütüphane_projesi.Properties.Resources.icons8_undo_48;
            this.btnGerial.Location = new System.Drawing.Point(1129, 376);
            this.btnGerial.Name = "btnGerial";
            this.btnGerial.Size = new System.Drawing.Size(148, 115);
            this.btnGerial.TabIndex = 8;
            this.btnGerial.Text = " Emaneti Geri Al";
            this.btnGerial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerial.UseVisualStyleBackColor = false;
            this.btnGerial.Click += new System.EventHandler(this.btnGerial_Click);
            // 
            // btnGecikme
            // 
            this.btnGecikme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGecikme.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecikme.ImageIndex = 0;
            this.btnGecikme.ImageList = this.ımageList1;
            this.btnGecikme.Location = new System.Drawing.Point(393, 260);
            this.btnGecikme.Name = "btnGecikme";
            this.btnGecikme.Size = new System.Drawing.Size(255, 57);
            this.btnGecikme.TabIndex = 7;
            this.btnGecikme.Text = "Geciken Kitaplar";
            this.btnGecikme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGecikme.UseVisualStyleBackColor = false;
            this.btnGecikme.Click += new System.EventHandler(this.btnGecikme_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-high-importance-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-list-view-48.png");
            // 
            // txtCeza
            // 
            this.txtCeza.Location = new System.Drawing.Point(758, 165);
            this.txtCeza.Name = "txtCeza";
            this.txtCeza.Size = new System.Drawing.Size(200, 26);
            this.txtCeza.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(652, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ceza(TL):";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(671, 213);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 22);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Üye ID:";
            // 
            // lblVerilis
            // 
            this.lblVerilis.AutoSize = true;
            this.lblVerilis.BackColor = System.Drawing.Color.Transparent;
            this.lblVerilis.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerilis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVerilis.Location = new System.Drawing.Point(612, 68);
            this.lblVerilis.Name = "lblVerilis";
            this.lblVerilis.Size = new System.Drawing.Size(132, 22);
            this.lblVerilis.TabIndex = 6;
            this.lblVerilis.Text = "Emanet Veriliş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(632, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emanet Alış:";
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(758, 213);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.Size = new System.Drawing.Size(200, 26);
            this.txtUyeId.TabIndex = 4;
            // 
            // btnCeza
            // 
            this.btnCeza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCeza.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCeza.Location = new System.Drawing.Point(758, 260);
            this.btnCeza.Name = "btnCeza";
            this.btnCeza.Size = new System.Drawing.Size(200, 39);
            this.btnCeza.TabIndex = 5;
            this.btnCeza.Text = "Ceza Ver";
            this.btnCeza.UseVisualStyleBackColor = false;
            this.btnCeza.Click += new System.EventHandler(this.btnCeza_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(758, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(758, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapToolStripMenuItem,
            this.üyeToolStripMenuItem,
            this.emanetToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1401, 32);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.kitapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kitapToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_comic_book_48;
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.kitapToolStripMenuItem.Text = "&Kitap";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.ekleToolStripMenuItem.Text = "Ekle ";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.listeleToolStripMenuItem1});
            this.üyeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.üyeToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_male_user_48;
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.üyeToolStripMenuItem.Text = "&Üye";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
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
            this.emanetToolStripMenuItem.Size = new System.Drawing.Size(108, 28);
            this.emanetToolStripMenuItem.Text = "&Emanet";
            // 
            // emanetVerToolStripMenuItem
            // 
            this.emanetVerToolStripMenuItem.Name = "emanetVerToolStripMenuItem";
            this.emanetVerToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.emanetVerToolStripMenuItem.Text = "Emanet Ver ";
            this.emanetVerToolStripMenuItem.Click += new System.EventHandler(this.emanetVerToolStripMenuItem_Click);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hakkındaToolStripMenuItem.Image = global::kütüphane_projesi.Properties.Resources.icons8_info_48;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(125, 28);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListele.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ImageIndex = 1;
            this.btnListele.ImageList = this.ımageList1;
            this.btnListele.Location = new System.Drawing.Point(52, 260);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(255, 57);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = " Emanetleri Listele";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Emanet_GeriAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kütüphane_projesi.Properties.Resources.pexels_wendel_moretti_1850022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1401, 717);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCeza);
            this.Controls.Add(this.txtUyeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVerilis);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCeza);
            this.Controls.Add(this.btnGecikme);
            this.Controls.Add(this.btnGerial);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emanet_GeriAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emaneti Geri Al";
            this.Load += new System.EventHandler(this.Emanet_GeriAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGerial;
        private System.Windows.Forms.Button btnGecikme;
        private System.Windows.Forms.TextBox txtCeza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblVerilis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUyeId;
        private System.Windows.Forms.Button btnCeza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ImageList ımageList1;
    }
}