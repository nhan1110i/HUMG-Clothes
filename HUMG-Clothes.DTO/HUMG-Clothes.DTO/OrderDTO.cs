using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class OrderDTO
    {
        int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        int _CustomerID;

        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        int _PaymentID;

        public int PaymentID
        {
            get { return _PaymentID; }
            set { _PaymentID = value; }
        }
        int _OrderStatusID;

        public int OrderStatusID
        {
            get { return _OrderStatusID; }
            set { _OrderStatusID = value; }
        }
        int _DepreciateCodeID;

        public int DepreciateCodeID
        {
            get { return _DepreciateCodeID; }
            set { _DepreciateCodeID = value; }
        }
        DateTime _OrderDate;

        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }
        public OrderDTO()
        {
            this.CustomerID = this.OrderID = this.PaymentID = this.OrderStatusID = this.DepreciateCodeID = 0;
            this.OrderDate = DateTime.Now;
        }
        public OrderDTO(int OrderID, int CustomerID, DateTime OrderDate, int PaymentID, int OrderStatusID, int DepreciateCodeID)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.OrderDate = OrderDate;
            this.PaymentID = PaymentID;
            this.OrderStatusID = OrderStatusID;
            this.DepreciateCodeID = DepreciateCodeID;
        }
    }
}
