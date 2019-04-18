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
    public class SizeDAL : SQLDatabase
    {
        public DataTable GetSizeList()
        {
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM dbo.Size");
            return SQLDatabase.GetDataTable(sqlCom);
        }
        public SizeDTO GetSizeDetailWithID(int SizeID)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Size WHERE SizeID = @SizeID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@SizeID", SizeID);
            DataTable Size = GetDataTable(_sqlCom);
            return (new SizeDTO(SizeID, Size.Rows[0][1].ToString().Trim(),Size.Rows[0][2].ToString().Trim(),Size.Rows[0][3].ToString().Trim()));

        }
        public void UpdateSizeWithID(SizeDTO Size)
        {
            
            SqlCommand _sqlCom = new SqlCommand("UPDATE dbo.Size SET SizeName = @SizeName, Height = @Height, Weight = @Weight WHERE SizeID = @SizeID");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@SizeID", Size.SizeID);
            _sqlCom.Parameters.AddWithValue("@SizeName", Size.SizeName);
            _sqlCom.Parameters.AddWithValue("@Height", Size.Height);
            _sqlCom.Parameters.AddWithValue("@Weight", Size.Weight);
            SQLDatabase.ExcuteNoneQuery(_sqlCom);
        }
    }
}
