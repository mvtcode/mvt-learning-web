using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_PrintInvoiceSummary : System.Web.UI.Page
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
        int nProductID = 0;
        int nNumber = 0;

        string sProductName = "";
        string sImage = "";
        double fPrice = 0;
        int nStock = 0;
        int nTockAll = 0;

        DataTable dtbOverview = new DataTable();
        dtbOverview.Columns.Add("ProductID", typeof(string));
        dtbOverview.Columns.Add("ProductName", typeof(string));
        dtbOverview.Columns.Add("Price", typeof(double));
        dtbOverview.Columns.Add("Images", typeof(string));
        dtbOverview.Columns.Add("Stock", typeof(int));

        Invoice objInvoice = new Invoice();
        DataTable dtbInvoice = new DataTable();

        Products objProduct = new Products();
        DataTable dtbProduct = new DataTable();



        dtbInvoice = objInvoice.getReport_Product_Details_3(sFrom, sTo);

        int ncount = dtbInvoice.Rows.Count;
        for (int i = 0; i < ncount; i++)
        {
            nProductID = Convert.ToInt32(dtbInvoice.Rows[i]["ProductID"]);
            nNumber = Convert.ToInt32(dtbInvoice.Rows[i]["Number"]);
            dtbProduct = objProduct.LoadByID(nProductID);
            sProductName = dtbProduct.Rows[0]["ProductName"].ToString();
            fPrice = Convert.ToDouble(dtbProduct.Rows[0]["Price"]);
            sImage = dtbProduct.Rows[0]["Images"].ToString();
            nStock = Convert.ToInt32(dtbProduct.Rows[0]["Stock"]);
            dtbOverview.Rows.Add(nProductID, sProductName, fPrice, sImage, nStock);
            nTockAll += Convert.ToInt32(dtbProduct.Rows[0]["Stock"]);
        }
        lblStockAll.Text = nTockAll.ToString();
        rptProduct.DataSource = dtbOverview;
        rptProduct.DataBind();

    }

    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Label lblStock = (Label)e.Item.FindControl("lblStock");
        Label lblProductName = (Label)e.Item.FindControl("lblProductName");

        int nStock= Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Stock"));
        string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));

        lblStock.Text = nStock.ToString();
        lblProductName.Text = sProductName;
    }
    

}