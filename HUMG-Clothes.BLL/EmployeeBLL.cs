using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.DAL;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes.BLL
{
    public class EmployeeBLL : Cryptography
    {
        EmployeeDAL Employee = new EmployeeDAL();
        public DataTable GetEmployeeList()
        {
            return Employee.GetEmployeeList();
        }
        public EmployeeDTO GetEmployeeDetailWithID(int EmployeeID)
        {
            return Employee.GetEmployeeDetailWithID(EmployeeID);
        }
        public DataTable GetIDEmployeeWithAccountAndPassword(string Account, string Password)
        {
            return Employee.GetEmployeeListWithAccountAndPassword(Account, Password);
        }
        public bool CheckLogin(EmployeeDTO EmployeeCheckLogin)
        {
            if (Employee.GetEmployeeListWithAccountAndPassword(EmployeeCheckLogin.EmployeeAccount.ToString().Trim(), CryptographyString(EmployeeCheckLogin.EmployeePassword.ToString().Trim())).Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public EmployeeDTO Cryptography(EmployeeDTO Employee)
        {
            EmployeeDTO EmployeeCrypt = new EmployeeDTO(Employee.EmployeeID,Employee.EmployeeName, Employee.EmployeePhone, Employee.EmployeeCode, Employee.EmployeeAdd, Employee.EmployeeAdd, CryptographyString(Employee.EmployeePassword.Trim()));
            return EmployeeCrypt;
        }
    }
}
