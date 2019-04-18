using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using HUMG_Clothes.DTO;
namespace HUMG_Clothes.Admin.CMS.OrderDetail
{
    public partial class OrderDetail : System.Web.UI.UserControl
    {
        public int od = 1;
        OrderDetailBLL OrderDetailBLL = new OrderDetailBLL();
        CustomerBLL CustomerBLL = new CustomerBLL();
        OrderBLL OrderBLL = new OrderBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Load();
        }
        void Load()
        {
            int OrderID = int.Parse(Request.QueryString["OrderID"]);
            lblOrderID.Text = "MÃ ĐƠN : DH" + OrderID.ToString();
            rptOrderDetail.DataSource = OrderDetailBLL.GetOrderDetailWithOrderID(OrderID);
            rptOrderDetail.DataBind();
            lblTotalMoney.Text = OrderDetailBLL.GetTotalMoneyOrderWithOrderID(OrderID).ToString();
            lblTotalQuantity.Text = OrderDetailBLL.GetTotalQuantityWithOrderID(OrderID).ToString();
            int CustomerID = OrderBLL.GetCustomerIDWithOrderID(OrderID);
            CustomerDTO Customer = CustomerBLL.GetCustomerWithID(CustomerID);
            lblTen.Text = Customer.CustomerName;
            lblPhone.Text = Customer.CustomerPhone;
            lblMail.Text = Customer.CustomerEmail;
            lblAdd.Text = Customer.CustomerAddress + ", " + Customer.CustomerTown + ", " + Customer.CustomerCity;
        }
    }
}