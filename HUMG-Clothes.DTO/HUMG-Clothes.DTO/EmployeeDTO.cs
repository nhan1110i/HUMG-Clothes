using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class EmployeeDTO
    {
        int _employeeID;

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        string _employeeName;

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }
        string _employeePhone;

        public string EmployeePhone
        {
            get { return _employeePhone; }
            set { _employeePhone = value; }
        }
        string _employeeCode;

        public string EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }
        string _employeeAdd;

        public string EmployeeAdd
        {
            get { return _employeeAdd; }
            set { _employeeAdd = value; }
        }
        string _employeeAccount;

        public string EmployeeAccount
        {
            get { return _employeeAccount; }
            set { _employeeAccount = value; }
        }
        string _employeePassword;

        public string EmployeePassword
        {
            get { return _employeePassword; }
            set { _employeePassword = value; }
        }
        public EmployeeDTO()
        {
            this.EmployeeID = 0;
            this.EmployeeName = "";
            this.EmployeePhone = "";
            this.EmployeeCode = "";
            this.EmployeeAdd = "";
            this.EmployeeAccount = "";
            this.EmployeePassword = "";
        }
        public EmployeeDTO(int EmployeeID,string EmployeeName, string EmployeePhone, string EmployeeCode, string EmployeeAdd, string EmployeeAccount, string EmployeePassword)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.EmployeePhone = EmployeePhone;
            this.EmployeeCode = EmployeeCode;
            this.EmployeeAdd = EmployeeAdd;
            this.EmployeeAccount = EmployeeAccount;
            this.EmployeePassword = EmployeePassword;
        }
    }
}
