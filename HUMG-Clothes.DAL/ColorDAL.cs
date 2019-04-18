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
    public class ColorDAL : SQLDatabase
    {
        public DataTable GetColorList()
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Color");
            return GetDataTable(_sqlCom);
        }
        public void InsertColor(ColorDTO ColorDTO)
        {
            string _sqlQuery = "INSERT INTO dbo.Color VALUES (@ColorName,@ColorCode)";
            SqlCommand _sqlCom = new SqlCommand(_sqlQuery);
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@ColorName", ColorDTO.ColorName);
            _sqlCom.Parameters.AddWithValue("@ColorCode", ColorDTO.ColorCode);
            SQLDatabase.ExcuteNoneQuery(_sqlCom);
        }
        public void DeleteColorWithID(int ColorID)
        {
            SqlCommand _Sqlcom = new SqlCommand("DELETE FROM dbo.Color WHERE ColorID=@ColorID");
            _Sqlcom.CommandType = CommandType.Text;
            _Sqlcom.Parameters.AddWithValue("@ColorID",ColorID);
            SQLDatabase.ExcuteNoneQuery(_Sqlcom);
        }
        public void UpdateColorWithID(ColorDTO Color)
        {
            SqlCommand _Sqlcom = new SqlCommand("UPDATE dbo.Color SET ColorName = @ColorName, ColorCode = @ColorCode WHERE ColorID = @ColorID");
            _Sqlcom.CommandType = CommandType.Text;
            _Sqlcom.Parameters.AddWithValue("@ColorID", Color.ColorID);
            _Sqlcom.Parameters.AddWithValue("@ColorName", Color.ColorName);
            _Sqlcom.Parameters.AddWithValue("@ColorCode", Color.ColorCode);
            SQLDatabase.ExcuteNoneQuery(_Sqlcom);
        }
        public ColorDTO GetColorDetailWithId(int ColorID)
        {
            SqlCommand _Sqlcom = new SqlCommand("SELECT * FROM dbo.Color WHERE ColorID=@ColorID");
            _Sqlcom.CommandType = CommandType.Text;
            _Sqlcom.Parameters.AddWithValue("@ColorID", ColorID);
            DataTable Color = GetDataTable(_Sqlcom);
            return (new ColorDTO(ColorID, Color.Rows[0][1].ToString(), Color.Rows[0][2].ToString()));

        }
    }
}
