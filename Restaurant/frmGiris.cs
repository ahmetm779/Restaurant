using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        cGenel cGenel = new cGenel();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            cPersonel personel = new cPersonel();
            bool result = personel.personelEntryControl(txtSifre.Text, cGenel._personelId);

            if (result)
            {
                cPersonelHareketleri cPersonelHareketleri = new cPersonelHareketleri();
                cPersonelHareketleri.PersonelId = cGenel._personelId;
                cPersonelHareketleri.Islem = "Giriş Yaptı";
                cPersonelHareketleri.Tarih = DateTime.Now;
                cPersonelHareketleri.PersonelActionSave(cPersonelHareketleri);

                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış!", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersonel p = new cPersonel();
            p.PersonelGetByInformation(cbKullaniciAdi);
        }

        private void cbKullaniciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonel p = (cPersonel)cbKullaniciAdi.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.Gorevıd;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
