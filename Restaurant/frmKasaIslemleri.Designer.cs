
namespace Restaurant
{
    partial class frmKasaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaIslemleri));
            btnAylikRapor = new System.Windows.Forms.Button();
            btnZRaporu = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            btnCikis = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.BackgroundImage = Properties.Resources.aylikrapor;
            btnAylikRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAylikRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAylikRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAylikRapor.Location = new System.Drawing.Point(98, 227);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new System.Drawing.Size(236, 124);
            btnAylikRapor.TabIndex = 3;
            btnAylikRapor.UseVisualStyleBackColor = true;
            // 
            // btnZRaporu
            // 
            btnZRaporu.BackgroundImage = Properties.Resources.zraporu;
            btnZRaporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnZRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            btnZRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZRaporu.Location = new System.Drawing.Point(98, 357);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new System.Drawing.Size(150, 120);
            btnZRaporu.TabIndex = 4;
            btnZRaporu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(241, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 25);
            label1.TabIndex = 5;
            label1.Text = "AYLIK RAPOR";
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new System.Drawing.Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new System.Drawing.Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCikis.Location = new System.Drawing.Point(132, 637);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new System.Drawing.Size(82, 71);
            btnCikis.TabIndex = 6;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGeriDon.BackgroundImage");
            btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGeriDon.Location = new System.Drawing.Point(44, 637);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(82, 71);
            btnGeriDon.TabIndex = 7;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // frmKasaIslemleri
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1257, 720);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDon);
            Controls.Add(label1);
            Controls.Add(btnZRaporu);
            Controls.Add(btnAylikRapor);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "frmKasaIslemleri";
            Text = "frmKasaIslemleri";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmKasaIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}