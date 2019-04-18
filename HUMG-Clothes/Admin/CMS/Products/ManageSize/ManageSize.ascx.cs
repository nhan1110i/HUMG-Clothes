using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HUMG_Clothes.DTO;
using HUMG_Clothes.BLL;

namespace HUMG_Clothes.Admin.CMS.Products.ManageSize
{
    public partial class ManageSize : System.Web.UI.UserControl
    {
        SizeBLL SizeBLL = new SizeBLL();
        public int x = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadSizeList();
            }
            for (int i = 30; i < 120; i++)
            {
                
                ListItem liWeight = new ListItem(i.ToString() + " kg", i.ToString());
                liWeight.Value = i.ToString();
                drpBeginWeight.Items.Add(liWeight);
                drpEndWeight.Items.Add(liWeight);

            }
            for (int j = 140; j < 200; j++)
            {
                ListItem liHeight = new ListItem(j.ToString() + " cm", j.ToString());
                liHeight.Value = j.ToString();
                drpBeginHeight.Items.Add(liHeight);
                drpEndHeight.Items.Add(liHeight);
            }
        }
        void loadSizeList()
        {
            rptSizeList.DataSource = SizeBLL.GetSizeList();
            rptSizeList.DataBind();
        }

        protected void rptSizeList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString().Trim())
            {
                case "editSize":
                    SizeDTO Size = SizeBLL.GetSizeDetailWithID(int.Parse(e.CommandArgument.ToString().Trim()));
                    hfSizeID.Value = Size.SizeID.ToString().Trim();
                    txtSizeName.Text = Size.SizeName.Trim();
                    string[] AboutHeight = Size.Height.Trim().Split('-');
                    drpBeginHeight.SelectedValue = AboutHeight[0].Trim();
                    drpEndHeight.SelectedValue = AboutHeight[1].Trim();
                    string[] AboutWeight = Size.Weight.Trim().Split('-');
                    drpBeginWeight.SelectedValue = AboutWeight[0].Trim();
                    drpEndWeight.SelectedValue = AboutWeight[1].Trim();
                    break;
                default:
                    break;
            }
        }

        protected void btnEditSize_Click(object sender, EventArgs e)
        {
            string SizeHeight = drpBeginHeight.SelectedValue.ToString().Trim() + "-" + drpEndHeight.SelectedValue.ToString().Trim();
            string SizeWeight = drpBeginWeight.SelectedValue.ToString().Trim() + "-" +  drpEndWeight.SelectedValue.ToString().Trim();
            SizeDTO SizeUpdate = new SizeDTO(int.Parse(hfSizeID.Value.ToString().Trim()), txtSizeName.Text.Trim(), SizeHeight, SizeWeight);
            SizeBLL.UpdateSizeWithID(SizeUpdate);
            loadSizeList();

        }
    }
}