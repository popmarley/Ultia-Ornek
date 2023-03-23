using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;
using Ultia.MyProvider;
using Ultia.DTO.DTO;
using Ultia.DAL.DAL;

namespace Ultia.UI
{
    public partial class Giris_Ekrani : Form
    {
        LoginDTO login = new LoginDTO();
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void girisYapButonYeni1_Click(object sender, EventArgs e)
        {
            login.UserName = txtKullaniciAdi.Text;
            login.Password = txtSifre.Text;
            LoginDAL loginDal = new LoginDAL();
            loginDal.Select(login);
            SqlDataReader dr = loginDal.provider.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                Listeleme_Ekrani ekran = new Listeleme_Ekrani();
                ekran.Show();
                this.Hide();
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                FormuTemizle();
            }


        }
        private void FormuTemizle()
        {
            txtKullaniciAdi.Text = txtSifre.Text = string.Empty;
        }


    }
}
