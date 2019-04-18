using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
namespace HUMG_Clothes.CMS.Done
{
    public partial class Done : System.Web.UI.UserControl
    {
        OrderBLL Order = new OrderBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOrder.Text = Order.GetLastOrderID().ToString().Trim();
        }
    }
}