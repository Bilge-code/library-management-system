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
    public partial class Kullanici_Islemleri : Form
    {
        public Kullanici_Islemleri()
        {
            InitializeComponent();
        }

        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int uzunluk = txtAd.Text.Length;
            string ad= txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTel.Text;
            
            string randomSifre =ad+ soyad + telefon;
            int uzunlukSifre = randomSifre.Length;
            string kullaniciAdi = "";

            groupBox1.Visible = true;

            if( uzunluk<4)
            {
                kullaniciAdi = txtSoyad.Text.Substring(0, 3) + txtTel.Text;
            }
            else
            {
                kullaniciAdi = txtSoyad.Text.Substring(0, 4) + txtTel.Text.Substring(7, 4); // 7den başla 4 karakter al.(substring) 
                
            }
            lblOneri.Text = kullaniciAdi;
              
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sonuc = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSifre.Text));
      
            tbl_Kullanici tbl = new tbl_Kullanici();
            tbl.KullaniciAd = txtAd.Text;
            tbl.KullaniciSoyad = txtSoyad.Text;
            tbl.KullaniciTel = txtTel.Text;
            tbl.KullaniciTc = txtTc.Text;
            tbl.KullaniciPasNo = txtPasNo.Text;
            tbl.KullaniciMail = txtPosta.Text;
            tbl.KullaniciKadi = txtKadi.Text;
            tbl.KullaniciSifre = sonuc;


            db.tbl_Kullanici.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Kayıt işlemi tamamlandı, giriş yapapabilirsiniz.", "Bilgi");

        }

        private void Kullanici_Islemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSifre.Text));

            var bul = db.tbl_Kullanici.Where(x => x.KullaniciTc == txtTc.Text).FirstOrDefault();
            bul.KullaniciAd = txtAd.Text;
            bul.KullaniciSoyad = txtSoyad.Text;
            bul.KullaniciTel = txtTel.Text;
            bul.KullaniciPasNo = txtPasNo.Text;
            bul.KullaniciMail = txtPosta.Text;
            bul.KullaniciKadi = txtKadi.Text;
            bul.KullaniciSifre = sonuc;

            db.SaveChanges();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.ShowDialog();
            
        }
    }
}

  
