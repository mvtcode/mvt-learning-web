using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_MenuLeft : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRptMenuLeft();
        }
    }


    private void BindataToRptMenuLeft()
    {
        ProductCategory pc = new ProductCategory();
        rptMenuLeft.DataSource = pc.GetAllProductCat();
        rptMenuLeft.DataBind();
    }
    protected void rptMenuLeft_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkProductCat = (HyperLink)e.Item.FindControl("lnkProductCat");
            Label lblProductCatName = (Label)e.Item.FindControl("lblProductCatName");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
            string sProductCat = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));

            lblProductCatName.Text = sProductCat;
            lnkProductCat.NavigateUrl = "~/ProductCategorys.aspx?nCat="+nID;
        }
    }
}