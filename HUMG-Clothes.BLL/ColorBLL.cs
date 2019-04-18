using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HUMG_Clothes.DTO;
using HUMG_Clothes.DAL;
using System.Data;
using System.Data.SqlClient;

namespace HUMG_Clothes.BLL
{
    public class ColorBLL
    {
        ColorDAL ColorDAL = new ColorDAL();
        public DataTable GetColorList()
        {
            return ColorDAL.GetColorList();
        }
        public ColorDTO GetColorDetailWithId(int ColorID)
        {
            return ColorDAL.GetColorDetailWithId(ColorID);
        }
        public void InsertColor(ColorDTO Color)
        {
            ColorDAL.InsertColor(Color);
        }
        public void DeteleColorWithID(int ColorID)
        {
            ColorDAL.DeleteColorWithID(ColorID);
        }
        public void UpdateColorWithID(ColorDTO Color)
        {
            ColorDAL.UpdateColorWithID(Color);
        }
    }
}
