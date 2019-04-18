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
    public class PaymentDAL : SQLDatabase
    {
        public DataTable GetPaymentList()
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Payment");
            return GetDataTable(_sql);
        }
        public PaymentDTO GetPaymentDetailWithID(int PaymentID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Payment WHERE PaymentID = @PaymentID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@PaymentID", PaymentID);
            DataTable PaymentData = GetDataTable(_sql);
            return (new PaymentDTO(PaymentID,PaymentData.Rows[0]["PaymentName"].ToString()));
        }
    }
}
