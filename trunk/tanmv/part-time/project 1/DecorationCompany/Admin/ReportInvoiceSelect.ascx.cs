using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ReportInvoiceSelect : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //this.BindataToRpt();
        }
    }

    protected void btOrder_Click(object sender, EventArgs e)
    {
        string sFrom = txtOrderDateFrom.Text.Trim();
        string sTo = txtOrderDateTo.Text.Trim();
        string surl = "~/Admin/PrintInvoice.aspx?datefrom=" + sFrom + "&dateto=" + sTo;
        Response.Redirect(surl);
    }

    protected void btChart_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/PrintInvoiceSummary.aspx");
    }
    private void BindataToRpt()
    {

        InvoiceDetails obj = new InvoiceDetails();
        rptInvoiceDetails.DataSource = obj.getAll();
        rptInvoiceDetails.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
      
        switch (strCommand)
        {
            case "report":

                Response.Redirect("~/Admin/PrintInvoiceDetails.aspx?nid=" + nID);
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
           

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "InvoiceDetailsID"));

            string sCustomer = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sDate = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Date_Create"));
            int nStatus = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Status"));

            lblCustomer.Text = sCustomer;
            lblDate.Text = sDate;
            if (nStatus == 0)
            { lblStatus.Text = "<span style=\"color:#06F; \">" + "Not yet approved" + "</span>"; }
            if (nStatus == 1)
            { lblStatus.Text = "<span style=\"color:#3EB437; \">" + "Agreed delivery" + "</span>"; }
            if (nStatus == 2)
            { lblStatus.Text = "<span style=\"color:#FF2525; \">" + "Not approved" + "</span>"; }

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "InvoiceDetailsID"));
             }
    }
}