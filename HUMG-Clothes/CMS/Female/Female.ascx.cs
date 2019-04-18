using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.CMS.Female
{
    public partial class Female : System.Web.UI.UserControl
    {
        ProductBLL Product = new ProductBLL();
        ColorBLL Color = new ColorBLL();
        bool up = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            rptColor.DataSource = Color.GetColorList();
            rptColor.DataBind();
            if (String.IsNullOrEmpty(Request.QueryString["Category"]) && String.IsNullOrEmpty(Request.QueryString["Color"]))
            {
                Load();
            }
            else
            {
                if (String.IsNullOrEmpty(Request.QueryString["Color"]) && !String.IsNullOrEmpty(Request.QueryString["Category"]))
                {
                    LoadProductWithCategory(int.Parse(Request.QueryString["Category"]));
                }
                else
                {
                    LoadProductWithColor(int.Parse(Request.QueryString["Color"]));
                }
                
            }
        }
        private void Load()
        {
            rptFemale.DataSource = Product.FilterProductWithCategoryandSex(0, 1);
            rptFemale.DataBind();
            
        }
        void LoadProductWithCategory(int ProductCategoryID)
        {
            rptFemale.DataSource = Product.FilterProductWithCategoryandSex(ProductCategoryID, 1);
            rptFemale.DataBind();
        }
        void LoadProductWithColor(int Color)
        {
            rptFemale.DataSource = Product.FilterProductWithColorAndSex(Color,1);
            rptFemale.DataBind();
        }
        void LoadProductWithPrice(int sort, int sex)
        {
            rptFemale.DataSource = Product.FilterProductWithPriceAndSex(sort,sex);
            rptFemale.DataBind();
        }
        protected void rptFemale_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "AddtoCart":
                    
                    break;
                default:
                    break;
            }
        }

        protected void drpPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductWithPrice(int.Parse(drpPrice.SelectedValue.ToString().Trim()), 1);
        }
    }
}