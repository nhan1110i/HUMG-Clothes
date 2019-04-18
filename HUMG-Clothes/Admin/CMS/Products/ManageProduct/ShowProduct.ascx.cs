using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using System.Data;
using System.Data.SqlClient;

namespace HUMG_Clothes.Admin.CMS.Products.ShowProduct
{
    public partial class ShowProduct : System.Web.UI.UserControl
    {
        public int od = 1;
        CategoryBLL CategoryBLL = new CategoryBLL();
        ColorBLL ColorBLL = new ColorBLL();
        SizeBLL SizeBLL = new SizeBLL();
        ProductBLL ProductBLL = new ProductBLL();
        DataTable ProductList;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        void LoadProduct()
        {
            
            drpCategory.DataSource = CategoryBLL.GetCategoryList();
            drpCategory.DataValueField = "ProductCategoryID";
            drpCategory.DataTextField = "ProductCategoryName";
            drpCategory.DataBind();
            AddFirstItemDropdownlist(drpCategory);
            ProductList = ProductBLL.GetProductListDetail();
            rptManageProduct.DataSource = ProductList;
            rptManageProduct.DataBind();
            LoadActiveProduct();
        }
        void LoadActiveProduct()
        {
            for (int i = 0; i < ProductList.Rows.Count; i++)
            {
                if (ProductList.Rows[i]["ProductActive"].ToString().Trim() == "True")
                {
                    (rptManageProduct.Items[i].FindControl("cbActiveProduct") as CheckBox).Checked = true;
                }
                else
                {
                    (rptManageProduct.Items[i].FindControl("cbActiveProduct") as CheckBox).Checked = false;
                }
            }
        }
        void AddFirstItemDropdownlist(DropDownList drp)
        {
            ListItem newList = new ListItem("Tất cả", "0");
            drp.Items.Insert(0, newList);
            
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Default.aspx?page=AddNewProduct");
        }

        protected void rptManageProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "deleteProduct":
                    ProductBLL.DeleteProductWithID(int.Parse(e.CommandArgument.ToString().Trim()));
                    LoadProduct();
                    break;
                case "editProduct":
                    Response.Redirect("/Admin/Default.aspx?page=AddNewProduct&ProductID=" + e.CommandArgument.ToString().Trim());
                    break;
                default:
                    break;

            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < rptManageProduct.Items.Count; i++)
            {
                (rptManageProduct.Items[i].FindControl("cb") as CheckBox).Checked = true;
                
            }
        }
        protected void lbtnDeleteSelectProduct_Click(object sender, EventArgs e)
        {
            string[] ListDeleteProduct = new string[rptManageProduct.Items.Count];
            int CountProduct = 0;
            for (int i = 0; i < rptManageProduct.Items.Count; i++)
            {
                if ((rptManageProduct.Items[i].FindControl("cb") as CheckBox).Checked == true)
                {
                    ListDeleteProduct[CountProduct] =(rptManageProduct.Items[i].FindControl("hfID") as HiddenField).Value.ToString();
                    CountProduct++;
                }
            }
            ProductBLL.DeleteListProduct(ListDeleteProduct, CountProduct);
            Response.Redirect(Request.Url.ToString());
        }

        protected void lbtnAopect_Click(object sender, EventArgs e)
        {
            bool[] ListProductActive = new bool[rptManageProduct.Items.Count];
            int[] ListProductID = new int[rptManageProduct.Items.Count];
            for (int i = 0; i < rptManageProduct.Items.Count; i++)
            {
                ListProductActive[i] = (rptManageProduct.Items[i].FindControl("cbActiveProduct") as CheckBox).Checked;
                ListProductID[i] = int.Parse((rptManageProduct.Items[i].FindControl("hfID") as HiddenField).Value.ToString().Trim());
            }
            ProductBLL.ChangeActiveListProduct(ListProductID, ListProductActive);
            Response.Redirect(Request.Url.ToString());

            
        }

        protected void drpSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void lbtnUnfilter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchProduct.Text.Trim()))
            {
                ProductList = ProductBLL.FilterProductWithCategoryandSex(int.Parse(drpCategory.SelectedValue), int.Parse(drpSex.SelectedValue));
                rptManageProduct.DataSource = ProductList;
                rptManageProduct.DataBind();
                LoadActiveProduct();
            }
            else
            {

            }

        }

        protected void lbtnFilter_Click(object sender, EventArgs e)
        {
            lblNotice.Text = "";
            rptManageProduct.DataSource = ProductBLL.GetProductListDetail();
            rptManageProduct.DataBind();
            drpCategory.SelectedIndex = 0;
            drpSex.SelectedIndex = 0;
            LoadActiveProduct();
        }

        protected void drpRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNotice.Text = "TEST";
        }

        protected void lbtnReports_Click(object sender, EventArgs e)
        {
            Response.Write("<script> window.open('/Admin/ReportsForms/ProductReports.aspx','_blank'); </script>");
        }
    }
}