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
namespace HUMG_Clothes.CMS.SearchOrder
{
    public partial class SearchOrder : System.Web.UI.UserControl
    {
        OrderDetailBLL OrderDetail = new OrderDetailBLL();
        OrderStatusBLL OrderStatus = new OrderStatusBLL();
        OrderBLL OrderBLL = new OrderBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptSearch.Visible = false;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (OrderDetail.GetOrderDetailWithOrderID(int.Parse(txtOrderID.Text.Trim())).Rows.Count > 0)
            {
                rptSearch.DataSource = OrderDetail.GetOrderDetailWithOrderID(int.Parse(txtOrderID.Text.Trim()));
                rptSearch.DataBind();
                rptSearch.Visible = true;
                Label1.Visible = true;
                lblNotice.Text = OrderStatus.GetDetailOrderStatusWithID(OrderBLL.GetOrderStatusWithOrderID(int.Parse(txtOrderID.Text.Trim()))).OrderStatus1;
            }
            else
            {
                lblNotice.Text = "Mã đơn hàng bạn vừa nhập không tồn tại.";
            }
        }
    }
}