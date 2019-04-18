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
    public class CustomerBLL
    {
        CustomerDAL CustomerDAL = new CustomerDAL();
        public DataTable GetCustomerList()
        {
            return CustomerDAL.GetCustomerList();
        }
        public CustomerDTO GetCustomerWithID(int CustomerID)
        {
            return CustomerDAL.GetCustomerWithID(CustomerID);
        }
        public void InsertCustomer(CustomerDTO Customer)
        {
            CustomerDAL.InsertCustomer(Customer);
        }
        public int GetLastCustomerID()
        {
            return CustomerDAL.GetLastCustomerID();
        }
    }
}
