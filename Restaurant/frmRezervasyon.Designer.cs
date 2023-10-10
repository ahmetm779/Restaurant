
namespace Restaurant
{
    partial class frmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtTarih = new System.Windows.Forms.TextBox();
            txtMasa = new System.Windows.Forms.TextBox();
            txtKisiSayisi = new System.Windows.Forms.TextBox();
            txtAciklama = new System.Windows.Forms.TextBox();
            cbKisiSayisi = new System.Windows.Forms.ComboBox();
            cbMasa = new System.Windows.Forms.ComboBox();
            txtMusteriAd = new System.Windows.Forms.TextBox();
            txtTelefon = new System.Windows.Forms.TextBox();
            txtAdres = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lvMusteriler = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            btnYeniMusteri = new System.Windows.Forms.Button();
            btnMusteriSec = new System.Windows.Forms.Button();
            btnSiparisKontrol = new System.Windows.Forms.Button();
            btnMusteriGuncelle = new System.Windows.Forms.Button();
            btnKapat = new System.Windows.Forms.Button();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            dtTarih = new System.Windows.Forms.DateTimePicker();
            txtMasaNo = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtSoyad = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(145, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 24);
            label1.TabIndex = 0;
            label1.Text = "Tarih :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(100, 159);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 24);
            label2.TabIndex = 0;
            label2.Text = "Masa Seç : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(106, 194);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 24);
            label3.TabIndex = 0;
            label3.Text = "Kişi Sayısı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(112, 229);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 24);
            label4.TabIndex = 0;
            label4.Text = "Açıklama :";
            // 
            // txtTarih
            // 
            txtTarih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtTarih.Location = new System.Drawing.Point(214, 121);
            txtTarih.Multiline = true;
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new System.Drawing.Size(126, 29);
            txtTarih.TabIndex = 1;
            // 
            // txtMasa
            // 
            txtMasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMasa.Location = new System.Drawing.Point(214, 156);
            txtMasa.Multiline = true;
            txtMasa.Name = "txtMasa";
            txtMasa.ReadOnly = true;
            txtMasa.Size = new System.Drawing.Size(126, 29);
            txtMasa.TabIndex = 1;
            // 
            // txtKisiSayisi
            // 
            txtKisiSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtKisiSayisi.Location = new System.Drawing.Point(214, 191);
            txtKisiSayisi.Multiline = true;
            txtKisiSayisi.Name = "txtKisiSayisi";
            txtKisiSayisi.ReadOnly = true;
            txtKisiSayisi.Size = new System.Drawing.Size(126, 29);
            txtKisiSayisi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new System.Drawing.Point(214, 226);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new System.Drawing.Size(172, 140);
            txtAciklama.TabIndex = 1;
            // 
            // cbKisiSayisi
            // 
            cbKisiSayisi.Enabled = false;
            cbKisiSayisi.FormattingEnabled = true;
            cbKisiSayisi.Location = new System.Drawing.Point(346, 190);
            cbKisiSayisi.Name = "cbKisiSayisi";
            cbKisiSayisi.Size = new System.Drawing.Size(40, 32);
            cbKisiSayisi.TabIndex = 2;
            cbKisiSayisi.SelectedIndexChanged += cbKisiSayisi_SelectedIndexChanged;
            cbKisiSayisi.MouseEnter += cbKisiSayisi_MouseEnter;
            cbKisiSayisi.MouseLeave += cbKisiSayisi_MouseLeave;
            // 
            // cbMasa
            // 
            cbMasa.FormattingEnabled = true;
            cbMasa.Location = new System.Drawing.Point(346, 156);
            cbMasa.Name = "cbMasa";
            cbMasa.Size = new System.Drawing.Size(40, 32);
            cbMasa.TabIndex = 3;
            cbMasa.SelectedIndexChanged += cbMasa_SelectedIndexChanged;
            cbMasa.MouseEnter += cbMasa_MouseEnter;
            cbMasa.MouseLeave += cbMasa_MouseLeave;
            // 
            // txtMusteriAd
            // 
            txtMusteriAd.Location = new System.Drawing.Point(451, 124);
            txtMusteriAd.Name = "txtMusteriAd";
            txtMusteriAd.Size = new System.Drawing.Size(163, 29);
            txtMusteriAd.TabIndex = 4;
            txtMusteriAd.TextChanged += txtMusteriAd_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new System.Drawing.Point(789, 124);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new System.Drawing.Size(126, 29);
            txtTelefon.TabIndex = 4;
            txtTelefon.TextChanged += txtTelefon_TextChanged;
            // 
            // txtAdres
            // 
            txtAdres.Location = new System.Drawing.Point(921, 123);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new System.Drawing.Size(203, 29);
            txtAdres.TabIndex = 4;
            txtAdres.TextChanged += txtAdres_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(451, 97);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 24);
            label5.TabIndex = 5;
            label5.Text = "MÜŞTERİ AD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(789, 97);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 24);
            label6.TabIndex = 5;
            label6.Text = "TELEFON";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(921, 96);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 24);
            label7.TabIndex = 5;
            label7.Text = "ADRES";
            // 
            // lvMusteriler
            // 
            lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvMusteriler.FullRowSelect = true;
            lvMusteriler.GridLines = true;
            lvMusteriler.Location = new System.Drawing.Point(451, 159);
            lvMusteriler.MultiSelect = false;
            lvMusteriler.Name = "lvMusteriler";
            lvMusteriler.Size = new System.Drawing.Size(673, 220);
            lvMusteriler.TabIndex = 6;
            lvMusteriler.UseCompatibleStateImageBehavior = false;
            lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MusteriNo";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adres";
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            columnHeader6.Width = 100;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackgroundImage = Properties.Resources.yenimusteri;
            btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnYeniMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnYeniMusteri.Location = new System.Drawing.Point(155, 537);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new System.Drawing.Size(140, 86);
            btnYeniMusteri.TabIndex = 7;
            btnYeniMusteri.UseVisualStyleBackColor = true;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnMusteriSec
            // 
            btnMusteriSec.BackgroundImage = Properties.Resources.rezervasyonac;
            btnMusteriSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMusteriSec.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMusteriSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMusteriSec.Location = new System.Drawing.Point(333, 537);
            btnMusteriSec.Name = "btnMusteriSec";
            btnMusteriSec.Size = new System.Drawing.Size(140, 86);
            btnMusteriSec.TabIndex = 7;
            btnMusteriSec.UseVisualStyleBackColor = true;
            btnMusteriSec.Click += btnMusteriSec_Click;
            // 
            // btnSiparisKontrol
            // 
            btnSiparisKontrol.BackgroundImage = Properties.Resources.rezervasyonlar;
            btnSiparisKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSiparisKontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSiparisKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSiparisKontrol.Location = new System.Drawing.Point(507, 537);
            btnSiparisKontrol.Name = "btnSiparisKontrol";
            btnSiparisKontrol.Size = new System.Drawing.Size(140, 86);
            btnSiparisKontrol.TabIndex = 7;
            btnSiparisKontrol.UseVisualStyleBackColor = true;
            btnSiparisKontrol.Click += btnSiparisKontrol_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackgroundImage = Properties.Resources.musteriguncelle;
            btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMusteriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMusteriGuncelle.Location = new System.Drawing.Point(669, 537);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new System.Drawing.Size(140, 86);
            btnMusteriGuncelle.TabIndex = 7;
            btnMusteriGuncelle.UseVisualStyleBackColor = true;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackgroundImage = Properties.Resources.geridonyazili;
            btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnKapat.Location = new System.Drawing.Point(829, 537);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new System.Drawing.Size(81, 86);
            btnKapat.TabIndex = 7;
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(100, 637);
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
            btnGeriDon.Location = new System.Drawing.Point(12, 637);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(82, 71);
            btnGeriDon.TabIndex = 15;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // dtTarih
            // 
            dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtTarih.Location = new System.Drawing.Point(346, 120);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new System.Drawing.Size(40, 29);
            dtTarih.TabIndex = 16;
            dtTarih.ValueChanged += dtTarih_ValueChanged;
            dtTarih.Enter += dtTarih_Enter;
            dtTarih.MouseEnter += dtTarih_MouseEnter;
            dtTarih.MouseLeave += dtTarih_MouseLeave;
            // 
            // txtMasaNo
            // 
            txtMasaNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMasaNo.Location = new System.Drawing.Point(392, 159);
            txtMasaNo.Multiline = true;
            txtMasaNo.Name = "txtMasaNo";
            txtMasaNo.ReadOnly = true;
            txtMasaNo.Size = new System.Drawing.Size(17, 29);
            txtMasaNo.TabIndex = 17;
            txtMasaNo.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(620, 97);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(163, 24);
            label8.TabIndex = 19;
            label8.Text = "MÜŞTERİ SOYAD";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(620, 124);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(163, 29);
            txtSoyad.TabIndex = 18;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // frmRezervasyon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1257, 720);
            Controls.Add(label8);
            Controls.Add(txtSoyad);
            Controls.Add(txtMasaNo);
            Controls.Add(dtTarih);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(btnKapat);
            Controls.Add(btnMusteriGuncelle);
            Controls.Add(btnSiparisKontrol);
            Controls.Add(btnMusteriSec);
            Controls.Add(btnYeniMusteri);
            Controls.Add(lvMusteriler);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtMusteriAd);
            Controls.Add(cbMasa);
            Controls.Add(cbKisiSayisi);
            Controls.Add(txtAciklama);
            Controls.Add(txtKisiSayisi);
            Controls.Add(txtMasa);
            Controls.Add(txtTarih);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "frmRezervasyon";
            Text = "frmRezervasyon";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmRezervasyon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbKisiSayisi;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnSiparisKontrol;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}