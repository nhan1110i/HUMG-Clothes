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
    public class PaymentBLL
    {
        PaymentDAL Payment = new PaymentDAL();
        public DataTable GetPaymentList()
        {
            return Payment.GetPaymentList();
        }
        public PaymentDTO GetPaymentDetailWithID(int PaymentID)
        {
            return Payment.GetPaymentDetailWithID(PaymentID);
        }
    }
}
