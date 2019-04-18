using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DTO;
using HUMG_Clothes.DAL;

namespace HUMG_Clothes.BLL
{
    public class AccountBLL : Cryptography
    {
        AccountDAL AccountDAL = new AccountDAL();
        public DataTable GetAccountList()
        {
            return AccountDAL.GetAccountList();
        }
        public AccountDTO Cryptography(AccountDTO Account){
            AccountDTO AccountCryp = new AccountDTO(Account.Accout, CryptographyString(Account.Password));
            return AccountCryp;
        }
        public bool CheckLogin(AccountDTO Account)
        {
            if (AccountDAL.GetAccountListWithNameAndPass(Cryptography(Account)).Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
