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

public partial class Admin_PrintOrderDetails : System.Web.UI.Page
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
        int nID = Convert.ToInt32(Request.QueryString["nid"]);

        Delivery_Invoice obj = new Delivery_Invoice();
        DataTable dtb = new DataTable();
        dtb = obj.getByIDInvoiceDetails(nID);
        lblStaff.Text = dtb.Rows[0]["Staff_Name"].ToString();
        lblDate.Text = dtb.Rows[0]["Date"].ToString();
        lblCodeOrder.Text = "OD-" + nID;
        string sInvoiceID = dtb.Rows[0]["InvoiceID"].ToString();
        Invoice objInvoice = new Invoice();
        dtb = objInvoice.getMultipleID(sInvoiceID);
        rptProducts.DataSource = dtb;
        rptProducts.DataBind();
    }
    protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblProductID = (Label)e.Item.FindControl("lblProductID");
            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblQuantity = (Label)e.Item.FindControl("lblQuantity");
            Label lblCategory = (Label)e.Item.FindControl("lblCategory");
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Label lblTotal = (Label)e.Item.FindControl("lblTotal");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "InvoiceID"));
            int nProductID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
            double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));
            string sCatName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));
            string sDate = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "DateBuy"));


            //lblID.Text = "PD-" + nID.ToString();
            lblProductName.Text = sProductName;
            lblPrice.Text = dPrice.ToString() + "     $ ";
            lblQuantity.Text = nStock.ToString();
            lblProductID.Text = "PD-" + nProductID;
            lblTotal.Text = Convert.ToString(dPrice * nStock) + "  $ ";
            lblCategory.Text = sCatName;
            lblDate.Text = sDate;
            fTotal += dPrice * nStock;
            lblTotalNumber.Text = "<span style=\"color:#D35638;font-weight:bold;\">" + fTotal.ToString() + " $ </span>";
        }
    }
}