using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

using System.Text;
using System.IO;

public partial class PrintOrder : System.Web.UI.Page
{
    double fTotal = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.LoadData();
        }
    }
    private void LoadData()
    {
        string sFrom = Request.QueryString["datefrom"].ToString();
        string sTo = Request.QueryString["dateto"].ToString();
        lblDateFrom.Text = sFrom;
        lblDateTo.Text = sTo;
        Delivery_Invoice obj = new Delivery_Invoice();
        DataTable dtb = new DataTable();
        dtb = obj.ReportbyDate(sFrom, sTo);
        rptReportOrder.DataSource = dtb;
        rptReportOrder.DataBind();

    }

    protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            //Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblCustomerName = (Label)e.Item.FindControl("lblCustomerName");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");
            Label StaffName = (Label)e.Item.FindControl("StaffName");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "InvoiceDetailsID"));

            string sCustomertName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));
            string sAddress = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Address"));
            string sStaff = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Staff_Name"));
            

            lblID.Text ="OD-"+ nID.ToString();
            lblCustomerName.Text = sCustomertName.ToString();
            lblPhone.Text = sPhone;
            lblAddress.Text = sAddress;
            StaffName.Text = sStaff;
            
        }
    }
}