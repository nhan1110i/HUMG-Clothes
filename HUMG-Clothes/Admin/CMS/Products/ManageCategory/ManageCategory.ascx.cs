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

namespace HUMG_Clothes.Admin.CMS.Products.ShowCategory
{
    public partial class ShowCategory : System.Web.UI.UserControl
    {
        CategoryBLL CategoryBLL = new CategoryBLL();
        public int x = 1;
        public string NoticeAction = " Quản lý danh mục Sản Phẩm";
        public string ClassAlert = "alert alert-info";
        public string Action = "Admin";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadProductCategory();
            }
        }
        void loadProductCategory()
        {
            rptCategoryList.DataSource = CategoryBLL.GetCategoryList();
            rptCategoryList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                CategoryDTO CategoryDTO = new CategoryDTO(txtCategoryName.Text.Trim(), 0);
                CategoryBLL.InsertCategory(CategoryDTO);
                Alert("AddCategory");
                loadProductCategory();
                Response.Redirect(Request.Url.ToString());
                
                
            }
            else
            {

            }
        }
        protected void lbtnDelete_Click(object sender, EventArgs e)
        {
        }

        protected void rptCategoryList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            CategoryDTO CategoryDTO = new CategoryDTO("", int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName.ToString())
            {
                case "deleteCategory":
                    DataTable CategoryDelte = CategoryBLL.GetCategoryWithID(CategoryDTO);
                    if (CategoryDelte.Rows.Count != 0)
                    {
                        CategoryBLL.DeleteCategoryWithID(CategoryDTO);
                        Alert("DeleteCategory");
                        loadProductCategory();
                    }
                    break;
                case "editCategory":
                    DataTable CategoryEdit = CategoryBLL.GetCategoryWithID(CategoryDTO);
                    if (CategoryEdit.Rows.Count != 0)
                    {
                        CategoryDTO CategoryEdited = CategoryBLL.GetCategoryDetailWithID(CategoryDTO.CategoryID);
                        txtCategoryNameEdit.Text = CategoryEdited.CategoryName.Trim();
                        txtCategoryIDEdit.Text = CategoryEdited.CategoryID.ToString().Trim();
                    }
                    break;
                default:
                    break;
            }
        }

        protected void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryNameEdit.Text != null)
            {
                CategoryBLL.UpdateCategoryWithID(int.Parse(txtCategoryIDEdit.Text), txtCategoryNameEdit.Text.Trim());
                loadProductCategory();
                Alert("UpdateCategory");
            }
        }
        public void Alert(string alert)
        {
            switch (alert)
            {
                case "AddCategory":
                    ClassAlert = "alert alert-success";
                    Action = "Thành công";
                    NoticeAction = " Đã thêm thành công Danh Mục";
                    break;
                case "DeleteCategory":
                    ClassAlert = "alert alert-danger";
                    Action = "Thành công";
                    NoticeAction = " Đã xóa thành công Danh Mục";
                    break;
                case "UpdateCategory":
                    ClassAlert = "alert alert-info";
                    Action = "Thành công";
                    NoticeAction = " Đã sửa thành công một Danh Mục";
                    break;
                default:
                    NoticeAction = " Quản lý danh mục Sản Phẩm";
                    ClassAlert = "alert alert-info";
                    Action = "Admin";
                    break;

            }
        }

    }
}