using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.BLL;
using HUMG_Clothes.DTO;
using System.Data;
using System.Data.SqlClient;

namespace HUMG_Clothes.Admin.CMS.Products.ShowColor
{
    public partial class ShowColor : System.Web.UI.UserControl
    {
        ColorBLL ColorBLL = new ColorBLL();
        public int x = 1;
        public string ColorCode = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadColor();
            }
        }
        void loadColor()
        {
            rptColorList.DataSource = ColorBLL.GetColorList();
            rptColorList.DataBind();
        }

        protected void rptColorList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtColorName.Text.Trim()))
            {
                ColorBLL.InsertColor(new ColorDTO(0, txtColorName.Text, clColor.Color));
                loadColor();
                Response.Redirect(Request.Url.ToString());
            }
            
        }

        protected void rptColorList_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "deleteColor":
                    ColorBLL.DeteleColorWithID(int.Parse(e.CommandArgument.ToString().Trim()));
                    loadColor();
                    break;
                case "editColor":
                    ColorDTO Color = ColorBLL.GetColorDetailWithId(int.Parse(e.CommandArgument.ToString().Trim()));
                    txtColorEditID.Text = Color.ColorID.ToString().Trim();
                    txtColorNameEdit.Text = Color.ColorName.Trim();
                    clColorEdit.Color = Color.ColorCode;
                    break;
                default:
                    break;
            }
        }

        protected void clColor_ColorChanged(object sender, EventArgs e)
        {
            txtColorCode.Text = clColor.Color.ToString();
        }

        protected void btnEditColor_Click(object sender, EventArgs e)
        {
            ColorDTO Color = new ColorDTO(int.Parse(txtColorEditID.Text), txtColorNameEdit.Text.Trim(), clColorEdit.Color.ToString().Trim());
            ColorBLL.UpdateColorWithID(Color);
            loadColor();
        }
    }
}