using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using HUMG_Clothes.BLL;
using HUMG_Clothes.DTO;

namespace HUMG_Clothes
{
    public partial class Home1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            plHome.Controls.Add(LoadControl("ClientControl.ascx"));
        }

    }
}