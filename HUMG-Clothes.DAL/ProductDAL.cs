using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes.DAL
{
    public class ProductDAL : SQLDatabase
    {
        public DataTable GetProductList()
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product ORDER BY ProductID DESC");
            return GetDataTable(_sqlCom);
        }
        public void InsertProduct(ProductDTO Product)
        {
            SqlCommand _sqlCom = new SqlCommand("INSERT INTO dbo.Product VALUES (@ProductName,@ProductPrice,@ProductImage,@ProductDecription,@ProductCategoryID,@ProductSex,@ProductSizeID,@ProductColorID,@ProductActive)");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductName", Product.ProductName);
            _sqlCom.Parameters.AddWithValue("@ProductPrice", Product.ProductPrice);
            _sqlCom.Parameters.AddWithValue("@ProductImage", Product.ProductImage);
            _sqlCom.Parameters.AddWithValue("@ProductDecription", Product.ProductDecription);
            _sqlCom.Parameters.AddWithValue("@ProductCategoryID", Product.ProductCategoryID);
            _sqlCom.Parameters.AddWithValue("@ProductSex", Product.ProductSex);
            _sqlCom.Parameters.AddWithValue("@ProductSizeID", Product.ProductSizeID);
            _sqlCom.Parameters.AddWithValue("@ProductColorID", Product.ProductColorID);
            _sqlCom.Parameters.AddWithValue("@ProductActive", Product.Active);
            ExcuteNoneQuery(_sqlCom);
        }
        public ProductDTO GetProductDetailWithID(int ProductID)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductID = @ProductID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductID",ProductID);
            DataTable Product = GetDataTable(_sqlCom);
           return (new ProductDTO(ProductID,Product.Rows[0]["ProductName"].ToString().Trim(),float.Parse(Product.Rows[0]["ProductPrice"].ToString().Trim()),Product.Rows[0]["ProductImage"].ToString(),Product.Rows[0]["ProductDecription"].ToString().Trim(),int.Parse(Product.Rows[0]["ProductCategoryID"].ToString().Trim()),int.Parse(Product.Rows[0]["ProductSex"].ToString().Trim()),int.Parse(Product.Rows[0]["ProductSizeID"].ToString().Trim()),int.Parse(Product.Rows[0]["ProductColorID"].ToString().Trim()),getTrueFalse(Product.Rows[0]["ProductActive"].ToString().Trim())));
        }
        public DataTable GetProductDetailWithID2(int ProductID)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductID = @ProductID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductID", ProductID);
            return GetDataTable(_sqlCom);
        }
        public bool getTrueFalse(string tp)
        {
            if (tp == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteProductWithID(int ProductID)
        {
            SqlCommand _sqlCom = new SqlCommand("DELETE dbo.Product WHERE ProductID = @ProductID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductID", ProductID);
            ExcuteNoneQuery(_sqlCom);
        }
        public void UpdateProductWithID(ProductDTO Product)
        {
            SqlCommand _sqlCom = new SqlCommand("UPDATE dbo.Product SET ProductName =@ProductName, ProductPrice = @ProductPrice,ProductImage = @ProductImage,ProductDecription = @ProductDecription,ProductCategoryID = @ProductCategoryID, ProductSex = @ProductSex, ProductSizeID = @ProductSizeID, ProductColorID = @ProductColorID, ProductActive = @ProductActive WHERE ProductID = @ProductID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductID", Product.ProductID);
            _sqlCom.Parameters.AddWithValue("@ProductName", Product.ProductName);
            _sqlCom.Parameters.AddWithValue("@ProductPrice", Product.ProductPrice);
            _sqlCom.Parameters.AddWithValue("@ProductImage", Product.ProductImage);
            _sqlCom.Parameters.AddWithValue("@ProductDecription", Product.ProductDecription);
            _sqlCom.Parameters.AddWithValue("@ProductCategoryID", Product.ProductCategoryID);
            _sqlCom.Parameters.AddWithValue("@ProductSex", Product.ProductSex);
            _sqlCom.Parameters.AddWithValue("@ProductSizeID", Product.ProductSizeID);
            _sqlCom.Parameters.AddWithValue("@ProductColorID", Product.ProductColorID);
            _sqlCom.Parameters.AddWithValue("@ProductActive", Product.Active);
            ExcuteNoneQuery(_sqlCom);
        }
        public void DeleteListProduct(string [] ListProductID, int CountProduct)
        {
            for (int i = 0; i < CountProduct; i++)
            {
                DeleteProductWithID(int.Parse(ListProductID[i].Trim()));
            }
        }
        public void ChangeActiveListProduct(int [] ListProductID, bool [] ListActiveProduct)
        {
            for (int i = 1; i < ListProductID.Length; i++)
            {
                SqlCommand _sqlCom = new SqlCommand("UPDATE dbo.Product SET ProductActive =@ProductActive WHERE ProductID =@ProductID");
                _sqlCom.CommandType = CommandType.Text;
                _sqlCom.Parameters.AddWithValue("@ProductActive", ListActiveProduct[i]);
                _sqlCom.Parameters.AddWithValue("@ProductID", ListProductID[i]);
                ExcuteNoneQuery(_sqlCom);
            }
        }
        public DataTable SearchProductWithProductName(string ProductName)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * dbo.Product WHERE ProductName LIKE @ProductName");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductName", ProductName);
            return GetDataTable(_sqlCom);
        }
        public DataTable FilterProductWithCategoryandSex(int CategoryID, int Sex) //gender
        {
            if (CategoryID != 0 && Sex == 3)
            {
                SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductCategoryID=@CategoryID");
                _sqlCom.CommandType = CommandType.Text;
                _sqlCom.Parameters.AddWithValue("@CategoryID", CategoryID);
                return GetDataTable(_sqlCom);
            }
            if (CategoryID == 0 && Sex != 3)
             {
                 SqlCommand _sqlcom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductSex = @Sex");
                 _sqlcom.CommandType = CommandType.Text;
                 _sqlcom.Parameters.AddWithValue("@Sex", Sex);
                 return GetDataTable(_sqlcom);
             }
            if (CategoryID != 0 && Sex != 3)
            {
                SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductCategoryID=@CategoryID AND ProductSex = @Sex");
                _sqlCom.CommandType = CommandType.Text;
                _sqlCom.Parameters.AddWithValue("@CategoryID", CategoryID);
                _sqlCom.Parameters.AddWithValue("@Sex", Sex);
                return GetDataTable(_sqlCom);
            }
            else
            {
                return GetProductList();
            }
        }
        public DataTable GetProductListWithCategory(int ProductCategoryID)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductCategoryID = @ProductCategoryID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
            return GetDataTable(_sqlCom);
        }
        public DataTable FilterProduct(string ProductName, string ProductCategory, int ProductSex)
        {
            DataTable ProductListResult = GetProductList();
            return ProductListResult;
        }
        // Home
        public DataTable GetNewProductList(int QuantityProduct)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT TOP(@QuantityProduct) * FROM dbo.Product ORDER BY ProductID DESC");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@QuantityProduct", QuantityProduct);
            return GetDataTable(_sqlCom);
        }
        public DataTable GetProductListWithSex(int SexID)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductSex = @SexID AND ProductActive = @ProductActive");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@SexID", SexID);
            _sqlCom.Parameters.AddWithValue("@ProductActive", true);
            return GetDataTable(_sqlCom);
        }
        public DataTable FilterProductWithColorAndSex(int ColorID, int Sex)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductColorID = @ColorID AND ProductSex = @Sex");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("ColorID",ColorID);
            _sqlCom.Parameters.AddWithValue("@Sex", Sex);
            return GetDataTable(_sqlCom);
        }
        public DataTable FilterProductWithPriceAndSex(int sort, int sex)
        {
            if (sort == 1)
            {
                SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductSex = @Sex ORDER BY ProductPrice ASC");
                _sqlCom.CommandType = CommandType.Text;
                _sqlCom.Parameters.AddWithValue("@Sex",sex);
                return GetDataTable(_sqlCom);
            }
            else
            {
                if (sort == 2)
                {
                    SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Product WHERE ProductSex = @Sex ORDER BY ProductPrice DESC");
                     _sqlCom.CommandType = CommandType.Text;
                _sqlCom.Parameters.AddWithValue("@Sex",sex);
                    return GetDataTable(_sqlCom);
                }
                else
                {
                    return FilterProductWithCategoryandSex(0, sex);
                }
            }
        }
        public DataTable GetCart(string[] arrProductID, string[] arrQuantity)
        {
            DataTable Cart = new DataTable();
            Cart.Columns.Add("ProductID",typeof(String));
            Cart.Columns.Add("ProductName", typeof(String));
            Cart.Columns.Add("ProductPrice", typeof(String));
            Cart.Columns.Add("ProductQuantity", typeof(String));
            Cart.Columns.Add("Money", typeof(String));
            Cart.Columns.Add("FormatMoney", typeof(String));
            Cart.Columns.Add("Img", typeof(String));
            for (int i = 0; i < arrProductID.Length; i++)
            {
                ProductDTO Product = GetProductDetailWithID(int.Parse(arrProductID[i].Trim()));
                DataRow row = Cart.NewRow();
                row[0] = Product.ProductID.ToString();
                row[1] = Product.ProductName.Trim();
                row[2] = Product.ProductPrice.ToString().Trim();
                row[3] = arrQuantity[i];
                row[4] = (Product.ProductPrice * int.Parse(arrQuantity[i])).ToString().Trim();
                row[5] = String.Format("{0:0,0}", (Product.ProductPrice * int.Parse(arrQuantity[i])).ToString().Trim());
                row[6] = Product.ProductImage.ToString().Split('*')[1];
                Cart.Rows.Add(row);
            }
            return Cart;
        }
    }
}
