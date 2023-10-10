
namespace Restaurant
{
    partial class frmMusteriAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriAra));
            txtAd = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtSoyad = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtAdres = new System.Windows.Forms.TextBox();
            txtTelefon = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtAdisyonId = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            lvMusteriler = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            btnYeniMusteri = new System.Windows.Forms.Button();
            btnMusteriSec = new System.Windows.Forms.Button();
            btnMusteriGuncelle = new System.Windows.Forms.Button();
            btnAdisyonBul = new System.Windows.Forms.Button();
            btnSiparisler = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtAd.Location = new System.Drawing.Point(21, 136);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(209, 49);
            txtAd.TabIndex = 0;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(21, 90);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 31);
            label1.TabIndex = 1;
            label1.Text = "Adı";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtSoyad.Location = new System.Drawing.Point(236, 136);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(209, 49);
            txtSoyad.TabIndex = 0;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(236, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 31);
            label2.TabIndex = 1;
            label2.Text = "Soyadı";
            // 
            // txtAdres
            // 
            txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtAdres.Location = new System.Drawing.Point(881, 136);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new System.Drawing.Size(246, 126);
            txtAdres.TabIndex = 0;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtTelefon.Location = new System.Drawing.Point(451, 136);
            txtTelefon.Multiline = true;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new System.Drawing.Size(209, 49);
            txtTelefon.TabIndex = 0;
            txtTelefon.TextChanged += txtTelefon_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(881, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 31);
            label3.TabIndex = 1;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(451, 90);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 31);
            label4.TabIndex = 1;
            label4.Text = "Telefon";
            // 
            // txtAdisyonId
            // 
            txtAdisyonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtAdisyonId.Location = new System.Drawing.Point(666, 136);
            txtAdisyonId.Multiline = true;
            txtAdisyonId.Name = "txtAdisyonId";
            txtAdisyonId.Size = new System.Drawing.Size(209, 49);
            txtAdisyonId.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(666, 90);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(146, 31);
            label5.TabIndex = 1;
            label5.Text = "Adisyon ID";
            // 
            // lvMusteriler
            // 
            lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lvMusteriler.FullRowSelect = true;
            lvMusteriler.GridLines = true;
            lvMusteriler.Location = new System.Drawing.Point(21, 206);
            lvMusteriler.Name = "lvMusteriler";
            lvMusteriler.Size = new System.Drawing.Size(854, 389);
            lvMusteriler.TabIndex = 2;
            lvMusteriler.UseCompatibleStateImageBehavior = false;
            lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müsteri No";
            columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adres";
            columnHeader5.Width = 275;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "E-Mail";
            columnHeader6.Width = 120;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackgroundImage = Properties.Resources.yenimusteri;
            btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnYeniMusteri.Location = new System.Drawing.Point(21, 601);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new System.Drawing.Size(200, 87);
            btnYeniMusteri.TabIndex = 3;
            btnYeniMusteri.UseVisualStyleBackColor = true;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnMusteriSec
            // 
            btnMusteriSec.BackgroundImage = Properties.Resources.musterisec;
            btnMusteriSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMusteriSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMusteriSec.Location = new System.Drawing.Point(227, 601);
            btnMusteriSec.Name = "btnMusteriSec";
            btnMusteriSec.Size = new System.Drawing.Size(200, 87);
            btnMusteriSec.TabIndex = 3;
            btnMusteriSec.UseVisualStyleBackColor = true;
            btnMusteriSec.Click += btnMusteriSec_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackgroundImage = Properties.Resources.musteriguncelle;
            btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMusteriGuncelle.Location = new System.Drawing.Point(433, 601);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new System.Drawing.Size(200, 87);
            btnMusteriGuncelle.TabIndex = 3;
            btnMusteriGuncelle.UseVisualStyleBackColor = true;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnAdisyonBul
            // 
            btnAdisyonBul.BackgroundImage = Properties.Resources.adisyonbul;
            btnAdisyonBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAdisyonBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAdisyonBul.Location = new System.Drawing.Point(881, 268);
            btnAdisyonBul.Name = "btnAdisyonBul";
            btnAdisyonBul.Size = new System.Drawing.Size(200, 87);
            btnAdisyonBul.TabIndex = 3;
            btnAdisyonBul.UseVisualStyleBackColor = true;
            btnAdisyonBul.Click += btnAdisyonBul_Click;
            // 
            // btnSiparisler
            // 
            btnSiparisler.BackgroundImage = Properties.Resources.siparisler;
            btnSiparisler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSiparisler.Location = new System.Drawing.Point(639, 601);
            btnSiparisler.Name = "btnSiparisler";
            btnSiparisler.Size = new System.Drawing.Size(200, 87);
            btnSiparisler.TabIndex = 3;
            btnSiparisler.UseVisualStyleBackColor = true;
            btnSiparisler.Click += btnSiparisler_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.geridon;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Location = new System.Drawing.Point(881, 361);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(70, 74);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(74, 697);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(47, 53);
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
            btnGeriDon.Location = new System.Drawing.Point(21, 697);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(47, 53);
            btnGeriDon.TabIndex = 17;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // frmMusteriAra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1139, 762);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(button1);
            Controls.Add(btnSiparisler);
            Controls.Add(btnAdisyonBul);
            Controls.Add(btnMusteriGuncelle);
            Controls.Add(btnMusteriSec);
            Controls.Add(btnYeniMusteri);
            Controls.Add(lvMusteriler);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtAdisyonId);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmMusteriAra";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMusteriler";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmMusteriAra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdisyonId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnAdisyonBul;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}