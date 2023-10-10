
namespace Restaurant
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dtBaslangic = new System.Windows.Forms.DateTimePicker();
            dtBitis = new System.Windows.Forms.DateTimePicker();
            grbMenuBaslik = new System.Windows.Forms.GroupBox();
            btnAraSicaklar = new System.Windows.Forms.Button();
            btnCorbalar = new System.Windows.Forms.Button();
            btnSalatalar = new System.Windows.Forms.Button();
            btnMakarnalar = new System.Windows.Forms.Button();
            btnIcecekler = new System.Windows.Forms.Button();
            btnFastFood = new System.Windows.Forms.Button();
            btnTatlilar = new System.Windows.Forms.Button();
            btnAnaYemekler = new System.Windows.Forms.Button();
            gbIstatistik = new System.Windows.Forms.GroupBox();
            lvIstatistik = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            btnZRaporu = new System.Windows.Forms.Button();
            grbMenuBaslik.SuspendLayout();
            gbIstatistik.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(332, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 37);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(394, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 37);
            label2.TabIndex = 1;
            label2.Text = "Bitiş Tarihi :";
            // 
            // dtBaslangic
            // 
            dtBaslangic.CalendarForeColor = System.Drawing.Color.White;
            dtBaslangic.CalendarMonthBackground = System.Drawing.Color.Transparent;
            dtBaslangic.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            dtBaslangic.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            dtBaslangic.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            dtBaslangic.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtBaslangic.Location = new System.Drawing.Point(549, 55);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.Size = new System.Drawing.Size(422, 43);
            dtBaslangic.TabIndex = 2;
            // 
            // dtBitis
            // 
            dtBitis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtBitis.Location = new System.Drawing.Point(549, 114);
            dtBitis.Name = "dtBitis";
            dtBitis.Size = new System.Drawing.Size(422, 43);
            dtBitis.TabIndex = 3;
            // 
            // grbMenuBaslik
            // 
            grbMenuBaslik.BackColor = System.Drawing.Color.Transparent;
            grbMenuBaslik.Controls.Add(btnAraSicaklar);
            grbMenuBaslik.Controls.Add(btnCorbalar);
            grbMenuBaslik.Controls.Add(btnSalatalar);
            grbMenuBaslik.Controls.Add(btnMakarnalar);
            grbMenuBaslik.Controls.Add(btnIcecekler);
            grbMenuBaslik.Controls.Add(btnFastFood);
            grbMenuBaslik.Controls.Add(btnTatlilar);
            grbMenuBaslik.Controls.Add(btnAnaYemekler);
            grbMenuBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grbMenuBaslik.ForeColor = System.Drawing.Color.White;
            grbMenuBaslik.Location = new System.Drawing.Point(29, 114);
            grbMenuBaslik.Name = "grbMenuBaslik";
            grbMenuBaslik.Size = new System.Drawing.Size(297, 393);
            grbMenuBaslik.TabIndex = 4;
            grbMenuBaslik.TabStop = false;
            grbMenuBaslik.Text = "Menü";
            // 
            // btnAraSicaklar
            // 
            btnAraSicaklar.BackgroundImage = Properties.Resources.arasicaklar;
            btnAraSicaklar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAraSicaklar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAraSicaklar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAraSicaklar.Location = new System.Drawing.Point(152, 298);
            btnAraSicaklar.Name = "btnAraSicaklar";
            btnAraSicaklar.Size = new System.Drawing.Size(140, 86);
            btnAraSicaklar.TabIndex = 0;
            btnAraSicaklar.UseVisualStyleBackColor = true;
            btnAraSicaklar.Click += btnAraSicaklar_Click;
            // 
            // btnCorbalar
            // 
            btnCorbalar.BackgroundImage = Properties.Resources.corbalar;
            btnCorbalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCorbalar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCorbalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCorbalar.Location = new System.Drawing.Point(152, 206);
            btnCorbalar.Name = "btnCorbalar";
            btnCorbalar.Size = new System.Drawing.Size(140, 86);
            btnCorbalar.TabIndex = 0;
            btnCorbalar.UseVisualStyleBackColor = true;
            btnCorbalar.Click += btnCorbalar_Click;
            // 
            // btnSalatalar
            // 
            btnSalatalar.BackgroundImage = Properties.Resources.salatalar;
            btnSalatalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSalatalar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalatalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSalatalar.Location = new System.Drawing.Point(152, 114);
            btnSalatalar.Name = "btnSalatalar";
            btnSalatalar.Size = new System.Drawing.Size(140, 86);
            btnSalatalar.TabIndex = 0;
            btnSalatalar.UseVisualStyleBackColor = true;
            btnSalatalar.Click += btnSalatalar_Click;
            // 
            // btnMakarnalar
            // 
            btnMakarnalar.BackgroundImage = Properties.Resources.makarnalar;
            btnMakarnalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMakarnalar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMakarnalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMakarnalar.Location = new System.Drawing.Point(6, 298);
            btnMakarnalar.Name = "btnMakarnalar";
            btnMakarnalar.Size = new System.Drawing.Size(140, 86);
            btnMakarnalar.TabIndex = 0;
            btnMakarnalar.UseVisualStyleBackColor = true;
            btnMakarnalar.Click += btnMakarnalar_Click;
            // 
            // btnIcecekler
            // 
            btnIcecekler.BackgroundImage = Properties.Resources.icecekler;
            btnIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIcecekler.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIcecekler.Location = new System.Drawing.Point(152, 22);
            btnIcecekler.Name = "btnIcecekler";
            btnIcecekler.Size = new System.Drawing.Size(140, 86);
            btnIcecekler.TabIndex = 0;
            btnIcecekler.UseVisualStyleBackColor = true;
            btnIcecekler.Click += btnIcecekler_Click;
            // 
            // btnFastFood
            // 
            btnFastFood.BackgroundImage = Properties.Resources.fastfood;
            btnFastFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnFastFood.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFastFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFastFood.Location = new System.Drawing.Point(6, 206);
            btnFastFood.Name = "btnFastFood";
            btnFastFood.Size = new System.Drawing.Size(140, 86);
            btnFastFood.TabIndex = 0;
            btnFastFood.UseVisualStyleBackColor = true;
            btnFastFood.Click += btnFastFood_Click;
            // 
            // btnTatlilar
            // 
            btnTatlilar.BackgroundImage = Properties.Resources.tatlilar;
            btnTatlilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnTatlilar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTatlilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnTatlilar.Location = new System.Drawing.Point(6, 114);
            btnTatlilar.Name = "btnTatlilar";
            btnTatlilar.Size = new System.Drawing.Size(140, 86);
            btnTatlilar.TabIndex = 0;
            btnTatlilar.UseVisualStyleBackColor = true;
            btnTatlilar.Click += btnTatlilar_Click;
            // 
            // btnAnaYemekler
            // 
            btnAnaYemekler.BackgroundImage = Properties.Resources.anayemek;
            btnAnaYemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAnaYemekler.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAnaYemekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAnaYemekler.Location = new System.Drawing.Point(6, 22);
            btnAnaYemekler.Name = "btnAnaYemekler";
            btnAnaYemekler.Size = new System.Drawing.Size(140, 86);
            btnAnaYemekler.TabIndex = 0;
            btnAnaYemekler.UseVisualStyleBackColor = true;
            btnAnaYemekler.Click += btnAnaYemekler_Click;
            // 
            // gbIstatistik
            // 
            gbIstatistik.BackColor = System.Drawing.Color.Transparent;
            gbIstatistik.Controls.Add(lvIstatistik);
            gbIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbIstatistik.ForeColor = System.Drawing.Color.White;
            gbIstatistik.Location = new System.Drawing.Point(375, 173);
            gbIstatistik.Name = "gbIstatistik";
            gbIstatistik.Size = new System.Drawing.Size(575, 393);
            gbIstatistik.TabIndex = 5;
            gbIstatistik.TabStop = false;
            // 
            // lvIstatistik
            // 
            lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            lvIstatistik.Location = new System.Drawing.Point(461, 42);
            lvIstatistik.Name = "lvIstatistik";
            lvIstatistik.Size = new System.Drawing.Size(44, 28);
            lvIstatistik.TabIndex = 0;
            lvIstatistik.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Urun Adı";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adedi";
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(117, 525);
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
            btnGeriDon.Location = new System.Drawing.Point(29, 525);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(82, 71);
            btnGeriDon.TabIndex = 15;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // btnZRaporu
            // 
            btnZRaporu.BackgroundImage = Properties.Resources.tumurunler;
            btnZRaporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnZRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            btnZRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnZRaporu.Location = new System.Drawing.Point(205, 525);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new System.Drawing.Size(140, 86);
            btnZRaporu.TabIndex = 1;
            btnZRaporu.UseVisualStyleBackColor = true;
            btnZRaporu.Click += btnZRaporu_Click;
            // 
            // frmRaporlar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1004, 686);
            Controls.Add(btnZRaporu);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(gbIstatistik);
            Controls.Add(grbMenuBaslik);
            Controls.Add(dtBitis);
            Controls.Add(dtBaslangic);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmRaporlar";
            Text = "Raporlar";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmRaporlar_Load;
            grbMenuBaslik.ResumeLayout(false);
            gbIstatistik.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.GroupBox grbMenuBaslik;
        private System.Windows.Forms.Button btnAraSicaklar;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button btnMakarnalar;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.GroupBox gbIstatistik;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}