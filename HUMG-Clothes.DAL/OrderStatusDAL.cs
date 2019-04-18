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
    public class OrderStatusDAL : SQLDatabase
    {
        public DataTable GetOrderStatusList()
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.OrderStatus");
            return GetDataTable(_sql);
        }
        public OrderStatusDTO GetDetailOrderStatusWithID(int OrderStatusID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.OrderStatus WHERE OrderStatusID = @OrderStatusID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@OrderStatusID", OrderStatusID);
             return (new OrderStatusDTO(OrderStatusID,GetDataTable(_sql).Rows[0]["OrderStatus"].ToString().Trim()));
        }
    }
}
