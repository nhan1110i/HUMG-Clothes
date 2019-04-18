using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DTO;
using HUMG_Clothes.DAL;
using System.IO;

namespace HUMG_Clothes.BLL
{
    public class ProductBLL
    {
        ProductDAL ProductDAL = new ProductDAL();
        CategoryDAL CategoryDAL = new CategoryDAL();
        ColorDAL ColorDAL = new ColorDAL();
        SizeDAL SizeDAL = new SizeDAL();
        public DataTable GetProductList()
        {
            return ProductDAL.GetProductList();
            
        }
        public DataTable GetProductListDetail()
        {
            DataTable GetProductList = ProductDAL.GetProductList();

            return EditProductList(GetProductList);
        }
        public ProductDTO GetProductDetailWithID(int ProductID)
        {
            return ProductDAL.GetProductDetailWithID(ProductID);
        }
        public void InsertProduct(ProductDTO ProductDTO)
        {
            ProductDAL.InsertProduct(ProductDTO);
        }
        public void DeleteProductWithID(int ProductID)
        {
            ProductDTO Product = GetProductDetailWithID(ProductID);
            DeleteProductImage(GetProductDetailWithID(ProductID).ProductImage.Split('*'));
            ProductDAL.DeleteProductWithID(ProductID);
        }
        public void UpdateProductWithID(ProductDTO ProductDTO)
        {
            ProductDAL.UpdateProductWithID(ProductDTO);
        }
        private string GetSex(int sex)
        {
            if (sex == 1)
            {
                return "Nữ";
            }
            else
            {
                return "Nam";
            }
        }
        public void DeleteProductImage(string[] ProductImageList)
        {
            for (int i = 1; i < ProductImageList.Length; i++)
            {
                string FilePath = @"D:/_TN94/Lập trình .NET 2/BAITAP/BTL/20181125/HUMG-Clothes/HUMG-Clothes/Admin/IMG/ProductImage/" + ProductImageList[i];
                File.Delete(FilePath);
            }
        }
        public void DeleteListProduct(string [] ListProductDelete, int CountProduct)
        {
            ProductDAL.DeleteListProduct(ListProductDelete, CountProduct);
        }
        public void ChangeActiveListProduct(int[] ListProductID, bool[] ListProductActive)
        {
            ProductDAL.ChangeActiveListProduct(ListProductID, ListProductActive);
        }
        public DataTable FilterProductWithCategoryandSex(int CategoryID, int Sex)
        {
            return EditProductList(ProductDAL.FilterProductWithCategoryandSex(CategoryID, Sex));
        }
        public DataTable GetNewProductList(int Quantity)
        {
            return EditProductList(ProductDAL.GetNewProductList(Quantity));
        }
        public DataTable GetProductListWithSex(int SexID)
        {
            return EditProductList(ProductDAL.GetProductListWithSex(SexID));
        }
        public DataTable GetProductListWithCategory(int ProductCategoryID)
        {
            return EditProductList(ProductDAL.GetProductListWithCategory(ProductCategoryID));
        }
        public DataTable FilterProductWithColorAndSex(int ColorID, int Sex)
        {
            return EditProductList(ProductDAL.FilterProductWithColorAndSex(ColorID,Sex));
        }
        public DataTable FilterProductWithPriceAndSex(int sort, int sex)
        {
            return EditProductList(ProductDAL.FilterProductWithPriceAndSex(sort,sex));
        }
        public DataTable GetProductDetailWithID2(int ProductID)
        {
            return EditProductList(ProductDAL.GetProductDetailWithID2(ProductID));
        }
        private DataTable EditProductList(DataTable GetProductList)
        {
            GetProductList.Columns.Add("ProductPriceFormatMoney",typeof(String));
            GetProductList.Columns.Add("CategoryName", typeof(String));
            GetProductList.Columns.Add("ColorCode", typeof(String));
            GetProductList.Columns.Add("SizeName", typeof(String));
            GetProductList.Columns.Add("Sex", typeof(String));
            GetProductList.Columns.Add("ImageThumbnail1", typeof(String));
            GetProductList.Columns.Add("ImageThumbnail2", typeof(String));
            GetProductList.Columns.Add("ImageThumbnail3", typeof(String)) ;
            GetProductList.Columns.Add("ImageThumbnail4", typeof(String));
            GetProductList.Columns.Add("ImageThumbnail5", typeof(String));
            GetProductList.Columns.Add("PriceFake", typeof(String));

            for (int i = 0; i < GetProductList.Rows.Count; i++)
            {
                string[] ImageThumbnailList = GetProductList.Rows[i]["ProductImage"].ToString().Trim().Split('*');
                GetProductList.Rows[i]["ImageThumbnail1"] = ImageThumbnailList[1];
                GetProductList.Rows[i]["ImageThumbnail2"] = ImageThumbnailList[2];
                GetProductList.Rows[i]["ImageThumbnail3"] = ImageThumbnailList[3];
                GetProductList.Rows[i]["ImageThumbnail4"] = ImageThumbnailList[4];
                GetProductList.Rows[i]["ImageThumbnail5"] = ImageThumbnailList[5];
                GetProductList.Rows[i]["ProductPriceFormatMoney"] = String.Format("{0:0,0}", GetProductList.Rows[i]["ProductPrice"]);
                GetProductList.Rows[i]["Sex"] = GetSex(int.Parse(GetProductList.Rows[i]["ProductSex"].ToString().Trim()));
                GetProductList.Rows[i]["CategoryName"] = CategoryDAL.GetCategoryDetailWithID(int.Parse(GetProductList.Rows[i]["ProductCategoryID"].ToString().Trim())).CategoryName;
                GetProductList.Rows[i]["ColorCode"] = ColorDAL.GetColorDetailWithId(int.Parse(GetProductList.Rows[i]["ProductColorID"].ToString().Trim())).ColorCode;
                GetProductList.Rows[i]["SizeName"] = SizeDAL.GetSizeDetailWithID(int.Parse(GetProductList.Rows[i]["ProductSizeID"].ToString().Trim())).SizeName;
                GetProductList.Rows[i]["PriceFake"] = (float.Parse(GetProductList.Rows[i]["ProductPrice"].ToString().Trim()) * 1.1).ToString();
            }
            return GetProductList;
        }
        public DataTable GetCart(string[] arrProductID, string[] arrQuantity)
        {
            return ProductDAL.GetCart(arrProductID, arrQuantity);
        }
    }
}
