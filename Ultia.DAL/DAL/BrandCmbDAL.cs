using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultia.DTO.DTO;
using Ultia.MyProvider;
using Ultia.MyProvider.Repositories;


namespace Ultia.DAL.DAL
{
    public class BrandCmbDAL : ISelect<BrandModelDTO>
    {
        private ComboBox cmbUrunTipi;
        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private ComboBox cmbUrunParaBirimi;
        private ComboBox cmbUrununGuncelFiyatParaBirimi;
        List<string[]> column = new List<string[]>();


        public BrandCmbDAL(ComboBox cmbUrunTipi, ComboBox cmbMarka, ComboBox cmbModel, ComboBox cmbUrunParaBirimi, ComboBox cmbUrununGuncelFiyatParaBirimi)
        {
            this.cmbUrunTipi = cmbUrunTipi;
            this.cmbMarka = cmbMarka;
            this.cmbModel = cmbModel;
            this.cmbUrunParaBirimi = cmbUrunParaBirimi;
            this.cmbUrununGuncelFiyatParaBirimi = cmbUrununGuncelFiyatParaBirimi;

        }

        public BrandCmbDAL()
        {
        }
        

        public void Select(BrandModelDTO bModel)
        {
            MSSQLProvider myDatabase = new MSSQLProvider("select * from BrandModel");
            MSSQLProvider myDatabase2 = new MSSQLProvider("select  ID,Description from AssetType ");
            MSSQLProvider myDatabase3 = new MSSQLProvider("select  Description from Currency ");



            SqlDataReader dr;
            SqlDataReader dr2;
            SqlDataReader dr3;

           // ComboBox[] boxes = { cmbMarka, cmbModel, cmbUrunTipi, cmbUrunParaBirimi, cmbUrununGuncelFiyatParaBirimi };
            ComboBox[] box1 = { cmbMarka };

            //ComboBox[] box1 = { cmbMarka, cmbModel };
            ComboBox[] box2 = { cmbUrunTipi };
            ComboBox[] box3 = { cmbUrunParaBirimi, cmbUrununGuncelFiyatParaBirimi };
            //string[] columns1 = { "Description", "Model" };
            string[] columns1 = { "Description" };
            // string[] columns2 = { "Description" };
            string[] columns2 = { "ID", "Description" };
            string[] columns3 = { "Description", "Description" };
            column.Add(columns2);
            dr = myDatabase.ExecuteReader();
            dr2 = myDatabase2.ExecuteReader();
            dr3 = myDatabase3.ExecuteReader();
            FillComboBoxes(dr, box1, columns1);
            FillComboBoxes(dr2, box2, columns2);
            FillComboBoxes(dr3, box3, columns3);



        }

        public void ReadeableData(SqlDataReader sqlDataReader, ComboBox cmbUrunTipi, ComboBox cmbMarka)
        {
            while (sqlDataReader.Read())
            {
                cmbUrunTipi.Items.Add(sqlDataReader["Model"]);
                cmbMarka.Items.Add(sqlDataReader["Description"]);


            }
        }
        public void FillComboBoxes(SqlDataReader sqlDataReader, ComboBox[] boxes, string[] columns)
        {
            List<string[]> strings = new List<string[]>();
            strings.Add(columns);


            while (sqlDataReader.Read())
            {

                if (column[0] == strings[0])
                {
                    int id = Convert.ToInt32(sqlDataReader[columns[0]]);
                    ComboboxIDDTO.AssetTypeID.Add(id);
                    boxes[0].Items.Add(sqlDataReader[columns[1]]);

                }

                if (boxes.Length == columns.Length)
                {

                    for (int i = 0; i < boxes.Length; i++)
                    {
                        boxes[i].Items.Add(sqlDataReader[columns[i]]);
                    }
                }

            }
        }

    }
}

