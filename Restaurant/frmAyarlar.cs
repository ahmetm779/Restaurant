using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
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

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            cPersonel cPersonel = new cPersonel();
            cPersonelGorev cPersonelGorev = new cPersonelGorev();
            string gorev = cPersonelGorev.PersonelGorevTanim(cGenel._gorevId);
            if (gorev == "Müdür")
            {
                cPersonel.PersonelGetByInformation(cbPersonel);
                cPersonelGorev.PersonelGorevGetir(cbGorevi);
                cPersonel.PersonelBilgileriGetirLv(lvPersoneller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = false;
                btnEkle.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lblBilgi.Text = "Mevki : Müdür / Yetki Sınırsız / Kullanıcı : " + cPersonel.PersonelBilgiGetirIsim(cGenel._personelId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblBilgi.Text = "Mevki : Müdür / Yetki Sınırlı / Kullanıcı : " + cPersonel.PersonelBilgiGetirIsim(cGenel._personelId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() != "" || txtYeniSifreTekrar.Text.Trim() != "")
            {
                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    if (txtPersonelId.Text != "")
                    {
                        cPersonel cPersonel = new cPersonel();
                        bool sonuc = cPersonel.PersonelSifreDegistir(Convert.ToInt32(txtPersonelId.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla gerçekleşmiştir.", "Bilgi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz!", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil!", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakmayınız!", "Uyarı");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev cPersonelGorev = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevId2.Text = Convert.ToString(cPersonelGorev.PersonelGorevId);
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonel cPersonel = (cPersonel)cbPersonel.SelectedItem;
            txtPersonelId.Text = Convert.ToString(cPersonel.PersonelId);

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnEkle.Enabled = true;
            btnBilgiDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersonel cPersonel = new cPersonel();
                    bool sonuc = cPersonel.PersonelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Silinmiştir.", "Bilgi");
                        cPersonel.PersonelBilgileriGetirLv(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Silinirken Bir Hata Oluştu.", "Bilgi");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Seçiniz!", "Bilgi");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" & txtSoyad.Text.Trim() != "" & txtSifre.Text.Trim() != "" & txtSifreTekrar.Text.Trim() != "" & txtGorevId2.Text.Trim() != "")
            {
                if ((txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifre.Text.Length > 5))
                {
                    cPersonel cPersonel = new cPersonel();
                    cPersonel.PersonelAd = txtAd.Text.Trim();
                    cPersonel.PersonelSoyad = txtSoyad.Text.Trim();
                    cPersonel.PersonelParola = txtSifre.Text.Trim();
                    cPersonel.GorevId = Convert.ToInt32(txtGorevId2.Text.Trim());
                    bool sonuc = cPersonel.PersonelEkle(cPersonel);
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                        cPersonel.PersonelBilgileriGetirLv(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Eklenirken Bir Hata Oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Alanları Aynı ve 5 Karakterden Fazla Olmalı!");
                }
            }
            else
            {
                MessageBox.Show("Alanları Doldurun!");
            }
        }

        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (txtAd.Text != "" || txtSoyad.Text != "" || txtSifre.Text != "" || txtSifreTekrar.Text != "" || txtGorevId2.Text != "")
                {
                    if ((txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifre.Text.Length > 5))
                    {
                        cPersonel cPersonel = new cPersonel();
                        cPersonel.PersonelAd = txtAd.Text.Trim();
                        cPersonel.PersonelSoyad = txtSoyad.Text.Trim();
                        cPersonel.PersonelParola = txtSifre.Text.Trim();
                        cPersonel.GorevId = Convert.ToInt32(txtGorevId2.Text.Trim());
                        bool sonuc = cPersonel.PersonelGuncelle(cPersonel, Convert.ToInt32(txtPersonelD.Text));
                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir.");
                            cPersonel.PersonelBilgileriGetirLv(lvPersoneller);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Güncellenirken Bir Hata Oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre Alanları Aynı Değil!");
                    }
                }
                else
                {
                    MessageBox.Show("Alanları Doldurun!");
                }
            }
            else
            {
                MessageBox.Show("Kayıt Seçiniz!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Trim() != "" || textBox9.Text.Trim() != "")
            {
                if (textBox8.Text == textBox9.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersonel cPersonel = new cPersonel();
                        bool sonuc = cPersonel.PersonelSifreDegistir(Convert.ToInt32(cGenel._personelId), textBox8.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla gerçekleşmiştir.", "Bilgi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz!", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil!", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakmayınız!", "Uyarı");
            }
        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                txtPersonelD.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
            else
                btnSil.Enabled = false;
        }
    }
}
