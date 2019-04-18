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
    public class CustomerDAL : SQLDatabase
    {
        public DataTable GetCustomerList()
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Customer");
            return GetDataTable(_sql);
        }
        public CustomerDTO GetCustomerWithID(int CustomerID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Customer WHERE CustomerID = @CustomerID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@CustomerID",CustomerID);
            DataTable CustomerDetail = GetDataTable(_sql);
            CustomerDTO Customer = new CustomerDTO(int.Parse(CustomerDetail.Rows[0]["CustomerID"].ToString().Trim()), CustomerDetail.Rows[0]["CustomerName"].ToString().Trim(), CustomerDetail.Rows[0]["CustomerPhone"].ToString().Trim(), CustomerDetail.Rows[0]["CustomerEmail"].ToString().Trim(), CustomerDetail.Rows[0]["CustomerCity"].ToString().Trim(), CustomerDetail.Rows[0]["CustomerTown"].ToString().Trim(), CustomerDetail.Rows[0]["CustomerAddress"].ToString().Trim());
            return Customer;
        }
        public void InsertCustomer(CustomerDTO Customer)
        {
            SqlCommand _sql = new SqlCommand("INSERT INTO dbo.Customer VALUES(@CustomerName,@CustomerPhone,@CustomerEmail,@CustomerCity,@CustomerTown,@CustomerAddress)");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@CustomerName", Customer.CustomerName);
            _sql.Parameters.AddWithValue("@CustomerPhone", Customer.CustomerPhone);
            _sql.Parameters.AddWithValue("@CustomerEmail", Customer.CustomerEmail);
            _sql.Parameters.AddWithValue("@CustomerCity", Customer.CustomerCity);
            _sql.Parameters.AddWithValue("@CustomerTown", Customer.CustomerTown);
            _sql.Parameters.AddWithValue("@CustomerAddress", Customer.CustomerAddress);
            ExcuteNoneQuery(_sql);
        }
        public int GetLastCustomerID()
        {
            SqlCommand _sql = new SqlCommand("SELECT TOP 1 * FROM dbo.Customer ORDER BY CustomerID DESC");
            DataTable Customer = GetDataTable(_sql);
            return int.Parse(Customer.Rows[0]["CustomerID"].ToString().Trim());
        }
    }
}
