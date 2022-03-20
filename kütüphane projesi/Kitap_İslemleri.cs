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
using System.Data.OleDb;
using System.Data.Odbc;
using System.Xml.Linq;

namespace kütüphane_projesi
{
    public partial class Kitap_İşlemleri : Form
    {
        public Kitap_İşlemleri()
        {
            InitializeComponent();
        }
        



        KutuphaneProjesiEntities2 db= new KutuphaneProjesiEntities2();


        private void btnSil_Click(object sender, EventArgs e)
        {
            lstkitaplar.Items.Remove(lstkitaplar.SelectedItem);

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if ((x) is Button)
                {
                    x.Font = new Font("Lucida Sans Typewriter", 9);

                }
            }
        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if ((x) is Button)
                {
                    x.BackColor=Color.Aqua;
                   
                }
            }
          
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022026,CE", "HAZIRLAYANLAR\nKişisel Bilgi");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Kitap_İşlemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            btnSil.Visible = true;
            btnEkle.Visible = true;
            lstkitaplar.Visible = true;
            lstkitaplar.Items.Add(txtNo.Text);
            lstkitaplar.Items.Add(txtKitap.Text);
            lstkitaplar.Items.Add(txtYazar.Text);
            lstkitaplar.Items.Add(numericBaski.Value);
            lstkitaplar.Items.Add(numericSayfa.Value);
            lstkitaplar.Items.Add(txtYayinevi.Text);
            lstkitaplar.Items.Add(txtTur.Text);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Kitap tbl = new tbl_Kitap();
                tbl.BarkodNo = txtNo.Text;
                tbl.KitapAdi = txtKitap.Text;
                tbl.Yazar = txtYazar.Text;
                tbl.BaskiYili = Convert.ToInt16(numericBaski.Value);
                tbl.SayfaSayisi = Convert.ToInt16(numericSayfa.Value);
                tbl.Yayinevi = txtYayinevi.Text;
                tbl.Türü = txtTur.Text;


                db.tbl_Kitap.Add(tbl);
                db.SaveChanges();
                MessageBox.Show("Kitap Eklendi", "Bilgi");

                txtNo.Text = String.Empty;
                txtKitap.Text = String.Empty;
                txtYazar.Text = String.Empty;
                numericBaski.Value = 0;
                numericSayfa.Value = 0;
                txtYayinevi.Text = String.Empty;
                txtTur.Text = string.Empty;


            }


            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void txtYayinevi_TextChanged(object sender, EventArgs e)
        {

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
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022020,CE", "HAZIRLAYANLAR \n Kişisel Bilgi");
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void Kitap_İşlemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
             
        }
    }
}
