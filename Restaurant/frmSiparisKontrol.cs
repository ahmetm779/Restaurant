using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmSiparisKontrol : Form
    {
        public frmSiparisKontrol()
        {
            InitializeComponent();
        }

        private void frmSiparisKontrol_Load(object sender, EventArgs e)
        {
            cAdisyon cAdisyon = new cAdisyon();
            int butonSayisi = cAdisyon.PaketAdisyonAdediBul();
            cAdisyon.AcikPaketAdisyonlar(lvMusteriler);
            int alt = 50;
            int sol = 1;
            int bol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(butonSayisi)));
            for (int i = 1; i <= butonSayisi; i++)
            {
                Button btn = new Button();
                btn.AutoSize = false;
                btn.Size = new Size(180, 80);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Name = lvMusteriler.Items[i - 1].SubItems[0].Text;
                btn.Text = lvMusteriler.Items[i - 1].SubItems[1].Text;
                btn.Font = new Font(btn.Font.FontFamily.Name, 18);
                btn.Location = new Point(sol, alt);
                this.Controls.Add(btn);

                sol += btn.Width + 5;
                if (i == 2)
                {
                    sol = 1;
                    alt += 50;
                }
                btn.Click += new EventHandler(DinamikMetod);
                btn.MouseEnter += new EventHandler(DinamikMetod2);
            }
        }

        protected void DinamikMetod(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
            Button dinamikButton = (sender as Button);
            frmBill frm = new frmBill();
            cGenel._ServisTurNo = 2;
            cGenel._AdisyonId = Convert.ToString(c.MusterininSonAdisyonId(Convert.ToInt32(dinamikButton.Name)));
            frm.Show();
        }
        protected void DinamikMetod2(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
            Button dinamikButton = (sender as Button);
            c.MusteriDetaylari(lvMusteriDetaylari, Convert.ToInt32(dinamikButton.Name));
            SonSiparisTarihi();
            lvSatisDetaylari.Items.Clear();
            cSiparis cSiparis = new cSiparis();
            cGenel._ServisTurNo = 2;
            cGenel._AdisyonId = Convert.ToString(c.MusterininSonAdisyonId(Convert.ToInt32(dinamikButton.Name)));

            lblGenelToplam.Text = cSiparis.GenelToplamBul(Convert.ToInt32(dinamikButton.Name)).ToString() + " TL";

        }
        void SonSiparisTarihi()
        {
            if (lvMusteriDetaylari.Items.Count > 0)
            {
                int s = lvMusteriDetaylari.Items.Count;
                lblSonSiparisTarihi.Text = lvMusteriDetaylari.Items[s - 1].SubItems[3].Text;
                txtToplamTutar.Text = s + " Adet";
            }
        }
        void Toplam()
        {
            int kayitSayisi = lvSatisDetaylari.Items.Count;
            decimal toplam = 0;
            for (int i = 0; i < kayitSayisi; i++)
            {
                toplam += Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[2].Text) * Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[3].Text);
            }
            lblToplamSiparis.Text = toplam.ToString() + " TL";
        }

        private void lvMusteriDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMusteriDetaylari.Items.Count > 0)
            {
                cSiparis cSiparis = new cSiparis();
                cSiparis.PaketSiparisAdisyonDetaylari(lvSatisDetaylari, Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[4].Text));
                Toplam();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
    }
}
