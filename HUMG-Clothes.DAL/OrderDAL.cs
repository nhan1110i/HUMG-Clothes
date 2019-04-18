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
    public class OrderDAL : SQLDatabase
    {
        public DataTable GetOrderList()
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM [Order]");
            return GetDataTable(_sql);
        }
        public DataTable FilderOrderListWithStatusID(int OrderStatusID)
        {
            if (OrderStatusID == 0)
            {
                return GetOrderList();
            }
            else
            {
                SqlCommand _sql = new SqlCommand("SELECT * FROM [Order] WHERE OrderStatusID = @OrderStatusID");
                _sql.CommandType = CommandType.Text;
                _sql.Parameters.AddWithValue("@OrderStatusID", OrderStatusID);
                return GetDataTable(_sql);
            }
        }
        public void InserOrder(OrderDTO Order)
        {
            SqlCommand _sql = new SqlCommand("INSERT INTO [Order] VALUES(@CustomerID,@OrderDate,@PaymentID,@OrderStatusID,@DiscountCodeID)");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@CustomerID", Order.CustomerID);
            _sql.Parameters.AddWithValue("@OrderDate", Order.OrderDate);
            _sql.Parameters.AddWithValue("@PaymentID", Order.PaymentID);
            _sql.Parameters.AddWithValue("@OrderStatusID", Order.OrderStatusID);
            _sql.Parameters.AddWithValue("@DiscountCodeID", Order.DepreciateCodeID);
            ExcuteNoneQuery(_sql);
        }
        public int GetLastOrderID()
        {
            SqlCommand _sql = new SqlCommand("SELECT TOP 1 * FROM [Order] ORDER BY OrderID DESC");
            return int.Parse(GetDataTable(_sql).Rows[0]["OrderID"].ToString().Trim());
        }
        public int GetOrderStatusWithOrderID(int OrderID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM [Order] WHERE OrderID = @OrderID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@OrderID", OrderID);
            return int.Parse(GetDataTable(_sql).Rows[0]["OrderStatusID"].ToString().Trim());
        }
        public int GetCustomerIDWithOrderID(int OrderID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM [Order] WHERE OrderID = @OrderID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.Add("@OrderID", OrderID);
            return int.Parse(GetDataTable(_sql).Rows[0]["CustomerID"].ToString().Trim());
        }
        public void UpdateOrderWithOrderStatus(int OrderID, int OrderStatus)
        {
            SqlCommand _sql = new SqlCommand("UPDATE [Order] SET OrderStatusID = @OrderStatus WHERE OrderID = @OrderID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@OrderStatus", OrderStatus);
            _sql.Parameters.AddWithValue("@OrderID", OrderID);
            ExcuteNoneQuery(_sql);
        }
    }
}
