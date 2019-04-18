using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HUMG_Clothes.Admin
{
    public partial class AdminControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page = Request.QueryString["page"];
            switch (page)
            {
                case "ManageProduct":
                    plLoadContent.Controls.Add(LoadControl("CMS/Products/ManageProduct/ShowProduct.ascx"));
                    break;
                case "AddNewProduct":
                    plLoadContent.Controls.Add(LoadControl("CMS/Products/NewUpdateProduct/NewUpdateProduct.ascx"));
                    break;
                case "ManageCategory":
                    plLoadContent.Controls.Add(LoadControl("CMS/Products/ManageCategory/ManageCategory.ascx"));
                    break;
                case "ManageSize":
                    plLoadContent.Controls.Add(LoadControl("CMS/Products/ManageSize/ManageSize.ascx"));
                    break;
                case "ManageColor":
                    plLoadContent.Controls.Add(LoadControl("CMS/Products/ManageColor/ManageColor.ascx"));
                    break;
                case "Order":
                    plLoadContent.Controls.Add(LoadControl("CMS/Order/Order.ascx"));
                    break;
                case "OrderDetail":
                    plLoadContent.Controls.Add(LoadControl("CMS/OrderDetail/OrderDetail.ascx"));
                    break;
                default:
                    plLoadContent.Controls.Add(LoadControl("CMS/Order/Order.ascx"));
                    break;
            }
        }
    }
}