using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_BannerManager : System.Web.UI.UserControl
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

        Invoice obj = new Invoice();
        rptInvoice.DataSource = obj.getAll();
        rptInvoice.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Invoice obj = new Invoice();
        switch (strCommand)
        {
            case "Delete":

                int nDelete = obj.delete(nID);
                this.BindataToRpt();
                break;

          
        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblProduct = (Label)e.Item.FindControl("lblProduct");

            Image imgProduct = (Image)e.Item.FindControl("imgProduct");
            Label lblNumber = (Label)e.Item.FindControl("lblNumber");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "InvoiceID"));
            
            string sProductname = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
            string sImages = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            int nNumber = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));
            string sPrice = DataBinder.Eval(e.Item.DataItem, "Price").ToString();
            string sDate = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "DateBuy"));

            imgProduct.ImageUrl = "~/images/products/" + sImages;
            lblProduct.Text = sProductname;
            lblPrice.Text = sPrice + " $ ";
            lblNumber.Text = nNumber.ToString();
            lblDate.Text = sDate;

            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "InvoiceID"));
        }
    }
  
}