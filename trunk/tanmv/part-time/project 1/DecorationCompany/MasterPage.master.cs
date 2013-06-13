using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRptBannerLeft();
            this.BindataToRptBannerRight();
        }
    }

    private void BindataToRptBannerRight()
    {
        int nCat = 6;
        Adv pc = new Adv();
        RptBannerRight.DataSource = pc.getByCategoryID(nCat);
        RptBannerRight.DataBind();
    }

    private void BindataToRptBannerLeft()
    {
        int nCat = 2;
        Adv pc = new Adv();
        RptBannerLeft.DataSource = pc.getByCategoryID(nCat);
        RptBannerLeft.DataBind();
    }
    protected void BannerLeft_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkimg = (HyperLink)e.Item.FindControl("lnkimg");
            Image img = (Image)e.Item.FindControl("img");



            string sImages = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            string sUrl = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "URL"));

            lnkimg.NavigateUrl = sUrl;
            img.ImageUrl = "~/images/Adv/" + sImages;
        }
    }
    protected void RptBannerRight_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkimg = (HyperLink)e.Item.FindControl("lnkimg");
            Image img = (Image)e.Item.FindControl("img");



            string sImages = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            string sUrl = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "URL"));

            lnkimg.NavigateUrl = sUrl;
            img.ImageUrl = "~/images/Adv/" + sImages;
        }
    }
}
