using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HUMG_Clothes.DTO;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.DAL
{
    public class CategoryDAL : SQLDatabase
    {
        public DataTable GetCategoryList()
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Category");
            return GetDataTable(_sqlCom);
        }
        public DataTable GetCategoryListWithID(CategoryDTO Category)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Category WHERE ProductCategoryID=@CategoryID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@CategoryID", Category.CategoryID);
            return GetDataTable(_sqlCom);
        }
        public CategoryDTO GetCategoryDetailWithID(int CategoryID)
        {
            DataTable dt = GetCategoryListWithID(new CategoryDTO("",CategoryID));
            return (new CategoryDTO(dt.Rows[0][1].ToString(),CategoryID));
        }
        public void InsertCategory(CategoryDTO Category)
        {
            string _sqlQuery = "INSERT INTO dbo.Category VALUES (@CategoryName)";
            SqlCommand _sqlCom = new SqlCommand(_sqlQuery);
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@CategoryName", Category.CategoryName);
            ExcuteNoneQuery(_sqlCom);
        }
        public void DeleteCategoryWithID(CategoryDTO Category)
        {
            SqlCommand _Sqlcom = new SqlCommand("DELETE FROM dbo.Category WHERE ProductCategoryID=@CategoryID");
            _Sqlcom.CommandType = CommandType.Text;
            _Sqlcom.Parameters.AddWithValue("@CategoryID", Category.CategoryID);
            ExcuteNoneQuery(_Sqlcom);
        }
        public void UpdateCategoryWithID(int CategoryID,string CategoryName)
        {
            SqlCommand _SqlCom = new SqlCommand("UPDATE dbo.Category SET ProductCategoryName = @CategoryName WHERE ProductCategoryID = @CategoryID");
            _SqlCom.CommandType = CommandType.Text;
            _SqlCom.Parameters.AddWithValue("@CategoryName", CategoryName);
            _SqlCom.Parameters.AddWithValue("@CategoryID", CategoryID);
            ExcuteNoneQuery(_SqlCom);
        }
    }
}
