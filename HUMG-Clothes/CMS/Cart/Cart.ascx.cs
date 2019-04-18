using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.CMS.Cart
{
    public partial class Cart : System.Web.UI.UserControl
    {
        ProductBLL ProductBll = new ProductBLL();
        DataTable dataCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart-product"] != null && Session["cart-quantity"] != null)
            {
                string[] arrProductID = Session["cart-product"].ToString().Trim().Split('/');
                string[] arrQuantity = Session["cart-quantity"].ToString().Trim().Split('/');
                dataCart = ProductBll.GetCart(arrProductID, arrQuantity);
                rptCart.DataSource = dataCart;
                rptCart.DataBind();
                float totalMoney = 0;
                for (int i = 0; i < dataCart.Rows.Count; i++)
                {
                    totalMoney = totalMoney + float.Parse(dataCart.Rows[i]["Money"].ToString().Trim());
                }
                lblTotalMoney.Text = String.Format("{0:0,0}", totalMoney.ToString());
            }
            else
            {
                lbl.Visible = true;
            }
            
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?page=Checkout");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?page=Home");
        }
    }
}