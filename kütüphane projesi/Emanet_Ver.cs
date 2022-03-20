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

namespace kütüphane_projesi
{
    public partial class Emanet_Ver: Form
    {
        public Emanet_Ver()
        {
            InitializeComponent();
        }
        
        KutuphaneProjesiEntities2 db =new KutuphaneProjesiEntities2();

        private void Emanet_Ver_Load(object sender, EventArgs e)
        {

            var EmanetList = db.tbl_Emanet.ToList();
            dataGridView2.DataSource = EmanetList.ToList(); //listeledik emanetleri

            var KitapList = db.tbl_Kitap.ToList();
            dataGridView1.DataSource = KitapList.ToList(); //kitap listeleme

            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;    //ilişkilendirmeler gizlendi
            dataGridView1.Columns[7].Visible = false;

            dataGridView2.Columns[1].HeaderText = "Üye Id";
            dataGridView2.Columns[2].HeaderText = "Kitap Id"; //kolon adları değiş

        }

       
        private void btnBul_Click(object sender, EventArgs e)
        {
            string bul = txtBul.Text;
            var UyeVarMi = db.tbl_Uyeler.Where(x => x.Telefon == bul).FirstOrDefault();
            if (UyeVarMi != null)
                lblAd.Text = UyeVarMi.Ad + " " + UyeVarMi.Soyad;
            else
                lblAd.Text = "Üye Bulunamadı";

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //kişiyi aldık databasedem
            string secilenKisiTel = txtBul.Text;
            var secilenKisi = db.tbl_Uyeler.Where(x => x.Telefon.Equals(secilenKisiTel)).FirstOrDefault();

            int secilenKitapID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var secilenKitap = db.tbl_Kitap.Where(x => x.KitapID == secilenKitapID).FirstOrDefault();

            tbl_Emanet yeniEmanet = new tbl_Emanet();
            yeniEmanet.EmanetKitapId = secilenKitap.KitapID;
            yeniEmanet.EmanetUyeId = secilenKisi.UyeID;
            yeniEmanet.EmanetVertarih = DateTime.Today;
            yeniEmanet.EmanetAltarih = DateTime.Today.AddDays(15);
           
            yeniEmanet.EmanetDurum = false;

            db.tbl_Emanet.Add(yeniEmanet);
            db.SaveChanges();

            var EmanetList = db.tbl_Emanet.ToList();
            dataGridView2.DataSource = EmanetList.ToList();

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = txtAra.Text;
            var aranankitaplar = db.tbl_Kitap.Where(x => x.KitapAdi.Contains(gelenAd)).ToList();
            dataGridView1.DataSource = aranankitaplar;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kitapToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022026,CE", "HAZIRLAYANLAR \n Kişisel Bilgi");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnVer_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
