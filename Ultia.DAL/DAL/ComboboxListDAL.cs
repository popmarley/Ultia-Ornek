using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultia.DTO.DTO;
using Ultia.MyProvider.Repositories;
using Ultia.MyProvider;
using System.Windows.Forms;

namespace Ultia.DAL.DAL
{
    public class ComboboxListDAL : ISelect<BrandModelDTO>
    {
        MSSQLProvider sqlProvider = null;
        public void Select(BrandModelDTO state)
        {
            sqlProvider = new MSSQLProvider("select Model from BrandModel where Description=@ModelName");
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@ModelName", state.Description));
            sqlProvider.AddParameter(sqlParameters.ToArray());

        }
        public void SetCombo(ComboBox comboBox)
        {
            SqlDataReader rdr = null;
            rdr = sqlProvider.ExecuteReader();
            if (rdr != null)
            {
                while (rdr.Read())
                {

                    comboBox.Items.Add(rdr.GetSqlString(0));
                }
            }
        }

    }
}
