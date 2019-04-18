using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
namespace HUMG_Clothes.CMS.Male
{
    public partial class Male : System.Web.UI.UserControl
    {
        ProductBLL Product = new ProductBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Request.QueryString["Category"]))
            {
                Load();
            }
            else
            {
                LoadProductWithCategory(int.Parse(Request.QueryString["Category"]));
            }
        }
        private void Load()
        {
            rptMale.DataSource = Product.FilterProductWithCategoryandSex(0, 0);
            rptMale.DataBind();
        }
        void LoadProductWithCategory(int ProductCategoryID)
        {
            rptMale.DataSource = Product.FilterProductWithCategoryandSex(ProductCategoryID, 0);
            rptMale.DataBind();
        }
        protected void rptFemale_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}