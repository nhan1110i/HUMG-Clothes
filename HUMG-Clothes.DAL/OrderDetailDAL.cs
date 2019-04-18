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
    public class OrderDetailDAL : SQLDatabase
    {
        public DataTable GetOrderDetailWithOrderID(int OrderID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.OrderDetail WHERE OrderID = @OrderID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@OrderID", OrderID);
            return GetDataTable(_sql);
        }
        public void InsertOrderDetail(string[] arrProductID, string[] arrQuantity, int OrderID)
        {
            for (int i = 0; i < arrProductID.Length; i++)
            {
                SqlCommand _sqlCom = new SqlCommand("INSERT INTO dbo.OrderDetail VALUES(@ProductID,@Quantity,@OrderID)");
                _sqlCom.CommandType = CommandType.Text;
                _sqlCom.Parameters.AddWithValue("@ProductID", int.Parse(arrProductID[i].Trim()));
                _sqlCom.Parameters.AddWithValue("@Quantity", int.Parse(arrQuantity[i].Trim()));
                _sqlCom.Parameters.AddWithValue("@OrderID", OrderID);
                ExcuteNoneQuery(_sqlCom);
            }
        }
    }
}
