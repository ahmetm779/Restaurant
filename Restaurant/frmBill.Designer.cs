
namespace Restaurant
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            lvUrunler = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            chkIndirim = new System.Windows.Forms.CheckBox();
            gbIndirim = new System.Windows.Forms.GroupBox();
            txtIndirimTutari = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label14 = new System.Windows.Forms.Label();
            lblAraToplam = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            lblFiyat = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            lblKdv = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lblIndirim = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            rbTicket = new System.Windows.Forms.RadioButton();
            rbKrediKart = new System.Windows.Forms.RadioButton();
            rbNakit = new System.Windows.Forms.RadioButton();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            btnHesapOzeti = new System.Windows.Forms.Button();
            btnHesapKapat = new System.Windows.Forms.Button();
            lblAdisyonId = new System.Windows.Forms.Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            groupBox1.SuspendLayout();
            gbIndirim.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lvUrunler
            // 
            lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader5, columnHeader7, columnHeader6, columnHeader8, columnHeader9 });
            lvUrunler.FullRowSelect = true;
            lvUrunler.GridLines = true;
            lvUrunler.Location = new System.Drawing.Point(25, 83);
            lvUrunler.Name = "lvUrunler";
            lvUrunler.Size = new System.Drawing.Size(515, 192);
            lvUrunler.TabIndex = 0;
            lvUrunler.UseCompatibleStateImageBehavior = false;
            lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün Adı";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adet";
            columnHeader5.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ürün Id";
            columnHeader7.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fiyat";
            columnHeader6.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Satış Id";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Silinen Id";
            columnHeader9.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(25, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 24);
            label1.TabIndex = 1;
            label1.Text = "Siparişler";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(chkIndirim);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(570, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(226, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            chkIndirim.AutoSize = true;
            chkIndirim.Location = new System.Drawing.Point(18, 58);
            chkIndirim.Name = "chkIndirim";
            chkIndirim.Size = new System.Drawing.Size(199, 33);
            chkIndirim.TabIndex = 0;
            chkIndirim.Text = "İndirim Uygula";
            chkIndirim.UseVisualStyleBackColor = true;
            chkIndirim.CheckedChanged += chkIndirim_CheckedChanged;
            // 
            // gbIndirim
            // 
            gbIndirim.BackColor = System.Drawing.Color.Transparent;
            gbIndirim.Controls.Add(txtIndirimTutari);
            gbIndirim.Controls.Add(label2);
            gbIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbIndirim.ForeColor = System.Drawing.Color.White;
            gbIndirim.Location = new System.Drawing.Point(813, 83);
            gbIndirim.Name = "gbIndirim";
            gbIndirim.Size = new System.Drawing.Size(268, 125);
            gbIndirim.TabIndex = 2;
            gbIndirim.TabStop = false;
            gbIndirim.Text = "Özel Aktivite";
            gbIndirim.Visible = false;
            // 
            // txtIndirimTutari
            // 
            txtIndirimTutari.Location = new System.Drawing.Point(9, 69);
            txtIndirimTutari.Name = "txtIndirimTutari";
            txtIndirimTutari.Size = new System.Drawing.Size(247, 35);
            txtIndirimTutari.TabIndex = 1;
            txtIndirimTutari.TextChanged += txtIndirimTutari_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(250, 29);
            label2.TabIndex = 0;
            label2.Text = "İndirim Tutarı Giriniz";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblAraToplam);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(lblFiyat);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(lblKdv);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lblIndirim);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.White;
            groupBox3.Location = new System.Drawing.Point(148, 297);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(369, 220);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Bilgileri";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(279, 159);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(44, 29);
            label14.TabIndex = 0;
            label14.Text = "TL";
            // 
            // lblAraToplam
            // 
            lblAraToplam.AutoSize = true;
            lblAraToplam.Location = new System.Drawing.Point(167, 159);
            lblAraToplam.Name = "lblAraToplam";
            lblAraToplam.Size = new System.Drawing.Size(27, 29);
            lblAraToplam.TabIndex = 0;
            lblAraToplam.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(0, 159);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(148, 29);
            label6.TabIndex = 0;
            label6.Text = "Ara Toplam";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(279, 119);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(44, 29);
            label13.TabIndex = 0;
            label13.Text = "TL";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new System.Drawing.Point(167, 119);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new System.Drawing.Size(27, 29);
            lblFiyat.TabIndex = 0;
            lblFiyat.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(0, 119);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 29);
            label5.TabIndex = 0;
            label5.Text = "Fiyat";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(282, 75);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(44, 29);
            label12.TabIndex = 0;
            label12.Text = "TL";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new System.Drawing.Point(170, 75);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new System.Drawing.Size(27, 29);
            lblKdv.TabIndex = 0;
            lblKdv.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 29);
            label4.TabIndex = 0;
            label4.Text = "KDV";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(282, 31);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(44, 29);
            label11.TabIndex = 0;
            label11.Text = "TL";
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Location = new System.Drawing.Point(170, 31);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new System.Drawing.Size(27, 29);
            lblIndirim.TabIndex = 0;
            lblIndirim.Text = "0";
            lblIndirim.TextChanged += lblIndirim_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 29);
            label3.TabIndex = 0;
            label3.Text = "İndirim";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.Color.Transparent;
            groupBox4.Controls.Add(rbTicket);
            groupBox4.Controls.Add(rbKrediKart);
            groupBox4.Controls.Add(rbNakit);
            groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.White;
            groupBox4.Location = new System.Drawing.Point(570, 297);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(208, 220);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            rbTicket.AutoSize = true;
            rbTicket.Location = new System.Drawing.Point(27, 155);
            rbTicket.Name = "rbTicket";
            rbTicket.Size = new System.Drawing.Size(103, 33);
            rbTicket.TabIndex = 0;
            rbTicket.TabStop = true;
            rbTicket.Text = "Ticket";
            rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKart
            // 
            rbKrediKart.AutoSize = true;
            rbKrediKart.Location = new System.Drawing.Point(27, 96);
            rbKrediKart.Name = "rbKrediKart";
            rbKrediKart.Size = new System.Drawing.Size(155, 33);
            rbKrediKart.TabIndex = 0;
            rbKrediKart.TabStop = true;
            rbKrediKart.Text = "Kredi Kartı";
            rbKrediKart.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.Location = new System.Drawing.Point(27, 41);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new System.Drawing.Size(91, 33);
            rbNakit.TabIndex = 0;
            rbNakit.TabStop = true;
            rbNakit.Text = "Nakit";
            rbNakit.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(65, 524);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(47, 53);
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
            btnGeriDon.Location = new System.Drawing.Point(12, 524);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(47, 53);
            btnGeriDon.TabIndex = 15;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // btnHesapOzeti
            // 
            btnHesapOzeti.BackgroundImage = Properties.Resources.hesapozeti;
            btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnHesapOzeti.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHesapOzeti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnHesapOzeti.Location = new System.Drawing.Point(819, 302);
            btnHesapOzeti.Name = "btnHesapOzeti";
            btnHesapOzeti.Size = new System.Drawing.Size(190, 98);
            btnHesapOzeti.TabIndex = 16;
            btnHesapOzeti.UseVisualStyleBackColor = true;
            btnHesapOzeti.Click += btnHesapOzeti_Click;
            // 
            // btnHesapKapat
            // 
            btnHesapKapat.BackgroundImage = Properties.Resources.hesapkapat;
            btnHesapKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnHesapKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnHesapKapat.Location = new System.Drawing.Point(819, 416);
            btnHesapKapat.Name = "btnHesapKapat";
            btnHesapKapat.Size = new System.Drawing.Size(190, 98);
            btnHesapKapat.TabIndex = 16;
            btnHesapKapat.UseVisualStyleBackColor = true;
            btnHesapKapat.Click += btnHesapKapat_Click;
            // 
            // lblAdisyonId
            // 
            lblAdisyonId.AutoSize = true;
            lblAdisyonId.BackColor = System.Drawing.Color.Transparent;
            lblAdisyonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAdisyonId.ForeColor = System.Drawing.Color.DarkRed;
            lblAdisyonId.Location = new System.Drawing.Point(128, 45);
            lblAdisyonId.Name = "lblAdisyonId";
            lblAdisyonId.Size = new System.Drawing.Size(27, 24);
            lblAdisyonId.TabIndex = 1;
            lblAdisyonId.Text = "Id";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1154, 589);
            Controls.Add(btnHesapKapat);
            Controls.Add(btnHesapOzeti);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(groupBox4);
            Controls.Add(gbIndirim);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(lblAdisyonId);
            Controls.Add(label1);
            Controls.Add(lvUrunler);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmBill";
            Text = "HESAP ÖDEME";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmBill_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbIndirim.ResumeLayout(false);
            gbIndirim.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbKrediKart;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}