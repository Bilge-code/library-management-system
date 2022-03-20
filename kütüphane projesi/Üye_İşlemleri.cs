using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_projesi
{
    public partial class Üye_İşlemleri : Form
    {
        public Üye_İşlemleri()
        {
            InitializeComponent();
        }
        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();

        DataTable tablo = new DataTable();

        private void btnKaydet_Click(object sender, EventArgs e)

        {

            btnGonder.Visible = true;
            dataGridView1.Visible = true;
            tablo.Rows.Add(txtAd.Text, txtSoyad.Text, txtTel.Text, txtTc.Text, txtPasNo.Text ,txtPosta.Text, richtxtAdres.Text,txtCeza.Text);
            dataGridView1.DataSource = tablo;
        }
        
        private void Üye_İşlemleri_Load(object sender, EventArgs e)
            
        {

            tablo.Columns.Add("Üye adı", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("Tc", typeof(string));
            tablo.Columns.Add("Pasaport Seri No", typeof(string));
            tablo.Columns.Add("E-posta", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Ceza", typeof(long));


        }

  
        private void btnGonder_Click(object sender, EventArgs e)
        {
            tbl_Uyeler tbl = new tbl_Uyeler();
            tbl.Ad = txtAd.Text;
            tbl.Soyad = txtSoyad.Text;
            tbl.Telefon = txtTel.Text;
            tbl.Tc = txtTc.Text;
            tbl.PasaportNo = txtPasNo.Text;
            tbl.Email = txtPosta.Text;
            tbl.Adres = richtxtAdres.Text;
            tbl.Ceza = Convert.ToDouble(txtCeza.Text);

            db.tbl_Uyeler.Add(tbl);
            db.SaveChanges();


            MessageBox.Show("Yeni üye başarıyla eklendi.", "Bilgi");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void richtxtAdres_TextChanged(object sender, EventArgs e)
        {

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

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022020,CE", "HAZIRLAYANLAR\nKişisel Bilgi");
        }
    }
}
