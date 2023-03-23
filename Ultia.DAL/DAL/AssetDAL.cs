using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultia.DTO.DTO;
using Ultia.MyProvider;
using Ultia.MyProvider.Repositories;

namespace Ultia.DAL.DAL
{
    public class AssetDAL : IInsert<AssetInsertDTO>
    {
        SqlTransaction transaction = null;

        MSSQLProvider mSSQLProvider = new MSSQLProvider("select * from Asset");

        public void Insert(AssetInsertDTO state)
        {
            mSSQLProvider.OpenConnection();
            SqlTransaction tran = mSSQLProvider.conn.BeginTransaction();
            try
            {
                mSSQLProvider = new MSSQLProvider("sp_InsertAsset", CommandType.StoredProcedure, transaction);
                List<SqlParameter[]> sqlParameters = new List<SqlParameter[]>();
                List<SqlParameter> sqls = new List<SqlParameter>();
                sqls.Add(new SqlParameter("@barcode", state.Asset.hasBarcode));
                sqls.Add(new SqlParameter("@assetType", state.AssetType.Description));
                sqls.Add(new SqlParameter("@startDate", state.AssetOwner.StartDate));
                sqls.Add(new SqlParameter("@endDate", state.AssetOwner.EndDate));
                sqls.Add(new SqlParameter("@money", state.Asset.Cost));
                sqls.Add(new SqlParameter("@brand", state.Brand.Description));
                sqls.Add(new SqlParameter("@model", state.Brand.Model));
                sqls.Add(new SqlParameter("@cost", state.Currency.Description));
                sqls.Add(new SqlParameter("@guarantee", state.Asset.Guarantee));
                sqls.Add(new SqlParameter("@companyId", state.Asset.CompanyID));
                sqls.Add(new SqlParameter("@retireDate", state.AssetOwner.EndDate));

                sqlParameters.Add(sqls.ToArray());
                mSSQLProvider.AddParameter(sqlParameters[0]);
                int query = mSSQLProvider.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {

                tran.Rollback();
            }
            finally { mSSQLProvider.CloseConnection(); }

        }

    }
}
