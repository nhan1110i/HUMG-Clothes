using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.BLL;
using HUMG_Clothes.DTO;
namespace HUMG_Clothes.CMS.Pay
{
    public partial class Pay : System.Web.UI.UserControl
    {
        ProductBLL ProductBll = new ProductBLL();
        PaymentBLL PaymentBLL = new PaymentBLL();
        CustomerBLL CustomerBLL = new CustomerBLL();
        OrderBLL OrderBLL = new OrderBLL();
        OrderDetailBLL OrderDetailBLL = new OrderDetailBLL();
        CityBLL CityBLL = new CityBLL();
        TownBLL Town = new TownBLL();
        DataTable dataCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arrProductID = Session["cart-product"].ToString().Trim().Split('/');
            string[] arrQuantity = Session["cart-quantity"].ToString().Trim().Split('/');
            dataCart = ProductBll.GetCart(arrProductID, arrQuantity);
            rptCheckOut.DataSource = dataCart;
            rptCheckOut.DataBind();
            rblPayment.DataSource = PaymentBLL.GetPaymentList();
            rblPayment.DataValueField = "PaymentID";
            rblPayment.DataTextField = "PaymentName";
            rblPayment.DataBind();
            drpCity.DataSource = CityBLL.GetCityList();
            drpCity.DataValueField = "CityID";
            drpCity.DataTextField = "CityName";
            drpCity.DataBind();
            drpTown.DataSource = Town.GetTownListWithCityID(1);
            drpTown.DataValueField = "TownID";
            drpTown.DataTextField = "TownName";
            drpTown.DataBind();
            float totalMoney = 0;
            for (int i = 0; i < dataCart.Rows.Count; i++)
            {
                totalMoney = totalMoney + float.Parse(dataCart.Rows[i]["Money"].ToString().Trim());
            }
            lblTotalMoney.Text = String.Format("{0:0,0}", totalMoney.ToString());
            lblTotalMoney2.Text = String.Format("{0:0,0}", totalMoney.ToString());
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            CustomerDTO Customer = new CustomerDTO(0, txtName.Text.Trim(), txtPhone.Text.Trim(), txtMail.Text, drpCity.SelectedItem.ToString().Trim(), drpTown.SelectedItem.ToString().Trim(), txtAddress.Text);
            CustomerBLL.InsertCustomer(Customer);
            OrderDTO Order = new OrderDTO(0, CustomerBLL.GetLastCustomerID(), DateTime.Now, int.Parse(rblPayment.SelectedValue.ToString().Trim()), 1, 2);
            OrderBLL.InserOrder(Order);
            string [] arrProductID = Session["cart-product"].ToString().Trim().Split('/');
            string [] arrQuantity = Session["cart-quantity"].ToString().Trim().Split('/');
            OrderDetailBLL.InsertOrderDetail(arrProductID, arrQuantity, OrderBLL.GetLastOrderID());
            Response.Redirect("Home.aspx?page=Done");
        }
        protected void drpCity_SelectedIndexChanged1(object sender, EventArgs e)
        {
            drpTown.DataSource = Town.GetTownListWithCityID(int.Parse(drpCity.SelectedValue.ToString().Trim()));
            drpTown.DataValueField = "TownID";
            drpTown.DataTextField = "TownName";
            drpTown.DataBind();
        }
    }
}