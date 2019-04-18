using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DAL
{
    public class PaymentDTO
    {
        int _PaymentID;

        public int PaymentID
        {
            get { return _PaymentID; }
            set { _PaymentID = value; }
        }
        string _PaymentName;

        public string PaymentName
        {
            get { return _PaymentName; }
            set { _PaymentName = value; }
        }
        public PaymentDTO()
        {
            this.PaymentID = 0;
            this.PaymentName = "";
        }
        public PaymentDTO(int PaymentID, string PaymentName)
        {
            this.PaymentID = PaymentID;
            this.PaymentName = PaymentName;
        }
    }
}
