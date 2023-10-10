
namespace Restaurant
{
    partial class frmMutfak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMutfak));
            lvKategoriler = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            lvGidaListesi = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            btnDegistir = new System.Windows.Forms.Button();
            btnSil = new System.Windows.Forms.Button();
            btnEkle = new System.Windows.Forms.Button();
            btnBul = new System.Windows.Forms.Button();
            panelUrun = new System.Windows.Forms.Panel();
            txtUrunId = new System.Windows.Forms.TextBox();
            txtGidaFiyati = new System.Windows.Forms.TextBox();
            txtGidaAdi = new System.Windows.Forms.TextBox();
            cbKategoriler = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panelAnaKategori = new System.Windows.Forms.Panel();
            txtKategoriId = new System.Windows.Forms.TextBox();
            txtAciklama = new System.Windows.Forms.TextBox();
            txtKategoriAd = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            rbAltKategori = new System.Windows.Forms.RadioButton();
            rbAnaKategori = new System.Windows.Forms.RadioButton();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtAra = new System.Windows.Forms.TextBox();
            panelUrun.SuspendLayout();
            panelAnaKategori.SuspendLayout();
            SuspendLayout();
            // 
            // lvKategoriler
            // 
            lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lvKategoriler.FullRowSelect = true;
            lvKategoriler.GridLines = true;
            lvKategoriler.Location = new System.Drawing.Point(326, 421);
            lvKategoriler.Name = "lvKategoriler";
            lvKategoriler.Size = new System.Drawing.Size(555, 254);
            lvKategoriler.TabIndex = 0;
            lvKategoriler.UseCompatibleStateImageBehavior = false;
            lvKategoriler.View = System.Windows.Forms.View.Details;
            lvKategoriler.SelectedIndexChanged += lvKategoriler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TurId";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Açıklama";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 350;
            // 
            // lvGidaListesi
            // 
            lvGidaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvGidaListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lvGidaListesi.FullRowSelect = true;
            lvGidaListesi.GridLines = true;
            lvGidaListesi.Location = new System.Drawing.Point(326, 421);
            lvGidaListesi.Name = "lvGidaListesi";
            lvGidaListesi.Size = new System.Drawing.Size(555, 254);
            lvGidaListesi.TabIndex = 1;
            lvGidaListesi.UseCompatibleStateImageBehavior = false;
            lvGidaListesi.View = System.Windows.Forms.View.Details;
            lvGidaListesi.SelectedIndexChanged += lvGidaListesi_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Urun Id";
            columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "UrunTurNo";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Kategori";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Urun Adı";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fiyatı";
            columnHeader8.Width = 100;
            // 
            // btnDegistir
            // 
            btnDegistir.BackgroundImage = Properties.Resources.degistir;
            btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDegistir.Location = new System.Drawing.Point(401, 315);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new System.Drawing.Size(161, 100);
            btnDegistir.TabIndex = 11;
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources.sil;
            btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSil.Location = new System.Drawing.Point(745, 315);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(171, 100);
            btnSil.TabIndex = 10;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = Properties.Resources.ekle;
            btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEkle.Location = new System.Drawing.Point(234, 315);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(161, 100);
            btnEkle.TabIndex = 9;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnBul
            // 
            btnBul.BackgroundImage = Properties.Resources.bul;
            btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBul.Location = new System.Drawing.Point(568, 315);
            btnBul.Name = "btnBul";
            btnBul.Size = new System.Drawing.Size(171, 100);
            btnBul.TabIndex = 8;
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // panelUrun
            // 
            panelUrun.BackColor = System.Drawing.Color.Transparent;
            panelUrun.Controls.Add(txtUrunId);
            panelUrun.Controls.Add(txtGidaFiyati);
            panelUrun.Controls.Add(txtGidaAdi);
            panelUrun.Controls.Add(cbKategoriler);
            panelUrun.Controls.Add(label3);
            panelUrun.Controls.Add(label2);
            panelUrun.Controls.Add(label1);
            panelUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panelUrun.Location = new System.Drawing.Point(206, 91);
            panelUrun.Name = "panelUrun";
            panelUrun.Size = new System.Drawing.Size(379, 157);
            panelUrun.TabIndex = 12;
            panelUrun.Visible = false;
            // 
            // txtUrunId
            // 
            txtUrunId.Location = new System.Drawing.Point(349, 62);
            txtUrunId.Name = "txtUrunId";
            txtUrunId.Size = new System.Drawing.Size(16, 29);
            txtUrunId.TabIndex = 3;
            // 
            // txtGidaFiyati
            // 
            txtGidaFiyati.Location = new System.Drawing.Point(167, 102);
            txtGidaFiyati.Name = "txtGidaFiyati";
            txtGidaFiyati.Size = new System.Drawing.Size(176, 29);
            txtGidaFiyati.TabIndex = 2;
            // 
            // txtGidaAdi
            // 
            txtGidaAdi.Location = new System.Drawing.Point(167, 62);
            txtGidaAdi.Name = "txtGidaAdi";
            txtGidaAdi.Size = new System.Drawing.Size(176, 29);
            txtGidaAdi.TabIndex = 2;
            // 
            // cbKategoriler
            // 
            cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new System.Drawing.Point(167, 21);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new System.Drawing.Size(176, 32);
            cbKategoriler.TabIndex = 1;
            cbKategoriler.SelectedIndexChanged += cbKategoriler_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(54, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 24);
            label3.TabIndex = 0;
            label3.Text = "Gıda Fiyatı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(69, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 24);
            label2.TabIndex = 0;
            label2.Text = "Gıda Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(15, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 24);
            label1.TabIndex = 0;
            label1.Text = "Gıda Kategorisi :";
            // 
            // panelAnaKategori
            // 
            panelAnaKategori.BackColor = System.Drawing.Color.Transparent;
            panelAnaKategori.Controls.Add(txtKategoriId);
            panelAnaKategori.Controls.Add(txtAciklama);
            panelAnaKategori.Controls.Add(txtKategoriAd);
            panelAnaKategori.Controls.Add(label4);
            panelAnaKategori.Controls.Add(label5);
            panelAnaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panelAnaKategori.Location = new System.Drawing.Point(627, 91);
            panelAnaKategori.Name = "panelAnaKategori";
            panelAnaKategori.Size = new System.Drawing.Size(379, 157);
            panelAnaKategori.TabIndex = 13;
            panelAnaKategori.Visible = false;
            // 
            // txtKategoriId
            // 
            txtKategoriId.Location = new System.Drawing.Point(349, 62);
            txtKategoriId.Name = "txtKategoriId";
            txtKategoriId.Size = new System.Drawing.Size(16, 29);
            txtKategoriId.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new System.Drawing.Point(167, 102);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new System.Drawing.Size(176, 29);
            txtAciklama.TabIndex = 2;
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new System.Drawing.Point(167, 62);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new System.Drawing.Size(176, 29);
            txtKategoriAd.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(54, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 24);
            label4.TabIndex = 0;
            label4.Text = "Açıklama :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(28, 65);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(122, 24);
            label5.TabIndex = 0;
            label5.Text = "Kategori Adı :";
            // 
            // rbAltKategori
            // 
            rbAltKategori.AutoSize = true;
            rbAltKategori.Location = new System.Drawing.Point(373, 52);
            rbAltKategori.Name = "rbAltKategori";
            rbAltKategori.Size = new System.Drawing.Size(75, 19);
            rbAltKategori.TabIndex = 14;
            rbAltKategori.TabStop = true;
            rbAltKategori.Text = "Ürün Ekle";
            rbAltKategori.UseVisualStyleBackColor = true;
            rbAltKategori.CheckedChanged += rbAltKategori_CheckedChanged;
            // 
            // rbAnaKategori
            // 
            rbAnaKategori.AutoSize = true;
            rbAnaKategori.Location = new System.Drawing.Point(488, 52);
            rbAnaKategori.Name = "rbAnaKategori";
            rbAnaKategori.Size = new System.Drawing.Size(122, 19);
            rbAnaKategori.TabIndex = 14;
            rbAnaKategori.TabStop = true;
            rbAnaKategori.Text = "Ürün Kategori Ekle";
            rbAnaKategori.UseVisualStyleBackColor = true;
            rbAnaKategori.CheckedChanged += rbAnaKategori_CheckedChanged;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(100, 607);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(82, 71);
            btnCikis.TabIndex = 16;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGeriDon.BackgroundImage");
            btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGeriDon.Location = new System.Drawing.Point(12, 607);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(82, 71);
            btnGeriDon.TabIndex = 17;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(305, 270);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(217, 24);
            label6.TabIndex = 18;
            label6.Text = "Aramak İstediğiniz Ürün :";
            // 
            // txtAra
            // 
            txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAra.Location = new System.Drawing.Point(528, 264);
            txtAra.Multiline = true;
            txtAra.Name = "txtAra";
            txtAra.Size = new System.Drawing.Size(176, 42);
            txtAra.TabIndex = 4;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // frmMutfak
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1133, 709);
            Controls.Add(lvKategoriler);
            Controls.Add(lvGidaListesi);
            Controls.Add(txtAra);
            Controls.Add(label6);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(rbAnaKategori);
            Controls.Add(rbAltKategori);
            Controls.Add(panelAnaKategori);
            Controls.Add(panelUrun);
            Controls.Add(btnDegistir);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnBul);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmMutfak";
            Text = "frmMutfak";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmMutfak_Load;
            panelUrun.ResumeLayout(false);
            panelUrun.PerformLayout();
            panelAnaKategori.ResumeLayout(false);
            panelAnaKategori.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvGidaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtGidaFiyati;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAnaKategori;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbAltKategori;
        private System.Windows.Forms.RadioButton rbAnaKategori;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAra;
    }
}