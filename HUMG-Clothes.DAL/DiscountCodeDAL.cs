using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes.DAL
{
    public class DiscountCodeDAL : SQLDatabase
    {
        public DiscountCodeDTO GetDiscountCodeDetailWithID(int DiscountCodeID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.DiscountCode WHERE DiscountCodeID = @DiscountCodeID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@DiscountCodeID", DiscountCodeID);
            DataTable DiscountCode = GetDataTable(_sql);
            return (new DiscountCodeDTO(DiscountCodeID, DiscountCode.Rows[0]["Code"].ToString().Trim(), int.Parse(DiscountCode.Rows[0]["DiscountPercent"].ToString().Trim())));
        }
    }
}
