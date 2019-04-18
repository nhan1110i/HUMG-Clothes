using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class OrderDetailDTO
    {
        int _OrderDetailID;

        public int OrderDetailID
        {
            get { return _OrderDetailID; }
            set { _OrderDetailID = value; }
        }
        int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        public OrderDetailDTO()
        {
            this.OrderID = this.OrderDetailID = this.ProductID = this.Quantity = 0;
        }
        public OrderDetailDTO(int OrderDetailID, int ProductID, int Quantity, int OrderID)
        {
            this.OrderDetailID = OrderDetailID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.OrderID = OrderID;
        }

    }
}
