namespace Ultia.UI
{
    partial class Rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.lstRapor = new System.Windows.Forms.ListView();
            this.kayitNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urununGuncelFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtrRapor = new System.Windows.Forms.DateTimePicker();
            this.rbtnRaporla = new Ultia.UI.Butonlar.GirisYapButonYeni();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRapor
            // 
            this.lstRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kayitNumarasi,
            this.Barkod,
            this.urunTipi,
            this.urununGuncelFiyati,
            this.markasi,
            this.modeli});
            this.lstRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstRapor.GridLines = true;
            this.lstRapor.HideSelection = false;
            this.lstRapor.Location = new System.Drawing.Point(248, 211);
            this.lstRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRapor.Name = "lstRapor";
            this.lstRapor.Size = new System.Drawing.Size(825, 307);
            this.lstRapor.TabIndex = 2;
            this.lstRapor.UseCompatibleStateImageBehavior = false;
            this.lstRapor.View = System.Windows.Forms.View.Details;
            this.lstRapor.Visible = false;
            // 
            // kayitNumarasi
            // 
            this.kayitNumarasi.Text = "Kayıt Numarası";
            this.kayitNumarasi.Width = 118;
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkod";
            this.Barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Barkod.Width = 77;
            // 
            // urunTipi
            // 
            this.urunTipi.Text = "Ürün Tipi";
            this.urunTipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunTipi.Width = 78;
            // 
            // urununGuncelFiyati
            // 
            this.urununGuncelFiyati.Text = "Ürünün Güncel Fiyatı";
            this.urununGuncelFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urununGuncelFiyati.Width = 160;
            // 
            // markasi
            // 
            this.markasi.Text = "Markası";
            this.markasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.markasi.Width = 71;
            // 
            // modeli
            // 
            this.modeli.Text = "Modeli";
            this.modeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modeli.Width = 125;
            // 
            // dtrRapor
            // 
            this.dtrRapor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtrRapor.Location = new System.Drawing.Point(499, 119);
            this.dtrRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtrRapor.Name = "dtrRapor";
            this.dtrRapor.Size = new System.Drawing.Size(257, 22);
            this.dtrRapor.TabIndex = 14;
            // 
            // rbtnRaporla
            // 
            this.rbtnRaporla.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnRaporla.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnRaporla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnRaporla.BorderRadius = 8;
            this.rbtnRaporla.BorderSize = 0;
            this.rbtnRaporla.FlatAppearance.BorderSize = 0;
            this.rbtnRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRaporla.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.rbtnRaporla.ForeColor = System.Drawing.Color.White;
            this.rbtnRaporla.Location = new System.Drawing.Point(541, 165);
            this.rbtnRaporla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnRaporla.Name = "rbtnRaporla";
            this.rbtnRaporla.Size = new System.Drawing.Size(176, 42);
            this.rbtnRaporla.TabIndex = 18;
            this.rbtnRaporla.Text = "Raporla";
            this.rbtnRaporla.TextColor = System.Drawing.Color.White;
            this.rbtnRaporla.UseVisualStyleBackColor = false;
            this.rbtnRaporla.Click += new System.EventHandler(this.rbtnRaporla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 529);
            this.Controls.Add(this.rbtnRaporla);
            this.Controls.Add(this.dtrRapor);
            this.Controls.Add(this.lstRapor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstRapor;
        private System.Windows.Forms.ColumnHeader kayitNumarasi;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader urunTipi;
        private System.Windows.Forms.ColumnHeader urununGuncelFiyati;
        private System.Windows.Forms.ColumnHeader markasi;
        private System.Windows.Forms.ColumnHeader modeli;
        private System.Windows.Forms.DateTimePicker dtrRapor;
        private Butonlar.GirisYapButonYeni rbtnRaporla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}