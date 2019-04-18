using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class AccountDTO
    {
        string _Accout;

        public string Accout
        {
            get { return _Accout; }
            set { _Accout = value; }
        }
        string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public AccountDTO()
        {
            Accout = Password = "";
        }
        public AccountDTO(string Account, string Password)
        {
            this.Password = Password;
            this.Accout = Account;
        }
    }
}
