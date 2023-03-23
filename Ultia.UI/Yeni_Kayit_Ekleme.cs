using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Ultia.DTO.DTO;
using Ultia.UI.RJControls;
using Ultia.DAL.DAL;
using Ultia.Extensions;


namespace Ultia.UI
{
    public partial class Yeni_Kayit_Ekleme : Form
    {
        BrandModelDTO brandModelDTO = null;
        BrandCmbDAL brandComboBoxDal = new BrandCmbDAL();
        public Yeni_Kayit_Ekleme()
        {
            InitializeComponent();
        }

        private void Yeni_Kayit_Ekleme_Load(object sender, EventArgs e)
        {
            brandModelDTO = new BrandModelDTO();
            BrandCmbDAL BrandCmbDAL = new BrandCmbDAL(cmbUrunTipi, cmbMarka, cmbModel, cmbUrunParaBirimi, cmbUrununGuncelFiyatParaBirimi);
            BrandCmbDAL.Select(brandModelDTO);
        }

        private void togglebtnBarkod_CheckedChanged(object sender, EventArgs e)
        {
            if (togglebtnBarkod.Checked == false)
            {
                txtBarkod.Enabled = true;
                txtMiktar.Enabled = false;
                txtBirim.Enabled = false;
            }
            else
            {
                txtBarkod.Enabled = false;
                txtMiktar.Enabled = true;
                txtBirim.Enabled = true;
            }
        }

        private void rbtnKaydet_Click(object sender, EventArgs e)
        {
            if (ComboboxValidation() && DTPValidation() && TxtCheck())
            {
                AssetDAL assetDAL = new AssetDAL();
                AssetInsertDTO insertDTO = null;

                assetDAL.Insert(insertDTO = new AssetInsertDTO
                {
                    Asset = new AssetDTO
                    {
                        hasBarcode = togglebtnBarkod.Checked,
                        Cost = Convert.ToDecimal(txtUrunGuncelFiyat.Text),
                        Guarantee = Convert.ToBoolean(cmbGaranti.SelectedIndex),
                        CompanyID = 2,
                        Description = cmbMarka.Text,

                    },
                    AssetType = new AssetTypeDTO
                    {
                        Description = cmbUrunTipi.Text,

                    },
                    AssetOwner = new AssetOwnerDTO
                    {
                        StartDate = dtUrunGirisTarihi.Value,
                        EndDate = dtUrunEmeklilikTarihi.Value
                    },
                    Brand = new BrandModelDTO
                    {
                        Description = cmbMarka.Text,
                        Model = cmbModel.Text,
                    },
                    Currency = new CurrencyDTO
                    {
                        Description = cmbUrunParaBirimi.Text,
                    }
                });
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Kayıt başarılı. Yeni kayıt almak ister misiniz.", "Kayıt", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Clear();
                }
                else if (res == DialogResult.No)
                {
                    rbtnKaydet.Enabled = false;
                    Rapor rapor = new Rapor();
                    rapor.Show();
                    this.Hide();


                }

            }
            else
            {
                MessageBox.Show("Lütfen verilerinizi kontrol edip tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #region Combobox
        public bool ComboboxValidation()
        {
            return cmbMarka.IsNotEmptyComboBox() && cmbUrunTipi.IsNotEmptyComboBox() && cmbModel.IsNotEmptyComboBox() && cmbGaranti.IsNotEmptyComboBox() && cmbMarka.IsNotEmptyComboBox() && cmbUrunParaBirimi.IsNotEmptyComboBox() && cmbUrununGuncelFiyatParaBirimi.IsNotEmptyComboBox();
        }

        #endregion
        #region DateTimePicker
        public bool DTPValidation()
        {
            return InputValidations.ValidateDateRange(dtUrunGirisTarihi.Value.Date, dtUrunEmeklilikTarihi.Value.Date);
        }
        #endregion
        #region TextBox Check
        public bool TxtCheck()
        {
            return txtUrunGuncelFiyat.Text.IsValidEmptyNumeric() && txtUrunMaliyet.Text.IsValidEmptyNumeric() && txtAciklama.Text.IsValidEmptyNumeric();
        }
        #endregion

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            brandModelDTO = new BrandModelDTO();
            brandModelDTO.Description = cmbMarka.SelectedItem.ToString();
            ComboboxListDAL comboboxListDAL = new ComboboxListDAL();
            cmbModel.Items.Clear();
            cmbModel.Text = string.Empty;
            comboboxListDAL.Select(brandModelDTO);
            comboboxListDAL.SetCombo(cmbModel);
           // MessageBox.Show(ComboboxIDDTO.AssetTypeID[cmbUrunTipi.SelectedIndex].ToString());

        }
        private void Clear()
        {
            cmbMarka.Text = cmbUrunParaBirimi.Text = cmbUrununGuncelFiyatParaBirimi.Text = cmbGaranti.Text = cmbModel.Text = cmbUrunTipi.Text = string.Empty;
            txtMiktar.Text = txtBarkod.Text = txtUrunGuncelFiyat.Text = cmbUrunParaBirimi.Text = txtUrunMaliyet.Text = txtAciklama.Text = string.Empty;
            dtUrunGirisTarihi.Value = DateTime.Now;
            dtUrunEmeklilikTarihi.Value = DateTime.Now;
        }

        private void txtUrunMaliyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbUrununGuncelFiyatParaBirimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

}






