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
    public class EmployeeDAL : SQLDatabase
    {
        public DataTable GetEmployeeList()
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Employee");
            return GetDataTable(_sql);
        }
        public EmployeeDTO GetEmployeeDetailWithID(int EmployeeID)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Employee WHERE EmployeeID = @EmployeeID");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            DataTable EmployeeData = GetDataTable(_sql);
            EmployeeDTO Employee = new EmployeeDTO(EmployeeID, EmployeeData.Rows[0]["EmployeeName"].ToString().Trim(), EmployeeData.Rows[0]["EmployeePhone"].ToString().Trim(), EmployeeData.Rows[0]["EmployeeCode"].ToString().Trim(), EmployeeData.Rows[0]["EmployeeAdd"].ToString().Trim(), EmployeeData.Rows[0]["EmployeeAccount"].ToString().Trim(), EmployeeData.Rows[0]["EmployeePassword"].ToString().Trim());
            return Employee;
        }
        public DataTable GetEmployeeListWithAccountAndPassword(string Account, string Password)
        {
            SqlCommand _sql = new SqlCommand("SELECT * FROM dbo.Employee WHERE EmployeeAccount =@EmployeeAccount AND EmployeePassword =@EmployeePassword");
            _sql.CommandType = CommandType.Text;
            _sql.Parameters.AddWithValue("@EmployeeAccount", Account);
            _sql.Parameters.AddWithValue("@employeePassword", Password);
            return GetDataTable(_sql);
        }

    }
}
