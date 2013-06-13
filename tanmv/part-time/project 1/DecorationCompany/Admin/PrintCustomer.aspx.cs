using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_PrintCustomer : System.Web.UI.Page
{
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



        InvoiceDetails obj = new InvoiceDetails();
        DataTable dtb = new DataTable();
        dtb = obj.ReportbyDate_2(sFrom, sTo);

        rptProduct.DataSource = dtb;
        rptProduct.DataBind();
    }


    protected void Print_Click(object sender, EventArgs e)
    {

    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblCustomerID = (Label)e.Item.FindControl("lblCustomerID");
            Label lblCustomerName = (Label)e.Item.FindControl("lblCustomerName");
            Label lblEmail = (Label)e.Item.FindControl("lblEmail");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");
            Label lblOrderCode = (Label)e.Item.FindControl("lblOrderCode");



            int nCustomerID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "UserID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sEmail = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Email"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));
            string sAddess = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Address"));
            string sOrderCode = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "InvoiceDetailsID"));


            lblCustomerID.Text = "CT-" + nCustomerID;
            lblCustomerName.Text = sProductName;
            lblEmail.Text = sEmail;
            lblPhone.Text = sPhone;
            lblAddress.Text = sAddess;
            lblOrderCode.Text = "OD-" + sOrderCode;



        }
    }
}