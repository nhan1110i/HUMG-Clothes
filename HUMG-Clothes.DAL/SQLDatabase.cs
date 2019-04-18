using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.DAL
{
    public class SQLDatabase
    {
        static string _ConnectionString = @"Data Source=DESKTOP-33CI464\NHAN1110I;Initial Catalog=HUMGClothes;Integrated Security=True";

        public static string ConnectionString
        {
            get { return SQLDatabase._ConnectionString; }
            set { SQLDatabase._ConnectionString = value; }
        }

        static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
        //Excute Query 
        public static void ExcuteNoneQuery(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                using (SqlConnection conn = GetConnection())
                {
                    cmd.Connection = GetConnection();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetDataTable(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }

            }
            else
            {
                using (SqlConnection con = GetConnection())
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }

    }
}
