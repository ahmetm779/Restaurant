
namespace Restaurant
{
    partial class frmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            cbKullaniciAdi = new System.Windows.Forms.ComboBox();
            txtSifre = new System.Windows.Forms.TextBox();
            btnGiris = new System.Windows.Forms.Button();
            btnCikis = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbKullaniciAdi
            // 
            cbKullaniciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbKullaniciAdi.FormattingEnabled = true;
            cbKullaniciAdi.Location = new System.Drawing.Point(510, 254);
            cbKullaniciAdi.Name = "cbKullaniciAdi";
            cbKullaniciAdi.Size = new System.Drawing.Size(246, 28);
            cbKullaniciAdi.TabIndex = 0;
            cbKullaniciAdi.SelectedIndexChanged += cbKullaniciAdi_SelectedIndexChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(510, 288);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new System.Drawing.Size(246, 26);
            txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGiris.BackgroundImage");
            btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGiris.Location = new System.Drawing.Point(510, 330);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(151, 66);
            btnGiris.TabIndex = 2;
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCikis.Location = new System.Drawing.Point(667, 330);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(89, 66);
            btnCikis.TabIndex = 2;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(398, 257);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(398, 291);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // frmGiris
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(781, 446);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(cbKullaniciAdi);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmGiris";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Yetkili Girişi";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

