
namespace Restaurant
{
    partial class frmSiparisKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisKontrol));
            lvMusteriDetaylari = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            lvSatisDetaylari = new System.Windows.Forms.ListView();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            txtToplamTutar = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblToplamSiparis = new System.Windows.Forms.Label();
            lblGenelToplam = new System.Windows.Forms.Label();
            lblSonSiparisTarihi = new System.Windows.Forms.Label();
            lvMusteriler = new System.Windows.Forms.ListView();
            columnHeader10 = new System.Windows.Forms.ColumnHeader();
            columnHeader11 = new System.Windows.Forms.ColumnHeader();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lvMusteriDetaylari
            // 
            lvMusteriDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvMusteriDetaylari.FullRowSelect = true;
            lvMusteriDetaylari.Location = new System.Drawing.Point(456, 23);
            lvMusteriDetaylari.Name = "lvMusteriDetaylari";
            lvMusteriDetaylari.Size = new System.Drawing.Size(446, 314);
            lvMusteriDetaylari.TabIndex = 0;
            lvMusteriDetaylari.UseCompatibleStateImageBehavior = false;
            lvMusteriDetaylari.View = System.Windows.Forms.View.Details;
            lvMusteriDetaylari.SelectedIndexChanged += lvMusteriDetaylari_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müşteri Id";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Müşteri Ad";
            columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Müşteri Soyad";
            columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tarih";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adisyon Id";
            columnHeader5.Width = 0;
            // 
            // lvSatisDetaylari
            // 
            lvSatisDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvSatisDetaylari.FullRowSelect = true;
            lvSatisDetaylari.Location = new System.Drawing.Point(908, 23);
            lvSatisDetaylari.Name = "lvSatisDetaylari";
            lvSatisDetaylari.Size = new System.Drawing.Size(252, 227);
            lvSatisDetaylari.TabIndex = 1;
            lvSatisDetaylari.UseCompatibleStateImageBehavior = false;
            lvSatisDetaylari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Satış Id";
            columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ürün Adı";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Adet";
            columnHeader8.Width = 40;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fiyat";
            columnHeader9.Width = 100;
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtToplamTutar.Location = new System.Drawing.Point(695, 343);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.ReadOnly = true;
            txtToplamTutar.Size = new System.Drawing.Size(207, 29);
            txtToplamTutar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(539, 343);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 24);
            label1.TabIndex = 3;
            label1.Text = "Toplam Adet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(695, 393);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 24);
            label2.TabIndex = 3;
            label2.Text = "Toplam :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(695, 436);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 24);
            label3.TabIndex = 3;
            label3.Text = "Genel Tutar :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(695, 484);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(160, 24);
            label4.TabIndex = 3;
            label4.Text = "En Son Sipariş :";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.BackColor = System.Drawing.Color.Transparent;
            lblToplamSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = System.Drawing.Color.White;
            lblToplamSiparis.Location = new System.Drawing.Point(859, 393);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new System.Drawing.Size(87, 24);
            lblToplamSiparis.TabIndex = 3;
            lblToplamSiparis.Text = "_______";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.BackColor = System.Drawing.Color.Transparent;
            lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGenelToplam.ForeColor = System.Drawing.Color.Red;
            lblGenelToplam.Location = new System.Drawing.Point(859, 436);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new System.Drawing.Size(87, 24);
            lblGenelToplam.TabIndex = 3;
            lblGenelToplam.Text = "_______";
            // 
            // lblSonSiparisTarihi
            // 
            lblSonSiparisTarihi.AutoSize = true;
            lblSonSiparisTarihi.BackColor = System.Drawing.Color.Transparent;
            lblSonSiparisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSonSiparisTarihi.ForeColor = System.Drawing.Color.White;
            lblSonSiparisTarihi.Location = new System.Drawing.Point(859, 484);
            lblSonSiparisTarihi.Name = "lblSonSiparisTarihi";
            lblSonSiparisTarihi.Size = new System.Drawing.Size(87, 24);
            lblSonSiparisTarihi.TabIndex = 3;
            lblSonSiparisTarihi.Text = "_______";
            // 
            // lvMusteriler
            // 
            lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12 });
            lvMusteriler.FullRowSelect = true;
            lvMusteriler.GridLines = true;
            lvMusteriler.Location = new System.Drawing.Point(1231, 3);
            lvMusteriler.Name = "lvMusteriler";
            lvMusteriler.Size = new System.Drawing.Size(125, 88);
            lvMusteriler.TabIndex = 4;
            lvMusteriler.UseCompatibleStateImageBehavior = false;
            lvMusteriler.View = System.Windows.Forms.View.Details;
            lvMusteriler.Visible = false;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "MüşteriId";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Müşteri";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "AdisyonId";
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(65, 532);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(47, 53);
            btnCikis.TabIndex = 18;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGeriDon.BackgroundImage");
            btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGeriDon.Location = new System.Drawing.Point(12, 532);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(47, 53);
            btnGeriDon.TabIndex = 19;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // frmSiparisKontrol
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1358, 597);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(lvMusteriler);
            Controls.Add(lblSonSiparisTarihi);
            Controls.Add(label4);
            Controls.Add(lblGenelToplam);
            Controls.Add(label3);
            Controls.Add(lblToplamSiparis);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtToplamTutar);
            Controls.Add(lvSatisDetaylari);
            Controls.Add(lvMusteriDetaylari);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmSiparisKontrol";
            Text = "frmSiparisKontrol";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmSiparisKontrol_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvSatisDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblSonSiparisTarihi;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}