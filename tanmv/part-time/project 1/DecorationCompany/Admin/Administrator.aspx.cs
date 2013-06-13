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

public partial class Admin_Administrator : System.Web.UI.Page
{
    Administrator pd = new Administrator();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.LoadData();
    }

    private void LoadData()
    {
        if (Session["UsernameAdmin"] == null && Session["UsernameStaff"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            if (Session["UsernameAdmin"] != null)
            {
                lbUserName.Text = Session["UsernameAdmin"].ToString();
                DataTable dtchange = pd.getAccountByUsername(Session["UsernameAdmin"].ToString());
                Session["Role"] = dtchange.Rows[0]["RoleID"].ToString();

                if (Convert.ToInt32(Session["Role"]) == 1)
                {
                    manager_1.Visible = false;
                    manager_2.Visible = false;
                    manager_3.Visible = false;
                    manager_4.Visible = false;
                }

                if (Convert.ToInt32(Session["Role"]) == 2)
                {

                    system_li.Visible = false;
                    interface_li.Visible = false;
                    
                    manager_4.Visible = false;

                    lbtbackupDB.Enabled = false;
                    lbtRestore.Enabled = false;
                }
                if (Convert.ToInt32(Session["Role"]) == 7)
                {
                    system_li.Visible = false;
                    interface_li.Visible = false;

                    lbtbackupDB.Enabled = false;
                    lbtRestore.Enabled = false;
                    manager_1.Visible = false;
                    manager_2.Visible = false;
                    manager_3.Visible = false;
                }
            }

        }
        PlaceHolder1.Controls.Clear();

        try { 
        if (Request["page"].ToString() != null)
        {
            string sPage = Request["page"].ToString();
            Control ctrl = new Control();
            switch (sPage)
            {

                

                //Administrator
                case "admin":
                    lnkAdmin.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("AdministratorManager.ascx");
                    break;
                case "adminedit":
                    lnkAdmin.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("AdministratorEdit.ascx");
                    break;

                //Adv
                case "adv":
                    lnkAdv.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("AdvManager.ascx");
                    break;
                case "advedit":
                    lnkAdv.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("AdvEdit.ascx");
                    break;

                //Adv
                case "banner":
                    lnkBanner.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("BannerManager.ascx");
                    break;
                case "banneredit":
                    lnkBanner.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("BannerEdit.ascx");
                    break;

                //Adv
                case "news":
                    lnkNews.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("NewsManager.ascx");
                    break;
                case "newsedit":
                    lnkNews.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("NewsEdit.ascx");
                    break;
                //Product Category
                case "procat":
                    lnkProductCat.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ProductCatManager.ascx");
                    break;
                case "procatedit":
                    lnkProductCat.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ProductCatEdit.ascx");
                    break;

                //Product 
                case "pro":
                    lnkProduct.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ProductManager.ascx");
                    break;
                case "proedit":
                    lnkProduct.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ProductEdit.ascx");
                    break;

                //Category lv1
                case "lv1":
                    lnkCatLv1.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("CategoryLv1Manager.ascx");
                    break;
                case "lv1edit":
                    lnkCatLv1.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("CategoryLv1Edit.ascx");
                    break;
                //Category lv2
                case "lv2":
                    lnkCatLv2.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("CategoryLv2Manager.ascx");
                    break;
                case "lv2edit":
                    lnkCatLv2.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("CategoryLv2Edit.ascx");
                    break;
                //Staff
                case "staff":
                    lnkStaff.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("StaffManager.ascx");
                    break;
                case "staffedit":
                    lnkStaff.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("StaffEdit.ascx");
                    break;

                //Customer
                case "customer":
                    lnkCustomer.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("CustomerManager.ascx");
                    break;
                case "customeradd":
                    lnkCustomer.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("CustomerEdit.ascx");
                    break;

                    //Invoice
                case "invoice":
                    lnkInvoice.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("InvoiceManager.ascx");
                    break;

                //Invoice Details
                case "invoicedetails":
                    lnkInvoiceDetails.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("InvoiceDetailsManager.ascx");
                    break;
                case "invoicedetailsadd":
                    lnkInvoiceDetails.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("InvoiceDetailsEdit.ascx");
                    break;
                //Delivery
                case "delivery":
                    lnkDelivery.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("Delivery_InvoiceManager.ascx");
                    break;
                case "deliveryedit":
                    lnkDelivery.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("Delivery_InvoiceEdit.ascx");
                    break;

                //Report
                case "report":
                    lnkReport.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("Report.ascx");
                    break;
                case "reportorder":
                    lnkReport.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportOrder.ascx");
                    break;
                case "reportsale":
                    lnkReport.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportSale.ascx");
                    break;

                //Chart
                case "chart":
                    lnkChart.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("Charts.ascx");
                    break;
                //Chart
                case "bkup":
                    ctrl = Page.LoadControl("BackupAndRestore.ascx");
                    break;


                //Report Order
                case "rpordersl":
                    lnkDelivery.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportOrderSelect.ascx");
                    break;
                //Report Invoice
                case "rpinvoicesl":
                    lnkDelivery.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportInvoiceSelect.ascx");
                    break;
                //Report Products
                case "rpproductsl":
                    lnkReportProduct.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportProductSelect.ascx");
                    break;
                //Report Product cat
                case "rpcategorysl":
                    lnkReportProduct.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportProductCategorySelect.ascx");
                    break;
                //Report Staff
                case "rpstaffsl":
                    lnkReportProduct.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportStaffSelect.ascx");
                    break;
                //Report Customer
                case "rcustomersl":
                    lnkReportProduct.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("ReportCustomerSelect.ascx");
                    break;

                    //default
                default:
                    lnkAdmin.Attributes.Add("class", "selected");
                    ctrl = Page.LoadControl("AdministratorManager.ascx");
                    break;

            }
            PlaceHolder1.Controls.Add(ctrl);

        }
            }
        catch(Exception ex)
        {
            //lnkAdmin.Attributes.Add("class", "selected");
            //PlaceHolder1.Controls.Add(Page.LoadControl("AdministratorManager.ascx"));
        }
        
    }

    protected void lbtLogout_Click(object sender, EventArgs e)
    {
        Session["UsernameAdmin"] = null;
        Session["UsernameStaff"] = null;
        Response.Redirect("Login.aspx");
    }
    protected void lbtbackupDB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Administrator.aspx?page=bkup");
    }
    protected void lbtRestore_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Administrator.aspx?page=bkup");
    }
}