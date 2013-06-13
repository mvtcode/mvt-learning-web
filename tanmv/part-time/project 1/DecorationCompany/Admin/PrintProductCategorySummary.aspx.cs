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

        string sProductCatName = "";
        string sProductName = "";
        string sImage = "";
        double fPrice = 0;
        int nStock = 0;
        int nProductCatID = 0;
        int nTockAll = 0;


        DataTable dtbOverview = new DataTable();

        dtbOverview.Columns.Add("ProductCategoryID", typeof(int));
        dtbOverview.Columns.Add("ProductCategoryName", typeof(string));
        dtbOverview.Columns.Add("Stock", typeof(int));

        Invoice objInvoice = new Invoice();
        DataTable dtbInvoice = new DataTable();

        Products objProduct = new Products();
        DataTable dtbProduct = new DataTable();

        ProductCategory objCat = new ProductCategory();
        DataTable dtbCat = new DataTable();

        dtbInvoice = objInvoice.getReport_Category_Details_3(sFrom, sTo);

        int ncount = dtbInvoice.Rows.Count;
        for (int i = 0; i < ncount; i++)
        {
            nProductCatID = Convert.ToInt32(dtbInvoice.Rows[i]["ProductCategoryID"]);
            nNumber = Convert.ToInt32(dtbInvoice.Rows[i]["Number"]);
            dtbCat = objCat.getByID(nProductCatID);

            sProductCatName = dtbCat.Rows[0]["ProductCategoryName"].ToString();
            nTockAll += nNumber;

            dtbOverview.Rows.Add(nProductCatID, sProductCatName, nNumber);
        }
        lblStockAll.Text = nTockAll.ToString();
        rptProduct.DataSource = dtbOverview;
        rptProduct.DataBind();

    }

    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Label lblStock = (Label)e.Item.FindControl("lblStock");
        Label lblProducCattName = (Label)e.Item.FindControl("lblProducCattName");

        int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Stock"));
        string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));

        lblStock.Text = nStock.ToString();
        lblProducCattName.Text = sProductName;
    }
}