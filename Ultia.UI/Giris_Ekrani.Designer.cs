namespace Ultia.UI
{
    partial class Giris_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Ekrani));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnGirisYap = new Ultia.UI.Butonlar.GirisYapButonYeni();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(433, 137);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.MaxLength = 16;
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(151, 26);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Gray;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSifre.Location = new System.Drawing.Point(433, 223);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(151, 23);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnGirisYap
            // 
            this.rbtnGirisYap.BackColor = System.Drawing.Color.Gray;
            this.rbtnGirisYap.BackgroundColor = System.Drawing.Color.Gray;
            this.rbtnGirisYap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnGirisYap.BorderRadius = 8;
            this.rbtnGirisYap.BorderSize = 0;
            this.rbtnGirisYap.FlatAppearance.BorderSize = 0;
            this.rbtnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnGirisYap.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.rbtnGirisYap.ForeColor = System.Drawing.Color.White;
            this.rbtnGirisYap.Location = new System.Drawing.Point(418, 287);
            this.rbtnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnGirisYap.Name = "rbtnGirisYap";
            this.rbtnGirisYap.Size = new System.Drawing.Size(178, 28);
            this.rbtnGirisYap.TabIndex = 7;
            this.rbtnGirisYap.Text = "Giris Yap";
            this.rbtnGirisYap.TextColor = System.Drawing.Color.White;
            this.rbtnGirisYap.UseVisualStyleBackColor = false;
            this.rbtnGirisYap.Click += new System.EventHandler(this.girisYapButonYeni1_Click);
            // 
            // Giris_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 432);
            this.Controls.Add(this.rbtnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Giris_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private Butonlar.GirisYapButonYeni rbtnGirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}