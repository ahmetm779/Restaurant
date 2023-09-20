using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtAd.Text == "" || txtSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen müşterinin Ad ve Soyad alanlarını doldurunuz!", "Uyarı");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool sonuc = c.MusteriVarMi(txtTelefon.Text);
                    if (!sonuc)
                    {
                        c.MusteriAd = txtAd.Text;
                        c.MusteriSoyad = txtSoyad.Text;
                        c.Telefon = txtTelefon.Text;
                        c.Email = txtEMail.Text;
                        c.Adres = txtAdres.Text;
                        txtMusteriNo.Text = c.MusteriEkle(c).ToString();
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri Eklendi.", "Bilgi");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Eklenemedi!!", "Uyarı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu telefon numarası ile daha önceden kayıt yapılmıştır!", "Bilgi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli telefon numarası giriniz!", "Uyarı");
            }
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (cGenel._musteriEkle == 0)
            {
                this.Hide();
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._musteriEkle = 1;
                frm.Show();
                this.Close();
            }
            else if (cGenel._musteriEkle == 1)
            {
                this.Hide();
                frmPaketSiparis frm = new frmPaketSiparis();
                cGenel._musteriEkle = 0;
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtAd.Text == "" || txtSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen müşterinin Ad ve Soyad alanlarını doldurunuz!", "Uyarı");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    c.MusteriAd = txtAd.Text;
                    c.MusteriSoyad = txtSoyad.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Email = txtEMail.Text;
                    c.Adres = txtAdres.Text;
                    c.MusteriId = Convert.ToInt32(txtMusteriNo.Text);
                    bool sonuc = c.MusteriGuncelle(c);

                    if (sonuc)
                    {
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri Güncellendi.", "Bilgi");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Güncellenemedi!!", "Uyarı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu telefon numarası ile daha önceden kayıt yapılmıştır!", "Bilgi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli telefon numarası giriniz!", "Uyarı");
            }
        }

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._musteriId > 0)
            {
                cMusteriler c = new cMusteriler();
                txtMusteriNo.Text = cGenel._musteriId.ToString();
                c.MusterileriGetirById(Convert.ToInt32(txtMusteriNo.Text), txtAd, txtSoyad, txtTelefon, txtAdres, txtEMail);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            this.Close();
            frm.Show();
        }
    }
}
