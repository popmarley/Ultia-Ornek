using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.MyProvider
{
    public class MSSQLProvider
    {
        SqlCommand cmd = null;
        public SqlConnection conn = null;

        public MSSQLProvider(string cmdText, string appConnectionString = "server=OZGUVEN;Database=AssetDB;Integrated Security = True")
        {
            conn = new SqlConnection(appConnectionString);
            cmd = new SqlCommand(cmdText, conn);
        }

        public MSSQLProvider(string cmdText, CommandType type, SqlTransaction tran, string appConnectionString = "server=OZGUVEN;Database=AssetDB;Integrated Security = True")
        {
            conn = new SqlConnection(appConnectionString);
            cmd = new SqlCommand(cmdText, conn, tran);
            cmd.CommandType = type;

        }

        public MSSQLProvider(string[] cmdText, List<SqlParameter[]> myParameters, SqlTransaction tran, string appConnectionString = "server=OZGUVEN;Database=AssetDB;Integrated Security = True")
        {
            conn = new SqlConnection(appConnectionString);
            try
            {
                conn.Open();
                tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(cmdText[0], conn, tran);
                AddParameterwithCMD(cmd, myParameters[0]);
                int query = cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cmdText[1], conn, tran);
                AddParameterwithCMD(cmd, myParameters[1]);
                int query1 = cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                // handle exception
            }
            finally
            {
                CloseConnection();
            }
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlDataReader ExecuteReader()
        {
            SqlDataReader rdr = null;
            try
            {
                OpenConnection();
                rdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {


            }
            finally
            {
                //CloseConnection();
            }
            return rdr;

        }

        public int ExecuteNonQuery()
        {
            int result = 0;

            try
            {
                OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                result = 0;
            }
            finally
            {
                //  CloseConnection();
            }
            return result;
        }

        public object ExecuteScalar()
        {
            object result = null;

            try
            {
                OpenConnection();
                result = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {


            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        public void AddParameterwithCMD(SqlCommand cmd, SqlParameter[] sqlParameters)
        {

            cmd.Parameters.AddRange(sqlParameters);

        }
        public void AddParameter(SqlParameter[] sqlParameters)
        {

            cmd.Parameters.AddRange(sqlParameters);

        }



    }
}

