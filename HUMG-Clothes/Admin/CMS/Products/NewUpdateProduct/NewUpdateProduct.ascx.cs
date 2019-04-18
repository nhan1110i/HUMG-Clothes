using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.DTO;
using HUMG_Clothes.BLL;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace HUMG_Clothes.Admin.CMS.Products.AddNewProduct
{
    public partial class AddNewProduct : System.Web.UI.UserControl
    {
        CategoryBLL CategoryBLL = new CategoryBLL();
        ColorBLL ColorBLL = new ColorBLL();
        SizeBLL SizeBLL = new SizeBLL();
        ProductBLL ProductBLL = new ProductBLL();
        public int QuantityImage = 0;
        //public string s = '<asp:Image ID="imgThumbail" runat="server" CssClass="img-responsive" ImageUrl="~/Admin/IMG/AdminImage/AvaLogin.jpg" /></asp:TableCell>';
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadForm();

            }
        }
        void LoadForm()
        {
            Session["listImageProduct"] = "";
            drpCategory.DataSource = CategoryBLL.GetCategoryList();
            drpCategory.DataValueField = "ProductCategoryID";
            drpCategory.DataTextField = "ProductCategoryName";
            drpCategory.DataBind();
            drpColor.DataSource = ColorBLL.GetColorList();
            drpColor.DataValueField = "ColorID";
            drpColor.DataTextField = "ColorName";
            drpColor.DataBind();
            drpSize.DataSource = SizeBLL.GetSizeList();
            drpSize.DataValueField = "SizeID";
            drpSize.DataTextField = "SizeName";
            drpSize.DataBind();
            ckeDecription.ResizeEnabled = false;
            if (!String.IsNullOrEmpty(Request.QueryString["ProductID"]))
            {
                ProductDTO ProductEdit = ProductBLL.GetProductDetailWithID(int.Parse(Request.QueryString["ProductID"].ToString()));
                txtProductName.Text = ProductEdit.ProductName;
                txtProductPrice.Text = ProductEdit.ProductPrice.ToString().Trim();
                ckeDecription.Text = ProductEdit.ProductDecription;
                lbtnShowImage.Visible = false;
                Session["listImageProduct"] = ProductEdit.ProductImage;
                LoadProductImage();
                cbShow.Checked = ProductEdit.Active;
                drpCategory.SelectedValue = ProductEdit.ProductCategoryID.ToString();
                drpColor.SelectedValue = ProductEdit.ProductColorID.ToString();
                rblSex.SelectedIndex = ProductEdit.ProductSex;
                drpSize.SelectedValue = ProductEdit.ProductSizeID.ToString();
                cbContinue.Visible = false;
                cbShow.Checked = ProductEdit.Active;
                btnAddNew.Text = "Cập Nhật";
            }
            else
            {
                tblShowImage.Visible = false;
            }
        }
        private bool Active(CheckBox cb)
        {
            if (cb.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LoadProductImage()
        {
            if (!String.IsNullOrEmpty(Session["listImageProduct"].ToString()))
            {
                string[] ListImg = Session["listImageProduct"].ToString().Trim().Split('*');
                TableRow tbr = new TableRow();
            for (int i = 1; i < ListImg.Length; i++)
                {
                    TableCell tc = new TableCell();
                    Image s = new Image();
                    s.CssClass = "img-responsive";
                    s.ImageUrl = "~/Admin/IMG/ProductImage/" + ListImg[i];
                    tc.Controls.Add(s);
                    tbr.Cells.Add(tc);
                }
                tblShowImage.Rows.Add(tbr);
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["ProductID"]))
            {
                ProductDTO ProductUpdate = new ProductDTO(int.Parse(Request.QueryString["ProductID"].Trim()), txtProductName.Text.Trim(), float.Parse(txtProductPrice.Text.Trim()), Session["listImageProduct"].ToString(), ckeDecription.Text, int.Parse(drpCategory.SelectedValue.Trim()), int.Parse(rblSex.SelectedValue), int.Parse(drpSize.SelectedValue), int.Parse(drpColor.SelectedValue), Active(cbShow));
                ProductBLL.UpdateProductWithID(ProductUpdate);
                Response.Redirect("/Admin/Default.aspx?page=ManageProduct");
            }
            else
            {
                    ProductDTO ProductInsert = new ProductDTO(0, txtProductName.Text.Trim(), float.Parse(txtProductPrice.Text.Trim()), Session["listImageProduct"].ToString(), ckeDecription.Text, int.Parse(drpCategory.SelectedValue.Trim()), int.Parse(rblSex.SelectedValue), int.Parse(drpSize.SelectedValue), int.Parse(drpColor.SelectedValue), Active(cbShow));
                    ProductBLL.InsertProduct(ProductInsert);
                    Session["listImageProduct"] = "";
                    QuantityImage = 0;
                    if (!cbContinue.Checked)
                    {
                        Response.Redirect("/Admin/Default.aspx?page=ManageProduct");
                    }
                    else
                    {
                        txtProductName.Text = "";
                        txtProductPrice.Text = "";
                    }
                
            }           
        }

        protected void AfulListImage_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
        {
            string fileName = e.FileName;
            AfulListImage.SaveAs(Server.MapPath("/Admin/IMG/ProductImage/") + "HC_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + fileName);
            Session["listImageProduct"] = Session["listImageProduct"] + "*" + "HC_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + fileName;
            
        }

        protected void lbtnShowImage_Click(object sender, EventArgs e)
        {
            LoadProductImage();      
            tblShowImage.Visible = true;
        }

        protected void AfulListImage_UploadCompleteAll(object sender, AjaxControlToolkit.AjaxFileUploadCompleteAllEventArgs e)
        {
            
        }

        protected void lbtnDeleteImage_Click(object sender, EventArgs e)
        {           
            string[] ListImg = Session["listImageProduct"].ToString().Trim().Split('*');
            for (int i = 0; i < ListImg.Length; i++)
            {
                string fileName = "~/Admin/IMG/ProductImage/" + ListImg[i];
                File.Delete(Server.MapPath(fileName));
            }
            Session["listImageProduct"] = "";
            tblShowImage.Visible = false;
        }
    }
}