
namespace Restaurant
{
    partial class frmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            groupBox1 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            cbPersonel = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtPersonelId = new System.Windows.Forms.TextBox();
            txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            txtYeniSifre = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnBilgiDegistir = new System.Windows.Forms.Button();
            btnSil = new System.Windows.Forms.Button();
            btnEkle = new System.Windows.Forms.Button();
            btnYeni = new System.Windows.Forms.Button();
            txtGorevId2 = new System.Windows.Forms.TextBox();
            cbGorevi = new System.Windows.Forms.ComboBox();
            txtSifreTekrar = new System.Windows.Forms.TextBox();
            txtSifre = new System.Windows.Forms.TextBox();
            txtSoyad = new System.Windows.Forms.TextBox();
            txtPersonelD = new System.Windows.Forms.TextBox();
            txtAd = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblBilgi = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            button6 = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox9 = new System.Windows.Forms.TextBox();
            lvPersoneller = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cbPersonel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPersonelId);
            groupBox1.Controls.Add(txtYeniSifreTekrar);
            groupBox1.Controls.Add(txtYeniSifre);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.Black;
            groupBox1.Location = new System.Drawing.Point(108, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(484, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.degistir;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Location = new System.Drawing.Point(175, 175);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(223, 100);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbPersonel
            // 
            cbPersonel.FormattingEnabled = true;
            cbPersonel.Location = new System.Drawing.Point(254, 38);
            cbPersonel.Name = "cbPersonel";
            cbPersonel.Size = new System.Drawing.Size(166, 37);
            cbPersonel.TabIndex = 2;
            cbPersonel.SelectedIndexChanged += cbPersonel_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(53, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 29);
            label2.TabIndex = 1;
            label2.Text = "T Şifre Tekrar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(52, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 29);
            label1.TabIndex = 1;
            label1.Text = "Yeni Şifre";
            // 
            // txtPersonelId
            // 
            txtPersonelId.Location = new System.Drawing.Point(426, 40);
            txtPersonelId.Name = "txtPersonelId";
            txtPersonelId.Size = new System.Drawing.Size(16, 35);
            txtPersonelId.TabIndex = 0;
            txtPersonelId.Visible = false;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new System.Drawing.Point(254, 122);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new System.Drawing.Size(166, 35);
            txtYeniSifreTekrar.TabIndex = 0;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new System.Drawing.Point(254, 81);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new System.Drawing.Size(166, 35);
            txtYeniSifre.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(btnBilgiDegistir);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(btnYeni);
            groupBox2.Controls.Add(txtGorevId2);
            groupBox2.Controls.Add(cbGorevi);
            groupBox2.Controls.Add(txtSifreTekrar);
            groupBox2.Controls.Add(txtSifre);
            groupBox2.Controls.Add(txtSoyad);
            groupBox2.Controls.Add(txtPersonelD);
            groupBox2.Controls.Add(txtAd);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox2.ForeColor = System.Drawing.Color.Black;
            groupBox2.Location = new System.Drawing.Point(624, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(419, 477);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnBilgiDegistir
            // 
            btnBilgiDegistir.BackgroundImage = Properties.Resources.degistir;
            btnBilgiDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBilgiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBilgiDegistir.Location = new System.Drawing.Point(198, 353);
            btnBilgiDegistir.Name = "btnBilgiDegistir";
            btnBilgiDegistir.Size = new System.Drawing.Size(161, 100);
            btnBilgiDegistir.TabIndex = 7;
            btnBilgiDegistir.UseVisualStyleBackColor = true;
            btnBilgiDegistir.Click += btnBilgiDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources.sil;
            btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSil.Location = new System.Drawing.Point(21, 353);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(171, 100);
            btnSil.TabIndex = 6;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = Properties.Resources.kaydet;
            btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEkle.Location = new System.Drawing.Point(198, 247);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(161, 100);
            btnEkle.TabIndex = 5;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackgroundImage = Properties.Resources.yeni;
            btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnYeni.Location = new System.Drawing.Point(21, 247);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new System.Drawing.Size(171, 100);
            btnYeni.TabIndex = 4;
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // txtGorevId2
            // 
            txtGorevId2.Location = new System.Drawing.Point(365, 204);
            txtGorevId2.Name = "txtGorevId2";
            txtGorevId2.Size = new System.Drawing.Size(24, 35);
            txtGorevId2.TabIndex = 3;
            txtGorevId2.Visible = false;
            // 
            // cbGorevi
            // 
            cbGorevi.FormattingEnabled = true;
            cbGorevi.Location = new System.Drawing.Point(182, 204);
            cbGorevi.Name = "cbGorevi";
            cbGorevi.Size = new System.Drawing.Size(177, 37);
            cbGorevi.TabIndex = 2;
            cbGorevi.SelectedIndexChanged += cbGorevi_SelectedIndexChanged;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new System.Drawing.Point(182, 163);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new System.Drawing.Size(177, 35);
            txtSifreTekrar.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(182, 122);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(177, 35);
            txtSifre.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(182, 81);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(177, 35);
            txtSoyad.TabIndex = 1;
            // 
            // txtPersonelD
            // 
            txtPersonelD.Location = new System.Drawing.Point(365, 40);
            txtPersonelD.Name = "txtPersonelD";
            txtPersonelD.Size = new System.Drawing.Size(24, 35);
            txtPersonelD.TabIndex = 1;
            txtPersonelD.Visible = false;
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(182, 40);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(177, 35);
            txtAd.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(21, 207);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(84, 29);
            label8.TabIndex = 0;
            label8.Text = "Görevi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(21, 166);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(140, 29);
            label7.TabIndex = 0;
            label7.Text = "Şifre Tekrar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(21, 125);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 29);
            label6.TabIndex = 0;
            label6.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(21, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 29);
            label5.TabIndex = 0;
            label5.Text = "Soyadı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(21, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 29);
            label4.TabIndex = 0;
            label4.Text = "Adı";
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.BackColor = System.Drawing.Color.Transparent;
            lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBilgi.ForeColor = System.Drawing.Color.Red;
            lblBilgi.Location = new System.Drawing.Point(108, 113);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new System.Drawing.Size(129, 29);
            lblBilgi.TabIndex = 1;
            lblBilgi.Text = "giriş yapan";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox9);
            groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.Black;
            groupBox3.Location = new System.Drawing.Point(1068, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(484, 259);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.degistir;
            button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button6.Location = new System.Drawing.Point(174, 137);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(223, 100);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(52, 87);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(195, 29);
            label9.TabIndex = 1;
            label9.Text = "Yeni Şifre Tekrar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(51, 46);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(118, 29);
            label10.TabIndex = 1;
            label10.Text = "Yeni Şifre";
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(253, 84);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(166, 35);
            textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(253, 43);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(166, 35);
            textBox9.TabIndex = 0;
            // 
            // lvPersoneller
            // 
            lvPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvPersoneller.FullRowSelect = true;
            lvPersoneller.Location = new System.Drawing.Point(6, 21);
            lvPersoneller.Name = "lvPersoneller";
            lvPersoneller.Size = new System.Drawing.Size(457, 178);
            lvPersoneller.TabIndex = 3;
            lvPersoneller.UseCompatibleStateImageBehavior = false;
            lvPersoneller.View = System.Windows.Forms.View.Details;
            lvPersoneller.SelectedIndexChanged += lvPersoneller_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel Id";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Personel Görev Id";
            columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Görevi";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Adı";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Soyadı";
            columnHeader5.Width = 150;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(196, 756);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(82, 71);
            btnCikis.TabIndex = 14;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGeriDon.BackgroundImage");
            btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGeriDon.Location = new System.Drawing.Point(108, 756);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(82, 71);
            btnGeriDon.TabIndex = 15;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.Color.Transparent;
            groupBox4.Controls.Add(lvPersoneller);
            groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.Black;
            groupBox4.Location = new System.Drawing.Point(624, 637);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(471, 212);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            // 
            // frmAyarlar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1564, 851);
            Controls.Add(groupBox4);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(groupBox3);
            Controls.Add(lblBilgi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmAyarlar";
            Text = "frmAyarlar";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmAyarlar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPersonel;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Button btnBilgiDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtGorevId2;
        private System.Windows.Forms.ComboBox cbGorevi;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtPersonelD;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ListView lvPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}