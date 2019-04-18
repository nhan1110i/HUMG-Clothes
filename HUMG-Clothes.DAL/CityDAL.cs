using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.DAL
{
    public class CityDAL : SQLDatabase
    {
        public DataTable GetCityList()
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.City");
            return GetDataTable(_sql);
        }
    }
}
