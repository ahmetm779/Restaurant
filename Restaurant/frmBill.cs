using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        cSiparis cs = new cSiparis();
        int odemeTuru = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            gbIndirim.Visible = false;
            if (cGenel._ServisTurNo == 1)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.GetByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblAraToplam.Text = string.Format("{0:0.000}", toplam);
                    lblFiyat.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblAraToplam.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else if (cGenel._ServisTurNo == 2)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                cPaketler cPaketler = new cPaketler();
                odemeTuru = cPaketler.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.GetByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));

                if (odemeTuru == 1)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTuru == 2)
                {
                    rbKrediKart.Checked = true;
                }
                else if (odemeTuru == 3)
                {
                    rbTicket.Checked = true;
                }

                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblAraToplam.Text = string.Format("{0:0.000}", toplam);
                    lblFiyat.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblAraToplam.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIndirimTutari.Text != "")
                {
                    if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lblFiyat.Text))
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", txtIndirimTutari.Text);
                    }
                    else
                    {
                        MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz !!!");
                    }
                }
                else
                {
                    lblIndirim.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) >= 0)
            {
                decimal odenecek = 0;
                lblAraToplam.Text = lblFiyat.Text;
                odenecek = Convert.ToDecimal(lblFiyat.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblAraToplam.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblAraToplam.Text) * 18 / 100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);
        }

        cMasalar masalar = new cMasalar();
        cRezervasyon rezervasyon = new cRezervasyon();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            cOdeme odeme = new cOdeme();
            if (cGenel._ServisTurNo == 1)
            {
                int masaId = masalar.TableGetByNumber(cGenel._ButtonName);
                int musteriId = 0;
                if (masalar.TableGetByState(masaId, 4) == true)
                {
                    musteriId = rezervasyon.GetByClientfromRezervasyon(masaId);
                }
                else
                {
                    musteriId = 1;
                }

                int odemeTurId = 0;
                if (rbNakit.Checked)
                {
                    odemeTurId = 1;
                }
                else if (rbKrediKart.Checked)
                {
                    odemeTurId = 2;
                }
                else if (rbTicket.Checked)
                {
                    odemeTurId = 3;
                }

                odeme.AdisyonId = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblAraToplam.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblFiyat.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.BillClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap Kapatılmıştır.");
                    masalar.SetChangeTableState(Convert.ToString(masaId), 1);

                    cRezervasyon c = new cRezervasyon();
                    c.RezervasyonKapat(Convert.ToInt32(lblAdisyonId.Text));

                    cAdisyon a = new cAdisyon();
                    a.AdisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 0);

                    this.Close();
                    frmMasalar frm = new frmMasalar();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken Hata Oluştu!");
                }
            }
            else if (cGenel._ServisTurNo == 2)
            {
                odeme.AdisyonId = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTuru;
                odeme.MusteriId = 1;//Paket sipariş ID
                odeme.AraToplam = Convert.ToDecimal(lblAraToplam.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblFiyat.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);
                bool result = odeme.BillClose(odeme);
                if (result)
                {
                    

                    cRezervasyon c = new cRezervasyon();
                    c.RezervasyonKapat(Convert.ToInt32(lblAdisyonId.Text));

                    cAdisyon a = new cAdisyon();
                    a.AdisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 1);

                    cPaketler p = new cPaketler();
                    p.OrderServiceClose(Convert.ToInt32(lblAdisyonId.Text));
                    MessageBox.Show("Hesap Kapatılmıştır.");
                    this.Close();
                    frmMenu frm = new frmMenu();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken Hata Oluştu!");
                }
            }
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("ŞAH RESTAURANT", baslik, sb, 350, 100, st);

            e.Graphics.DrawString("------------------", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı                Adet            Fiyat", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("-----------------------------------------------------", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("-----------------------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı   :-----------" + lblIndirim.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Tutarı       :-----------" + lblKdv.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar     :-----------" + lblFiyat.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödediğiniz Tutar :-----------" + lblAraToplam.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 4), st);
        }
    }
}
