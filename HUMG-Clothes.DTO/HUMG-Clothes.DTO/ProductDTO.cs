using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class ProductDTO
    {
        int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        float _ProductPrice;

        public float ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }
        string _ProductImage;

        public string ProductImage
        {
            get { return _ProductImage; }
            set { _ProductImage = value; }
        }
        string _ProductDecription;

        public string ProductDecription
        {
            get { return _ProductDecription; }
            set { _ProductDecription = value; }
        }
        int _ProductCategoryID;

        public int ProductCategoryID
        {
            get { return _ProductCategoryID; }
            set { _ProductCategoryID = value; }
        }
        int _ProductSex;

        public int ProductSex
        {
            get { return _ProductSex; }
            set { _ProductSex = value; }
        }
        int _ProductSizeID;

        public int ProductSizeID
        {
            get { return _ProductSizeID; }
            set { _ProductSizeID = value; }
        }
        int _ProductColorID;

        public int ProductColorID
        {
            get { return _ProductColorID; }
            set { _ProductColorID = value; }
        }
        public ProductDTO()
        {
            this.ProductColorID = 0;
            this.ProductName = "";
            this.ProductPrice = 0;
            this.ProductDecription = "";
            this.ProductCategoryID = 0;
            this.ProductSex = 0;
            this.ProductSizeID = 0;
            this.ProductID = 0;
            this.ProductImage = "";
            this._Active = false;
        }
        bool _Active;

        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
        public ProductDTO(int ProductID, string ProductName, float ProductPrice, string ProductImage, string ProductDecription, int ProductCategoryID, int ProductSex, int ProductSizeID, int ProductColorID, bool Active)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductImage = ProductImage;
            this.ProductDecription = ProductDecription;
            this.ProductCategoryID = ProductCategoryID;
            this.ProductSex = ProductSex;
            this.ProductSizeID = ProductSizeID;
            this.ProductColorID = ProductColorID;
            this.Active = Active;
        }
    }
}
