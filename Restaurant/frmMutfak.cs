using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
        }

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cUrunCesitleri AnaKategori = new cUrunCesitleri();
            AnaKategori.UrunleriCesitleriListele(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;

            label6.Visible = false;
            txtAra.Visible = false;

            cUrunler cUrunler = new cUrunler();
            cUrunler.UrunleriListele(lvGidaListesi);
        }
        private void Temizle()
        {
            txtGidaAdi.Clear();
            txtGidaFiyati.Clear();
            txtGidaFiyati.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gıda adı, fiyatı ve kategori seçilmemiştir.", "Dikkat Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler cUrunler = new cUrunler();
                    cUrunler.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    cUrunler.Urunad = txtGidaAdi.Text;
                    cUrunler.Aciklama = "Ürün eklendi.";
                    cUrunler.UrunTurNo = urunTurNo;
                    int sonuc = cUrunler.UrunEkle(cUrunler);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Eklenmiştir.");
                        cbKategoriler_SelectedIndexChanged(sender, e);
                        yenile();
                        Temizle();
                    }

                }
            }
            else
            {
                if (txtKategoriAd.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori ismi giriniz.", "Dikkat Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAciklama.Text;
                    int sonuc = gida.UrunCesitEkle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Eklenmiştir.");
                        yenile();
                        Temizle();
                    }
                }
            }
        }
        int urunTurNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler cUrunler = new cUrunler();
            if (cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                cUrunler.UrunleriListele(lvGidaListesi);
            }
            else
            {
                cUrunCesitleri cUrunCesitleri = (cUrunCesitleri)cbKategoriler.SelectedItem;
                urunTurNo = cUrunCesitleri.UrunTurNo;
                cUrunler.UrunleriListeleByUrunId(lvGidaListesi, urunTurNo);
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gıda adı, fiyatı ve kategori seçilmemiştir.", "Dikkat Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler cUrunler = new cUrunler();
                    cUrunler.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    cUrunler.Urunad = txtGidaAdi.Text;
                    cUrunler.UrunId = Convert.ToInt32(txtUrunId.Text);
                    cUrunler.Aciklama = "Ürün Güncellendi.";
                    cUrunler.UrunTurNo = urunTurNo;
                    int sonuc = cUrunler.UrunGuncelle(cUrunler);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Güncellenmiştir.");
                        yenile();
                        Temizle();
                    }

                }
            }
            else
            {
                if (txtKategoriId.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "Dikkat Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAciklama.Text;
                    gida.UrunTurNo = Convert.ToInt32(txtKategoriId.Text);
                    int sonuc = gida.UrunCesitGuncelle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Güncellenmiştir.");
                        gida.UrunleriCesitleriListele(lvKategoriler);
                        Temizle();
                    }
                }
            }
        }

        private void lvGidaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                txtGidaAdi.Text = lvGidaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidaFiyati.Text = lvGidaListesi.SelectedItems[0].SubItems[4].Text;
                txtUrunId.Text = lvGidaListesi.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                txtKategoriAd.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtKategoriId.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
                txtAciklama.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (lvGidaListesi.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Ürünü Silmek İstediğinizden Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler cUrunler = new cUrunler();
                        cUrunler.UrunId = Convert.ToInt32(txtUrunId.Text);
                        int sonuc = cUrunler.UrunSil(cUrunler, 1);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün Silinmiştir.");
                            yenile();
                            Temizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürünü Silmek İçin Bir Ürün Seçilmesi Gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lvKategoriler.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Ürünü Silmek İstediğinizden Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunCesitleri cUrunCesitleri = new cUrunCesitleri();
                        int sonuc = cUrunCesitleri.UrunCesitSil(Convert.ToInt32(txtKategoriId.Text));
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Kategori Silinmiştir.");
                            cUrunler cUrunler = new cUrunler();
                            cUrunler.UrunId = Convert.ToInt32(txtKategoriId.Text);
                            cUrunler.UrunSil(cUrunler, 0);
                            yenile();
                            Temizle();
                        }
                    }
                }
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
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            txtAra.Visible = true;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                cUrunler cUrunler = new cUrunler();
                cUrunler.UrunleriListeleByUrunAdi(lvGidaListesi, txtAra.Text);
            }
            else
            {
                cUrunCesitleri cUrunCesitleri = new cUrunCesitleri();
                cUrunCesitleri.UrunleriCesitleriListele(lvKategoriler, txtAra.Text);
            }
        }

        private void rbAltKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGidaListesi.Visible = true;
            yenile();
        }

        private void rbAnaKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGidaListesi.Visible = false;
            yenile();
        }
        private void yenile()
        {
            cUrunCesitleri cUrunCesitleri = new cUrunCesitleri();
            cUrunCesitleri.UrunleriCesitleriListele(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            cUrunCesitleri.UrunleriCesitleriListele(lvKategoriler);

            cUrunler cUrunler = new cUrunler();
            cUrunler.UrunleriListele(lvGidaListesi);
        }
    }
}
