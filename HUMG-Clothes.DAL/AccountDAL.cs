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
    public class AccountDAL : SQLDatabase
    {
        public DataTable GetAccountList()
        {
            SqlCommand _SqlCom = new SqlCommand("SELECT * FROM dbo.Account");
            return SQLDatabase.GetDataTable(_SqlCom);
        }
        public DataTable GetAccountListWithNameAndPass(AccountDTO Account)
        {
            SqlCommand _sqlCom = new SqlCommand("SELECT * FROM dbo.Account WHERE AccountLogin=@Account AND AccountPassword=@Password");
            _sqlCom.CommandType = CommandType.Text;
            _sqlCom.Parameters.AddWithValue("@Account", Account.Accout);
            _sqlCom.Parameters.AddWithValue("@Password", Account.Password);
            return GetDataTable(_sqlCom);

        }
    }
}
