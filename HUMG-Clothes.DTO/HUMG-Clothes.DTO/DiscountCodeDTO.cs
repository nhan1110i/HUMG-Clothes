using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class DiscountCodeDTO
    {
        int _DiscountCodeID;

        public int DiscountCodeID
        {
            get { return _DiscountCodeID; }
            set { _DiscountCodeID = value; }
        }
        string _Code;

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        int _DiscountPercent;

        public int DiscountPercent
        {
            get { return _DiscountPercent; }
            set { _DiscountPercent = value; }
        }
        public DiscountCodeDTO()
        {
            this.DiscountCodeID = this.DiscountPercent = 0;
            this.Code = "";
        }
        public DiscountCodeDTO(int DiscountCodeID, string Code, int DiscountPercent)
        {
            this.DiscountCodeID = DiscountCodeID;
            this.Code = Code;
            this.DiscountPercent = DiscountPercent;
        }
    }
}
