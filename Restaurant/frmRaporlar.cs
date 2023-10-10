using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurant
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
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
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
            this.Close();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {

        }
        private void Istatistik(string gfName, int katId, Color renk)
        {
            //chRapor.Palette = ChartColorPalette.None;
            //chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            //chRapor.Series[0].Color = renk;
            //cUrunler cUrunler = new cUrunler();
            //lvIstatistik.Items.Clear();
            //cUrunler.UrunleriListeleIstatistiklereGoreUrunId(lvIstatistik, dtBaslangic, dtBitis, katId);
            //gbIstatistik.Text = gfName;
            //if (lvIstatistik.Items.Count > 0)
            //{
            //    chRapor.Series["Satislar"].Points.Clear();
            //    for (int i = 0; i < lvIstatistik.Items.Count; i++)
            //    {
            //        chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Gösterilecek İstatistik Yok. Başka Tarih Seçin.");
            //}
        }
        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            Istatistik("Ana Yemekler Grafiği", 3, Color.Red);
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler Grafiği", 8, Color.Orange);
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            Istatistik("Tatlılar Grafiği", 7, Color.Blue);
        }

        private void btnSalatalar_Click(object sender, EventArgs e)
        {
            Istatistik("Salatalar Grafiği", 6, Color.Green);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            Istatistik("FastFood Grafiği", 5, Color.LightBlue);
        }

        private void btnCorbalar_Click(object sender, EventArgs e)
        {
            Istatistik("Çorba Grafiği", 1, Color.Yellow);
        }

        private void btnMakarnalar_Click(object sender, EventArgs e)
        {
            Istatistik("Makarna Grafiği", 4, Color.Purple);
        }

        private void btnAraSicaklar_Click(object sender, EventArgs e)
        {
            Istatistik("Ara Sıcaklar Grafiği", 2, Color.Goldenrod);
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            //chRapor.Palette = ChartColorPalette.None;
            //chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            //chRapor.Series[0].Color = Color.GreenYellow;
            //cUrunler cUrunler = new cUrunler();
            //lvIstatistik.Items.Clear();
            //cUrunler.UrunleriListeleIstatistiklereGore(lvIstatistik, dtBaslangic, dtBitis);
            //gbIstatistik.Text = "Tüm Ürünler";
            //if (lvIstatistik.Items.Count > 0)
            //{
            //    chRapor.Series["Satislar"].Points.Clear();
            //    for (int i = 0; i < lvIstatistik.Items.Count; i++)
            //    {
            //        chRapor.Series["Satislar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Gösterilecek İstatistik Yok. Başka Tarih Seçin.");
            //}
        }
    }
}
