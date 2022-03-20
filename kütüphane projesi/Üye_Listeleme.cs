using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace kütüphane_projesi
{
    public partial class Üye_Listeleme : Form
    {
        public Üye_Listeleme()
        {
            InitializeComponent();
        }
        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();
            

        private void Üye_Listeleme_Load(object sender, EventArgs e)
        {
            btnListele.PerformClick();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sec = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var sonuc = db.tbl_Uyeler.Where(x => x.UyeID == sec).FirstOrDefault();
            sonuc.Ad = txtAd.Text;
            sonuc.Soyad = txtSoyad.Text;
            sonuc.Telefon = txtTel.Text;
            sonuc.Tc = txtTc.Text;
            sonuc.PasaportNo = txtPasno.Text;
            sonuc.Email = txtPosta.Text;
            sonuc.Adres = richtxtAdres.Text;
            sonuc.Ceza = Convert.ToDouble(txtCeza.Text);

            db.SaveChanges();
            btnListele.PerformClick();

            txtAd.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            txtTel.Text = String.Empty;
            txtTc.Text = String.Empty;
            txtPasno.Text = string.Empty;
            txtPosta.Text = String.Empty;
            richtxtAdres.Text = string.Empty;
            txtCeza.Text = string.Empty;

        }

   

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sec = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var sonuc = db.tbl_Uyeler.Where(x => x.UyeID == sec).FirstOrDefault();
            db.tbl_Uyeler.Remove(sonuc);
            db.SaveChanges();
            btnListele.PerformClick();
            

        }    

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtPasno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtPosta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                richtxtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtCeza.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_İşlemleri frm = new Kitap_İşlemleri();
            frm.Show();
            
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_Listeleme frm = new Kitap_Listeleme();
            frm.Show();
            

        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Üye_İşlemleri frm = new Üye_İşlemleri();
            frm.Show();
          
        }

        private void emanetVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanet_Ver frm = new Emanet_Ver();
            frm.Show();
            

        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanet_GeriAl frm = new Emanet_GeriAl();
            frm.Show();
            

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
            catch(Exception exp)
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
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

    

        private void btnAra_Click(object sender, EventArgs e)
        {
            var Uyelist = db.tbl_Uyeler.ToList();
            dataGridView1.DataSource = Uyelist.ToList();

            if (rdbtnAd.Checked)
            {   
                var arananUye = db.tbl_Uyeler.Where(x => x.Ad.Contains(txtAra.Text)).ToList();
                dataGridView1.DataSource = arananUye;
            }
            else if(rdbtnTel.Checked==true)
            {
                string gelenTel = txtAra.Text;
                var arananTel = db.tbl_Uyeler.Where(x => x.Telefon.Contains(gelenTel)).ToList();
                
                dataGridView1.DataSource = arananTel;
            }
            else
            {
                string gelenTc = txtAra.Text;
                var arananTc = db.tbl_Uyeler.Where(x => x.Tc.Equals(gelenTc)).ToList();
                dataGridView1.DataSource = arananTc;
            }
         

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var Uyelist = db.tbl_Uyeler.ToList();
            dataGridView1.DataSource = Uyelist.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022020,CE", "HAZIRLAYANLAR \n Kişisel Bilgi");
        }
    }
}
