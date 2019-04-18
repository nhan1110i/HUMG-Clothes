using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DTO;
using HUMG_Clothes.DAL;

namespace HUMG_Clothes.BLL
{
    public class CategoryBLL
    {
        CategoryDAL CategoryDAL = new CategoryDAL();

        public DataTable GetCategoryList()
        {

            return CategoryDAL.GetCategoryList();
        }
        public DataTable GetCategoryWithID(CategoryDTO Category)
        {
            return CategoryDAL.GetCategoryListWithID(Category);
        }
        public void InsertCategory(CategoryDTO Category)
        {
            CategoryDAL.InsertCategory(Category);
        }
        public CategoryDTO GetCategoryDetailWithID(int CategoryID)
        {
            DataTable dt = GetCategoryWithID(new CategoryDTO("", CategoryID));
            return (new CategoryDTO(dt.Rows[0]["ProductCategoryName"].ToString(), CategoryID));
        }
        public void DeleteCategoryWithID(CategoryDTO Category)
        {
            CategoryDAL.DeleteCategoryWithID(Category);
        }
        public void UpdateCategoryWithID(int CategoryID, string CategoryName)
        {
            CategoryDAL.UpdateCategoryWithID(CategoryID, CategoryName);
        }
    }
}
