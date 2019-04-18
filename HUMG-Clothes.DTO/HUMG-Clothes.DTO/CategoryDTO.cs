using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class CategoryDTO
    {
        int _CategoryID;

        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
        string _CategoryName;

        public string CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }
        public CategoryDTO()
        {
            this.CategoryName = "";
            this.CategoryID = 0;
        }
        public CategoryDTO(string CategoryName,int CategoryID)
        {
            this.CategoryName = CategoryName;
            this.CategoryID = CategoryID;
        }
    }
}
