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
    public partial class Anasayfa : Form
    {
        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();
        public Anasayfa(int id)
        {
            InitializeComponent();
            var sonuc = db.tbl_Kullanici.Where(x => x.KullaniciID == id).FirstOrDefault();
            tsslKullanici.Text = sonuc.KullaniciAd;
            tsslGiris.Text= sonuc.SonGiris;

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnkitap_Click(object sender, EventArgs e)
        {
            Kitap_İşlemleri frm = new Kitap_İşlemleri();
            frm.ShowDialog();
           
            
        }

        private void btnüye_Click(object sender, EventArgs e)
        {
            Üye_İşlemleri frm = new Üye_İşlemleri();
            frm.ShowDialog();
           
        }

        private void btnemanet_Click(object sender, EventArgs e)
        {
            Emanet_Ver frm = new Emanet_Ver();
            frm.ShowDialog();
           

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022026,CE", "Kişisel Bilgi");
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tsslGiris.Text = DateTime.Now.ToString();
        }

        private void btnUyeList_Click(object sender, EventArgs e)
        {
            Üye_Listeleme frm = new Üye_Listeleme();
            frm.ShowDialog();
            

        }

        private void btnkitaplist_Click(object sender, EventArgs e)
        {
            Kitap_Listeleme frm = new Kitap_Listeleme();
            frm.ShowDialog();
            
        }

        private void btnTarayici_Click(object sender, EventArgs e)
        {
            Tarayıcı frm = new Tarayıcı();
            frm.ShowDialog();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnkitap_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnüye_MouseLeave(object sender, EventArgs e)
        {
            btnüye.BackColor = Color.WhiteSmoke;
        }

        private void btnkitap_MouseEnter(object sender, EventArgs e)
        {
            btnkitap.BackColor = Color.IndianRed;
        }

        private void btnkitap_MouseLeave(object sender, EventArgs e)
        {
            btnkitap.BackColor = Color.WhiteSmoke;
        }

        private void btnkitaplist_MouseEnter(object sender, EventArgs e)
        {
            btnkitaplist.BackColor = Color.IndianRed;
        }

        private void btnkitaplist_MouseLeave(object sender, EventArgs e)
        {
            btnkitaplist.BackColor = Color.WhiteSmoke;
        }

        private void btnüye_MouseEnter(object sender, EventArgs e)
        {
            btnüye.BackColor = Color.IndianRed;
        }

        private void btnUyeList_MouseEnter(object sender, EventArgs e)
        {
            btnUyeList.BackColor =Color.IndianRed;
        }

        private void btnUyeList_MouseLeave(object sender, EventArgs e)
        {
            btnUyeList.BackColor = Color.WhiteSmoke;
        }

        private void btnemanetver_MouseEnter(object sender, EventArgs e)
        {
            btnemanetver.BackColor = Color.IndianRed;
        }

        private void btnemanetver_MouseLeave(object sender, EventArgs e)
        {
            btnemanetver.BackColor = Color.WhiteSmoke;
        }

        private void btnGerial_MouseEnter(object sender, EventArgs e)
        {
            btnGerial.BackColor = Color.IndianRed;
        }

        private void btnGerial_MouseLeave(object sender, EventArgs e)
        {
            btnGerial.BackColor = Color.WhiteSmoke;
        }

        private void btnGerial_Click(object sender, EventArgs e)
        {
            Emanet_GeriAl frm = new Emanet_GeriAl();
            frm.ShowDialog();
            
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            DialogResult res = new DialogResult();
            res = MessageBox.Show("Çıkış yapmak istiyor musunuz", "Uyarı!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                File.AppendAllText("Girişler Çıkışlar log.txt", "ÇIKIŞ\n" + "Kullanıcı:" + tsslKullanici.Text + "\nTarih:" + DateTime.Now.ToString() + "Sistemden çıkış yapıldı.\n\n");
                this.Close();
            }
        }
    }
}  
