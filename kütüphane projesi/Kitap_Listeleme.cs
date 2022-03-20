using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace kütüphane_projesi
{
    public partial class Kitap_Listeleme : Form
    {
        public Kitap_Listeleme()
        {
            InitializeComponent();
        }
        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();

       
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sec = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var sonuc = db.tbl_Kitap.Where(x => x.KitapID == sec).FirstOrDefault();
            sonuc.KitapAdi = txtKitap.Text;
            sonuc.Yazar = txtYazar.Text;
            sonuc.BaskiYili = Convert.ToInt16(numericBaski.Value);
            sonuc.SayfaSayisi = Convert.ToInt16(numericSayfa.Value);
            sonuc.Yayinevi = txtYayinevi.Text;
            sonuc.Türü = txtTur.Text;

            db.SaveChanges();
            btnListele.PerformClick();

            txtKitap.Text = string.Empty;
            txtYazar.Text = string.Empty;
            numericBaski.Value = 0;
            numericSayfa.Value = 0;
            txtYazar.Text = string.Empty;
            txtYayinevi.Text = string.Empty;
            txtTur.Text = string.Empty;

        }


        private void Kitap_Listeleme_Load(object sender, EventArgs e)
        {
            btnListele.PerformClick();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtKitap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtYazar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                numericBaski.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
                numericSayfa.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);
                txtYayinevi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtTur.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sec = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var sonuc = db.tbl_Kitap.Where(x => x.KitapID == sec).FirstOrDefault();
            db.tbl_Kitap.Remove(sonuc);
            db.SaveChanges();
            btnListele.PerformClick();

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            var Kitaplist = db.tbl_Kitap.ToList();
            dataGridView1.DataSource = Kitaplist.ToList();

            if (rdbtnAd.Checked)
            {
                var arananAd = db.tbl_Kitap.Where(x => x.KitapAdi.Contains(txtAra.Text)).ToList();
                dataGridView1.DataSource = arananAd;
            }
            else if (rdbtnYazar.Checked)
            {
                string gelenYazar = txtAra.Text;
                var arananYazar = db.tbl_Kitap.Where(x => x.Yazar.Contains(gelenYazar)).ToList();

                dataGridView1.DataSource = arananYazar;
            }
            else
            {
                string gelenTur = txtAra.Text;
                var arananTur = db.tbl_Kitap.Where(x => x.Türü.Contains(gelenTur)).ToList();
                dataGridView1.DataSource = arananTur;
            }
        }
        Bitmap bmp;
        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                dataGridView1.Height = height;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
      
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bmp, 0, 0);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var kitaplist = db.tbl_Kitap.ToList();
            dataGridView1.DataSource = kitaplist.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022020,CE", "HAZIRLAYANLAR \n Kişisel Bilgi");
        }

        private void emanetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emanetVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanet_Ver frm = new Emanet_Ver();
            frm.ShowDialog();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanet_GeriAl frm = new Emanet_GeriAl();
            frm.ShowDialog();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Üye_İşlemleri frm = new Üye_İşlemleri();
            frm.ShowDialog();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Üye_Listeleme frm = new Üye_Listeleme();
            frm.ShowDialog();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_İşlemleri frm = new Kitap_İşlemleri();
            frm.ShowDialog();

        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_Listeleme frm = new Kitap_Listeleme();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
