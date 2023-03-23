using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultia.DAL.DAL;
using Ultia.DTO.DTO;

namespace Ultia.UI
{
    public partial class Listeleme_Ekrani : Form
    {
        SelectDTO select = null;
        public Listeleme_Ekrani()
        {
            InitializeComponent();
        }



        private void rbtnYeniKayit_Click(object sender, EventArgs e)
        {

            Yeni_Kayit_Ekleme yeniKayit = new Yeni_Kayit_Ekleme();
            yeniKayit.Show();
            this.Hide();
        }

        private void Listemele_Ekrani_Load(object sender, EventArgs e)
        {
            ListDAL list = new ListDAL(listView1);
            list.Select(select);
        }

       
    }
}
