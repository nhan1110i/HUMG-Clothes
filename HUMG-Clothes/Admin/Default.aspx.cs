using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HUMG_Clothes.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CheckLoginAdmin"] != null)
            {
                plLoadAdminControl.Controls.Add(LoadControl("AdminControl.ascx"));
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["CheckLogin"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}