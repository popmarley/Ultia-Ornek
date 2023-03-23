namespace Ultia.UI
{
    partial class Listeleme_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listeleme_Ekrani));
            this.listView1 = new System.Windows.Forms.ListView();
            this.kayitNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urununGuncelFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnYeniKayit = new Ultia.UI.RJControls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kayitNumarasi,
            this.Barkod,
            this.urunTipi,
            this.urununGuncelFiyati,
            this.markasi,
            this.modeli});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(251, 195);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(836, 349);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnYeniKayit
            // 
            this.rbtnYeniKayit.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnYeniKayit.ButtonColor = System.Drawing.Color.Black;
            this.rbtnYeniKayit.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYeniKayit.Location = new System.Drawing.Point(27, 510);
            this.rbtnYeniKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnYeniKayit.Name = "rbtnYeniKayit";
            this.rbtnYeniKayit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnYeniKayit.OnHoverButtonColor = System.Drawing.Color.Peru;
            this.rbtnYeniKayit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnYeniKayit.Size = new System.Drawing.Size(109, 34);
            this.rbtnYeniKayit.TabIndex = 2;
            this.rbtnYeniKayit.Text = "Yeni Kayıt";
            this.rbtnYeniKayit.TextColor = System.Drawing.Color.White;
            this.rbtnYeniKayit.UseVisualStyleBackColor = true;
            this.rbtnYeniKayit.Click += new System.EventHandler(this.rbtnYeniKayit_Click);
            // 
            // Listeleme_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 565);
            this.Controls.Add(this.rbtnYeniKayit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Listeleme_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listeleme Ekranı";
            this.Load += new System.EventHandler(this.Listemele_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader kayitNumarasi;
        private System.Windows.Forms.ColumnHeader urunTipi;
        private System.Windows.Forms.ColumnHeader urununGuncelFiyati;
        private System.Windows.Forms.ColumnHeader markasi;
        private System.Windows.Forms.ColumnHeader modeli;
        private RJControls.RoundButton rbtnYeniKayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Barkod;
    }
}