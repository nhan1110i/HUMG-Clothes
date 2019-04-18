using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DAL;
namespace HUMG_Clothes.BLL
{
    public class CityBLL
    {
        CityDAL City = new CityDAL();
        public DataTable GetCityList()
        {
            return City.GetCityList();
        }
    }
}
