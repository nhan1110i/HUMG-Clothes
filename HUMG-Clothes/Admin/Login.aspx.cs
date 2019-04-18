using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        AccountBLL AccountBLL = new AccountBLL();
        EmployeeBLL EmployeeBLL = new EmployeeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Trim() == "admin")
            {
                if (AccountBLL.CheckLogin(new AccountDTO(txtAccount.Text.Trim(), txtPassword.Text.Trim())))
                {
                    Session["CheckLoginAdmin"] = txtAccount.Text.ToString().Trim();
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblWrongPass.Text = "Sai tên đăng nhập hoặc mật khẩu";   
                }
            }
            else
            {
                EmployeeDTO EmployeeCheckLogin = new EmployeeDTO(0, "", "", "", "", txtAccount.Text.Trim(), txtPassword.Text.Trim());
                if (EmployeeBLL.CheckLogin(EmployeeCheckLogin))
                {
                    Session["CheckLoginEmployee"] = txtPassword.Text;
                    Response.Redirect("SellOnStore.aspx");
                }
                else
                {
                    lblWrongPass.Text = "Sai tên đăng nhập hoặc mật khẩu";
                }
            }
            
        }
    }
}