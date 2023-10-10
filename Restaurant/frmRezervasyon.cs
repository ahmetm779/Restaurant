using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
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

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            cMusteriler cMusteriler = new cMusteriler();
            cMusteriler.MusterileriGetir(lvMusteriler);

            cMasalar cMasalar = new cMasalar();
            cMasalar.MasaKapasitesiveDurumuGetir(cbMasa);

            dtTarih.MinDate = DateTime.Today;
            dtTarih.Format = DateTimePickerFormat.Time;
        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler cMusteriler = new cMusteriler();
            cMusteriler.MusteriGetirAd(lvMusteriler, txtMusteriAd.Text);
        }
        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            cMusteriler cMusteriler = new cMusteriler();
            cMusteriler.MusteriGetirSoyad(lvMusteriler, txtSoyad.Text);
        }
        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler cMusteriler = new cMusteriler();
            cMusteriler.MusteriGetirTelefon(lvMusteriler, txtTelefon.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            cMusteriler cMusteriler = new cMusteriler();
            cMusteriler.MusteriGetirAdres(lvMusteriler, txtAdres.Text);
        }
        void Temizle()
        {
            txtAdres.Clear();
            txtKisiSayisi.Clear();
            txtMasa.Clear();
            txtTarih.Clear();
            txtMusteriAd.Clear();
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            cRezervasyon cRezervasyon = new cRezervasyon();
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                bool sonuc = cRezervasyon.RezervasyonAcikmiKontrol(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                if (!sonuc)
                {
                    if (txtTarih.Text != "")
                    {
                        if (txtKisiSayisi.Text != "")
                        {
                            cMasalar cMasalar = new cMasalar();
                            if (cMasalar.TableGetByState(Convert.ToInt32(txtMasaNo.Text), 1))
                            {
                                cAdisyon cAdisyon = new cAdisyon();
                                cAdisyon.Tarih = Convert.ToDateTime(txtTarih.Text);
                                cAdisyon.ServisTurNo = 1;
                                cAdisyon.MasaId = Convert.ToInt32(txtMasaNo.Text);
                                cAdisyon.PersonelId = cGenel._personelId;

                                cRezervasyon.ClientId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                                cRezervasyon.TableId = Convert.ToInt32(txtMasaNo.Text);
                                cRezervasyon.Date = Convert.ToDateTime(txtTarih.Text);
                                cRezervasyon.ClientCount = Convert.ToInt32(txtKisiSayisi.Text);
                                cRezervasyon.Description = txtAciklama.Text;

                                cRezervasyon.AdditionId = cAdisyon.RezervasyonAdisyonAc(cAdisyon);
                                sonuc = cRezervasyon.RezervasyonAc(cRezervasyon);

                                cMasalar.SetChangeTableState(txtMasaNo.Text, 3);

                                if (sonuc)
                                {
                                    MessageBox.Show("Rezervasyon Açılmıştır.");
                                    Temizle();
                                }
                                else
                                    MessageBox.Show("Rezervasyon gerçekleşmedi");
                            }
                            else
                                MessageBox.Show("Rezervasyon Yapılan masa şuan dolu!");
                        }
                        else
                            MessageBox.Show("Kişi Sayısı Girin!");
                    }
                    else
                        MessageBox.Show("Tarih Girin!");
                }
                else
                    MessageBox.Show("Müşteriye ait bir rezervasyon bulunmaktadır.");
            }
            else
                MessageBox.Show("Müşteri Bulunamamıştır.");
        }

        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;
        }

        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 200;
        }

        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            dtTarih.Width = 20;
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtTarih.Value.ToString();
        }

        private void cbKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiSayisi.Text = cbKisiSayisi.SelectedItem.ToString();
        }

        private void cbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKisiSayisi.Enabled = true;
            txtMasa.Text = cbMasa.SelectedItem.ToString();
            cMasalar Kapasitesi = (cMasalar)cbMasa.SelectedItem;
            int kapasite = Kapasitesi.Kapasite;
            txtMasaNo.Text = Convert.ToString(Kapasitesi.Id);

            cbKisiSayisi.Items.Clear();
            for (int i = 0; i < kapasite; i++)
            {
                cbKisiSayisi.Items.Add(i + 1);
            }
        }

        private void cbMasa_MouseEnter(object sender, EventArgs e)
        {
            cbMasa.Width = 305;
        }

        private void cbMasa_MouseLeave(object sender, EventArgs e)
        {
            cbMasa.Width = 20;
        }

        private void cbKisiSayisi_MouseEnter(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 100;
        }

        private void cbKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 20;
        }

        private void btnSiparisKontrol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSiparisKontrol frm = new frmSiparisKontrol();
            frm.ShowDialog();
            this.Close();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriEkleme frm = new MusteriEkleme();
            cGenel._musteriEkle = 0;
            frm.btnMusteriGuncelle.Visible = false;
            frm.btnEkle.Visible = true;
            frm.ShowDialog();
            this.Close();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                MusteriEkleme me = new MusteriEkleme();
                cGenel._musteriEkle = 0;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                me.btnMusteriGuncelle.Visible = true;
                me.btnEkle.Visible = false;
                me.ShowDialog();
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
}
