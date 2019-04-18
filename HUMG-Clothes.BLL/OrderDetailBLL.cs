using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HUMG_Clothes.DAL;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes.BLL
{
    public class OrderDetailBLL
    {
        OrderDetailDAL OrderDetailDAL = new OrderDetailDAL();
        ProductBLL ProductBLL = new ProductBLL();
        public DataTable GetOrderDetailWithOrderID(int OrderID)
        {
            DataTable OrderDetail = OrderDetailDAL.GetOrderDetailWithOrderID(OrderID);
            OrderDetail.Columns.Add("ProductName", typeof(String));
            OrderDetail.Columns.Add("ProductPrice", typeof(float));
            OrderDetail.Columns.Add("ProductTotalMoney", typeof(float));
            OrderDetail.Columns.Add("Image", typeof(String));
            for (int i = 0; i < OrderDetail.Rows.Count; i++)
            {
                ProductDTO Product = ProductBLL.GetProductDetailWithID(int.Parse(OrderDetail.Rows[i]["ProductID"].ToString().Trim()));
                OrderDetail.Rows[i]["ProductName"] = Product.ProductName;
                OrderDetail.Rows[i]["ProductPrice"] = Product.ProductPrice;
                OrderDetail.Rows[i]["ProductTotalMoney"] = Product.ProductPrice * float.Parse(OrderDetail.Rows[i]["Quantity"].ToString().Trim());
                OrderDetail.Rows[i]["Image"] = Product.ProductImage.Split('*')[1];

            }
            return OrderDetail;
        }
        public float GetTotalMoneyOrderWithOrderID(int OrderID)
        {
            float TotalMoney = 0;
            DataTable Order = GetOrderDetailWithOrderID(OrderID);
            for (int i = 0; i < Order.Rows.Count; i++)
            {
                TotalMoney += float.Parse(Order.Rows[i]["ProductTotalMoney"].ToString().Trim());
            }
            return TotalMoney;
        }
        public int GetTotalQuantityWithOrderID(int OrderID)
        {
            int TotalQuantity = 0;
            DataTable Order = GetOrderDetailWithOrderID(OrderID);
            for (int i = 0; i < Order.Rows.Count; i++)
            {
                TotalQuantity += int.Parse(Order.Rows[i]["Quantity"].ToString().Trim());
            }
            return TotalQuantity;
        }
        public void InsertOrderDetail(string[] arrProductID, string[] arrQuantity, int OrderID)
        {
            OrderDetailDAL.InsertOrderDetail(arrProductID, arrQuantity, OrderID);
        }
    }
}
