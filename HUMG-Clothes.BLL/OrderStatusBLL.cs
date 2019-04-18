using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HUMG_Clothes.DTO;
using HUMG_Clothes.DAL;
using System.Data.SqlClient;
using System.Data;
namespace HUMG_Clothes.BLL
{
    public class OrderStatusBLL
    {
        OrderStatusDAL Order = new OrderStatusDAL();
        public DataTable GetOrderStatusList(){
            return Order.GetOrderStatusList();
        }
        public OrderStatusDTO GetDetailOrderStatusWithID(int OrderStatusID)
        {
            return Order.GetDetailOrderStatusWithID(OrderStatusID);
        }
    }
}
