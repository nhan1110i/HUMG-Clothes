using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HUMG_Clothes.DTO;
using HUMG_Clothes.DAL;
namespace HUMG_Clothes.BLL
{
    public class DiscountCodeBLL
    {
        DiscountCodeDAL Discount = new DiscountCodeDAL();
        public DiscountCodeDTO GetDiscountCodeDetailWithID(int DiscountCodeID)
        {
            return Discount.GetDiscountCodeDetailWithID(DiscountCodeID);
        }
    }
}
