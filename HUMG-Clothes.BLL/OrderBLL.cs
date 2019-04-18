using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DAL;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes.BLL
{
    public class OrderBLL
    {
        OrderDAL OrderDAL = new OrderDAL();
        CustomerBLL CustomerBLL = new CustomerBLL();
        OrderDetailBLL OrderDetailBLL = new OrderDetailBLL();
        DiscountCodeBLL DiscountCodeBLL = new DiscountCodeBLL();
        PaymentBLL PaymentBLL = new PaymentBLL();
        OrderStatusBLL OrderStatusBLL = new OrderStatusBLL();
        public DataTable FilderOrderListWithStatusID(int OrderStatusID)
        {
            DataTable OrderList = OrderDAL.FilderOrderListWithStatusID(OrderStatusID);
            OrderList.Columns.Add("CustomerName", typeof(String));
            OrderList.Columns.Add("CustomerPhone", typeof(String));
            OrderList.Columns.Add("TotalMoney", typeof(String));
            OrderList.Columns.Add("TotalQuantity", typeof(int));
            OrderList.Columns.Add("DiscountCode", typeof(String));
            OrderList.Columns.Add("PaymentName", typeof(String));
            OrderList.Columns.Add("OrderStatus",typeof(String));
            for (int i = 0; i < OrderList.Rows.Count; i++)
            {
                int OrderID = int.Parse(OrderList.Rows[i]["OrderID"].ToString().Trim());
                OrderList.Rows[i]["CustomerName"] = CustomerBLL.GetCustomerWithID(int.Parse(OrderList.Rows[i]["CustomerID"].ToString().Trim())).CustomerName;
                OrderList.Rows[i]["CustomerPhone"] = CustomerBLL.GetCustomerWithID(int.Parse(OrderList.Rows[i]["CustomerID"].ToString().Trim())).CustomerPhone;
                OrderList.Rows[i]["TotalMoney"] = String.Format("{0:0,0}", OrderDetailBLL.GetTotalMoneyOrderWithOrderID(OrderID).ToString());
                OrderList.Rows[i]["TotalQuantity"] = OrderDetailBLL.GetTotalQuantityWithOrderID(OrderID);
                OrderList.Rows[i]["DiscountCode"] = DiscountCodeBLL.GetDiscountCodeDetailWithID(int.Parse(OrderList.Rows[i]["DiscountCodeID"].ToString().Trim())).Code;
                OrderList.Rows[i]["PaymentName"] = PaymentBLL.GetPaymentDetailWithID(int.Parse(OrderList.Rows[i]["PaymentID"].ToString().Trim())).PaymentName;
                OrderList.Rows[i]["OrderStatus"] = OrderStatusBLL.GetDetailOrderStatusWithID(int.Parse(OrderList.Rows[i]["OrderStatusID"].ToString().Trim())).OrderStatus1;
            }
            return OrderList;
        }
        public void InserOrder(OrderDTO Order)
        {
            OrderDAL.InserOrder(Order);
        }
        public int GetLastOrderID()
        {
            return OrderDAL.GetLastOrderID();
        }
        public int GetOrderStatusWithOrderID(int OrderID)
        {
            return OrderDAL.GetOrderStatusWithOrderID(OrderID);
        }
        public void UpdateOrderWithOrderStatus(int OrderID, int OrderStatus)
        {
            OrderDAL.UpdateOrderWithOrderStatus(OrderID, OrderStatus);
        }
        public int GetCustomerIDWithOrderID(int OrderID)
        {
            return OrderDAL.GetCustomerIDWithOrderID(OrderID);
        }
    }
}
