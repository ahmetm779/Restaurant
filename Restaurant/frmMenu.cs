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
            frmMasalar frm = new frmMasalar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnKasaIslemleri_Click(object sender, EventArgs e)
        {
            frmKasaIslemleri frm = new frmKasaIslemleri();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            frmKitle frm = new frmKitle();
            this.Hide();
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
