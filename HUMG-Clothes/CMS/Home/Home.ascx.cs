using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.BLL;

namespace HUMG_Clothes.CMS.Home
{
    public partial class Home : System.Web.UI.UserControl
    {
        DataTable newProductList;
        DataTable maleProductList;
        DataTable femaleProductList;
        ProductBLL ProductBLL = new ProductBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadNewProductList();
            LoadMaleProductList();
            LoadFemaleProductList();
        }
        void LoadNewProductList()
        {
            newProductList = ProductBLL.GetNewProductList(8);
            rptNewProductList.DataSource = newProductList;
            rptNewProductList.DataBind();
        }
        void LoadMaleProductList()
        {
            maleProductList = ProductBLL.GetProductListWithSex(0);
            rptMaleProductList.DataSource = maleProductList;
            rptMaleProductList.DataBind();
        }
        void LoadFemaleProductList()
        {
            femaleProductList = ProductBLL.GetProductListWithSex(1);
            rptFemaleProductList.DataSource = femaleProductList;
            rptFemaleProductList.DataBind();
        }

        protected void rptNewProductList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "AddtoCart":
                    if (Session["cart-product"] != null)
                    {
                        Session["cart-product"] = Session["cart-product"].ToString() + "/" +e.CommandArgument.ToString();
                        Session["cart-quantity"] = Session["cart-quantity"] + "/" + "1";
                    }
                    else
                    {
                        Session["cart-product"] =e.CommandArgument.ToString();
                        Session["cart-quantity"] = "1";
                    }
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "AddtoCart()", true);
                    break;
            }
        }

        protected void rptMaleProductList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "AddtoCart":
                    if (Session["cart-product"] != null)
                    {
                        Session["cart-product"] = Session["cart-product"].ToString() + "/" +e.CommandArgument.ToString();
                        Session["cart-quantity"] = Session["cart-quantity"] + "/" + "1";
                    }
                    else
                    {
                        Session["cart-product"] = e.CommandArgument.ToString();
                        Session["cart-quantity"] = "1";
                    }
                    break;
            }
        }

        protected void rptFemaleProductList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "AddtoCart":
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
            }
        }
    }
}