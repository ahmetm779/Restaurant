using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasaSiparis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMasalar frm = new frmMasalar();
            frm.ShowDialog();
            this.Close();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRezervasyon frm = new frmRezervasyon();
            frm.ShowDialog();
            this.Close();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSiparis frm = new frmSiparis();
            frm.ShowDialog();
            this.Close();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusteriAra frm = new frmMusteriAra();
            frm.ShowDialog();
            this.Close();
        }

        private void btnKasaIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKasaIslemleri frm = new frmKasaIslemleri();
            frm.ShowDialog();
            this.Close();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMutfak frm = new frmMutfak();
            frm.ShowDialog();
            this.Close();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRaporlar frm = new frmRaporlar();
            frm.ShowDialog();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
            this.Close();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKitle frm = new frmKitle();
            frm.ShowDialog();
            this.Close();
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
