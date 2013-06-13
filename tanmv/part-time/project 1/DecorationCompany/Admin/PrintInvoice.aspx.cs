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

public partial class Admin_PrintInvoice : System.Web.UI.Page
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
        Invoice objInvoice = new Invoice();
        DataTable dtb = new DataTable();
        dtb = objInvoice.ReportByDate(sFrom, sTo);
        rptReportOrder.DataSource = dtb;
        rptReportOrder.DataBind();

    }

   


    protected void rptListProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblProductID = (Label)e.Item.FindControl("lblProductID");
            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblProductCat = (Label)e.Item.FindControl("lblProductCat");
            Label lblQuantity = (Label)e.Item.FindControl("lblQuantity");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Label lblTotal = (Label)e.Item.FindControl("lblTotal");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "InvoiceID"));
            int nProductID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
            string sCatName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));
            string sDate = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "DateBuy"));
            double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
            double dTotal = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Total"));
            int nQuantity = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));

            lblID.Text = nID.ToString();
            lblProductID.Text = "PD-" + nProductID.ToString();
            lblProductName.Text = sProductName;
            lblProductCat.Text = sCatName;
            lblDate.Text = sDate;
            lblPrice.Text = dPrice.ToString() + "     $ ";
            lblQuantity.Text = nQuantity.ToString();
            double dTotal_round = Math.Round(dTotal, 2, MidpointRounding.AwayFromZero);
            lblTotal.Text = dTotal_round.ToString() + " $ ";
            fTotal += dPrice * nQuantity;

            lblTotalNumber.Text = "<span style=\"color:#D35638;font-weight:bold;\">" + fTotal.ToString() + " $ </span>";
        }
    }
}