using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class New : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRpt();
        }
    }
    private void BindataToRpt()
    {
        News pc = new News();
        rptNews.DataSource = pc.getAll();
        rptNews.DataBind();
    }

    protected void rptNews_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkimg = (HyperLink)e.Item.FindControl("lnkimg");
            Image img = (Image)e.Item.FindControl("img");
            HyperLink lnkName = (HyperLink)e.Item.FindControl("lnkName");
            Label lblInit = (Label)e.Item.FindControl("lblInit");
            //HyperLink lnkDetails = (HyperLink)e.Item.FindControl("lnkDetails");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "NewID"));
            string sImages = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Name"));
            string sInit = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "InitContent"));


            string sUrl = "~/NewsDetails.aspx?nid=" + nID;

            lnkimg.NavigateUrl = sUrl;
            img.ImageUrl = "~/images/News/" + sImages;
            //lnkDetails.NavigateUrl = sUrl;
            lnkName.Text = sName;
            lnkName.NavigateUrl = sUrl;
            lblInit.Text = sInit;
         
        }
    }
}