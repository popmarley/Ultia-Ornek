using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultia.DAL.DAL;
using Ultia.DTO.DTO;

namespace Ultia.UI
{
    public partial class Rapor : Form
    {
        AssetDTO dto = null;
        public Rapor()
        {
            InitializeComponent();
            
        }


        private void rbtnRaporla_Click(object sender, EventArgs e)
        {
            ReportDAL dal = new ReportDAL(lstRapor, dtrRapor);
            
            dal.Select(dto);
            lstRapor.Visible = true;
        }
    }
}
