using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HUMG_Clothes
{
    public partial class ClientControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page = Request.QueryString["page"];
            switch (page)
            {
                case "FemaleClothes":
                    plLoadContent.Controls.Add(LoadControl("CMS/Female/Female.ascx"));
                    break;
                case "MaleClothes":
                    plLoadContent.Controls.Add(LoadControl("CMS/Male/Male.ascx"));
                    break;
                case "ProductDetail":
                    plLoadContent.Controls.Add(LoadControl("CMS/ProductDetail/ProductDetail.ascx"));
                    break;
                case "Cart":
                    plLoadContent.Controls.Add(LoadControl("CMS/Cart/Cart.ascx"));
                    break;
                case "Checkout":
                    plLoadContent.Controls.Add(LoadControl("CMS/Checkout/Checkout.ascx"));
                    break;
                case "SearchOrder":
                    plLoadContent.Controls.Add(LoadControl("CMS/SearchOrder/SearchOrder.ascx"));
                    break;
                case "Done":
                    plLoadContent.Controls.Add(LoadControl("CMS/Done/Done.ascx"));
                    break;
                default:
                    plLoadContent.Controls.Add(LoadControl("CMS/Home/Home.ascx"));
                    break;
            }
        }
    }
}