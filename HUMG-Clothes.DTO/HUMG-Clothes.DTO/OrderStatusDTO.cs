using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class OrderStatusDTO
    {
        int OrderStatusID;

        public int OrderStatusID1
        {
            get { return OrderStatusID; }
            set { OrderStatusID = value; }
        }
        string OrderStatus;

        public string OrderStatus1
        {
            get { return OrderStatus; }
            set { OrderStatus = value; }
        }
        public OrderStatusDTO()
        {
            this.OrderStatus1 = "";
            this.OrderStatusID1 = 0;
        }
        public OrderStatusDTO(int OrderStatusID, string OrderStatus)
        {
            this.OrderStatusID1 = OrderStatusID;
            this.OrderStatus1 = OrderStatus;
        }
    }
}
