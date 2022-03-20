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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();

        int GuvenlikKodu(string x)
        {
            int a = DateTime.Now.Second;
            int b = Convert.ToInt32(x);
            int sonuc = (a * 93) * b*2;
            return sonuc;

        }

        int sayac = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //string adres = @"C:\Görsel Programlama\proje\log.txt";
            string gelenAd = txtAd.Text;
            string sifreSonuc = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSifre.Text));
            var kullanici = db.tbl_Kullanici.Where(x =>x.KullaniciKadi.Equals(gelenAd)&&x.KullaniciSifre.Equals(sifreSonuc)).FirstOrDefault();

            try
            {     
                if(kullanici != null && (txtGuvenlik.Text == lblGuvenlik.Text))
                {
                    File.AppendAllText("Girişler log.txt", "GİRİŞ\n" + "Kullanıcı:" + txtAd.Text + "\nTarih:" + DateTime.Now.ToString() + "Sisteme giriş yapıldı.\n\n");
                    kullanici.SonGiris = DateTime.Now.ToString();
                    db.SaveChanges();
                    Anasayfa frm = new Anasayfa(kullanici.KullaniciID);
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    File.AppendAllText("Girişler log.txt", "GİRİŞ\n" + "Kullanıcı:" + txtAd.Text + "\nTarih:" + DateTime.Now.ToString() + "\nSisteme hatalı giriş yaptı.\n\n");
              
                    txtAd.Clear();
                    txtSifre.Clear();
                    txtGuvenlik.Clear();

                    sayac++;
                    lblHata.Visible = true;
                    lblHatagiris.Visible = true;
                    lblHata.ForeColor = Color.Black;
                    lblHata.Text = sayac.ToString();
                    if (sayac >= 3)
                    {
                        txtAd.ReadOnly = true;
                        txtSifre.ReadOnly = true;
                        txtGuvenlik.ReadOnly = true;
                        lblHata.Enabled = true;
                        MessageBox.Show("Güvenliğiniz için şifrenizi yenileyiniz.", "Uyarı");
                    }
                }
            }
            catch (Exception a)
            {
                File.AppendAllText("Girişler log.txt", "GİRİŞ\n" + "Kullanıcı:" + txtAd.Text + "\nTarih:" + DateTime.Now.ToString() + "\nSistem hatası alındı.\n" + a.Message);
                MessageBox.Show("Sistem hatası aldınız! " + a.Message);
            }
        }


        private void Giris_Load(object sender, EventArgs e)
        {
            string kod;
            kod = (DateTime.Now.Minute + DateTime.Now.Second).ToString();
            int sonuc= GuvenlikKodu(kod);
            lblGuvenlik.Text = sonuc.ToString();

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            string kod;
            kod = (DateTime.Now.Minute + DateTime.Now.Second).ToString();
            int sonuc = GuvenlikKodu(kod);
            lblGuvenlik.Text = sonuc.ToString();

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kullanici_Islemleri frm = new Kullanici_Islemleri();
            frm.Show();

        }
    }
 }


   