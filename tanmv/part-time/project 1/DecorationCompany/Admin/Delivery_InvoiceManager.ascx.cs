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

        Delivery_Invoice obj = new Delivery_Invoice();
        rptDelivery.DataSource = obj.getAll();
        rptDelivery.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Delivery_Invoice obj = new Delivery_Invoice();
        switch (strCommand)
        {
            case "Delete":

                int nDelete = obj.delete(nID);
                this.BindataToRpt();
                break;
            case "Edit":
                string sEdit = "~/Admin/Administrator.aspx?page=deliveryedit&action=edit&nid=" + nID;
                Response.Redirect(sEdit);
                break;
          
        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblCustomer = (Label)e.Item.FindControl("lblCustomer");


            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Label lblStatus = (Label)e.Item.FindControl("lblStatus");
            

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Delivery_InvoiceID"));

            string sCustomer = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sDate = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Date"));
            int nStatus = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Delivery_Status"));

            lblCustomer.Text = sCustomer;
            lblDate.Text = sDate;
            if (nStatus == 0)
            { lblStatus.Text = "<span style=\"color:#06F; \">" + "Not yet approved" + "</span>"; }
            if (nStatus == 1)
            { lblStatus.Text = "<span style=\"color:#3EB437; \">" + "Done" + "</span>"; }
          

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Delivery_InvoiceID"));
            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Delivery_InvoiceID"));
        }
    }
  
}