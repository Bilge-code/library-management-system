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
    public partial class Emanet_GeriAl : Form
    {
        public Emanet_GeriAl()
        {
            InitializeComponent();
        }
        KutuphaneProjesiEntities2 db = new KutuphaneProjesiEntities2();

        private void Emanet_GeriAl_Load(object sender, EventArgs e)
        {

            btnListele.PerformClick();
     
        }


        private void btnGerial_Click(object sender, EventArgs e)
        {
            int secilenEmanetID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var Emanet = db.tbl_Emanet.Where(x => x.EmanetID == secilenEmanetID).FirstOrDefault();
            Emanet.EmanetDurum = true;
            db.SaveChanges();

            //btnCeza.PerformClick();
            //btnListele.PerformClick();

         

        }

        private void dataGridView1_BackgroundColorChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            


        }
        private void btnGecikme_Click(object sender, EventArgs e)
        {
            var gecikme = db.tbl_Emanet.Where(x => x.EmanetAltarih <= DateTime.Today&&x.EmanetDurum==false).ToList();
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.GridColor = Color.Red;
            dataGridView1.DataSource = gecikme;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Value =Convert.ToDateTime( dataGridView1.CurrentRow.Cells[3].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            txtUyeId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            cezayapılandır();

        }

        void cezayapılandır()   
        {
            DateTime d1;
            DateTime d2;
            d1 = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            d2 = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            TimeSpan ts = DateTime.Today - d2;
            if (ts.Days > 0)
            { 
                int ceza = ts.Days * 3;                    // üyenin kitabı getirmediği her gün 3tl ceza kesilecek. 
                txtCeza.Text = ceza.ToString();
            }
            else
            {
                txtCeza.Text = "0";
            }

        }

        private void btnCeza_Click(object sender, EventArgs e)
        {
            cezayapılandır();

            int secilenUyeID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value);
            var uye = db.tbl_Uyeler.Where(x => x.UyeID == secilenUyeID).FirstOrDefault();
            uye.Ceza = Convert.ToInt16(txtCeza.Text);
            db.SaveChanges();

            MessageBox.Show("Üye cezası eklendi,kitabı geri alınız.", "Bilgi");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var Emanetler = db.tbl_Emanet.Where(x => x.EmanetDurum == false).ToList();
            dataGridView1.DataSource = Emanetler.ToList();

            dataGridView1.ForeColor = Color.Black;
            dataGridView1.GridColor = Color.White;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            
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

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Berivan Zincir,1903022026,CE \n Sertav Çiya Timurtaş,1903022006,CE", "HAZIRLAYANLAR \n Kişisel Bilgi");
        }
    }
}
