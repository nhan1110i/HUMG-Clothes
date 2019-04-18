using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.DAL
{
    public class TownDAL : SQLDatabase
    {
        public DataTable GetTownListWithCityID(int CityID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Town WHERE CityID = @CityID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@CityID", CityID);
            return GetDataTable(_sql);
        }
    }
}
