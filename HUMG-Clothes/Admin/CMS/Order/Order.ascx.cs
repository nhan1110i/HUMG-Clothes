using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.BLL;

namespace HUMG_Clothes.Admin.CMS.Order
{
    public partial class Order : System.Web.UI.UserControl
    {
        public int od = 1;
        OrderBLL OrderBLL = new OrderBLL();
        OrderStatusBLL OrderStatusBLL = new OrderStatusBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData(1);
        }
        void LoadData(int OrderStatus)
        {
            rptOrder.DataSource = OrderBLL.FilderOrderListWithStatusID(OrderStatus);
            rptOrder.DataBind();
            drpFilterOrder.DataSource = OrderStatusBLL.GetOrderStatusList();
            drpFilterOrder.DataValueField = "OrderStatusID";
            drpFilterOrder.DataTextField = "OrderStatus";
            drpFilterOrder.DataBind();
            AddFirstItemDropdownlist(drpFilterOrder);
            drpFilterOrder.SelectedValue = OrderStatus.ToString().Trim();
        }

        protected void rptOrder_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "ViewOrderDetail":
                    string orderdetail = "/Admin/Default.aspx?page=OrderDetail&OrderID=" + e.CommandArgument.ToString().Trim();
                    Response.Write("<script> window.open('"+orderdetail+"','_blank'); </script>");
                    //Response.Redirect("/Admin/Default.aspx?page=OrderDetail&OrderID=" + e.CommandArgument.ToString().Trim());
                    break;
                case "Sent":
                    OrderBLL.UpdateOrderWithOrderStatus(int.Parse(e.CommandArgument.ToString().Trim()), 2);
                    Response.Redirect(Request.Url.ToString());
                    break;
                case "Deline":
                    OrderBLL.UpdateOrderWithOrderStatus(int.Parse(e.CommandArgument.ToString().Trim()), 3);
                    Response.Redirect(Request.Url.ToString());
                    break;
                default:
                    break;
            }
        }

        protected void drpFilterOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(int.Parse(drpFilterOrder.SelectedValue.ToString().Trim()));
        }
        void AddFirstItemDropdownlist(DropDownList drp)
        {
            ListItem newList = new ListItem("Tất cả", "0");
            drp.Items.Insert(0, newList);

        }
    }
}