using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using HUMG_Clothes.DTO;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.CMS.ProductDetail
{
    public partial class ProductDetail : System.Web.UI.UserControl
    {
        ProductBLL ProductBLL = new ProductBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptProduct.DataSource = ProductBLL.GetProductDetailWithID2(int.Parse(Request.QueryString["Product"]));
            rptProduct.DataBind();
        }

        protected void rptProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "BuyNow":
                    if (Session["cart-product"] != null)
                    {
                        Session["cart-product"] = Session["cart-product"].ToString() + "/" + e.CommandArgument.ToString();
                        Session["cart-quantity"] = Session["cart-quantity"] + "/" + "1";
                    }
                    else
                    {
                        Session["cart-product"] = e.CommandArgument.ToString();
                        Session["cart-quantity"] = "1";
                    }
                    break;
                default:
                    break;
            }
        }
    }
}