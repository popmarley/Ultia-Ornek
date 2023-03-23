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
    public class ReportDAL : ISelect<AssetDTO>
    {


        public ListView list;
        public DateTimePicker dtp;

        public ReportDAL(ListView list, DateTimePicker dtp)
        {
            this.list = list;
            this.dtp = dtp;
        }
        MSSQLProvider provider = null;
        public void Select(AssetDTO state)
        {

            provider = new MSSQLProvider("\r\nselect a.ID ,a.IsBarcode as [Barkod] ,at.Description, a.Cost,bm.Description as [Brand],bm.Model as [Model],a.EntryDate,a.RetireDate,a.CreatedBy from  Asset a  join  BrandModel bm on a.BrandModelID=bm.ID join AssetType at on at.ID=a.AssetTypeID where a.EntryDate<@Date");
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@Date", dtp.Value));
            provider.AddParameter(sqlParameters.ToArray());
            SqlDataReader rdr = provider.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["ID"].ToString());
                    item.SubItems.Add(rdr["Barkod"].ToString());
                    item.SubItems.Add(rdr["Description"].ToString());
                    item.SubItems.Add(rdr["Cost"].ToString());
                    item.SubItems.Add(rdr["Brand"].ToString());
                    item.SubItems.Add(rdr["Model"].ToString());
                    item.SubItems.Add(rdr["EntryDate"].ToString());
                    item.SubItems.Add(rdr["RetireDate"].ToString());
                    item.SubItems.Add(rdr["CreatedBy"].ToString());


                    list.Items.Add(item);

                }
            }
        }
    }
}
