using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_NivoSlider : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRptSlide();
        }
    }
    private void BindataToRptSlide()
    {
        int nCat = 4;
        Banner pc = new Banner();
        rptSlide.DataSource = pc.getByCategoryID(nCat);
        rptSlide.DataBind();
    }
    protected void rptSlide_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkimg = (HyperLink)e.Item.FindControl("lnkimg");
            Image img = (Image)e.Item.FindControl("img");



            string sImages = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            string sUrl = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "URL"));

            lnkimg.NavigateUrl = sUrl;
            img.ImageUrl = "~/images/Banner/" + sImages;
        }
    }
}