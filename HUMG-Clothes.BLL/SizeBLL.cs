using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HUMG_Clothes.DAL;
using HUMG_Clothes.DTO;
using System.Data;
using System.Data.SqlClient;
namespace HUMG_Clothes.BLL
{
    public class SizeBLL
    {
        SizeDAL SizeDAL = new SizeDAL();
        public DataTable GetSizeList()
        {
            return SizeDAL.GetSizeList();
        }
        public SizeDTO GetSizeDetailWithID(int SizeID)
        {
            return SizeDAL.GetSizeDetailWithID(SizeID);
        }
        public void UpdateSizeWithID(SizeDTO Size)
        {
            SizeDAL.UpdateSizeWithID(Size);
        }
    }
}
