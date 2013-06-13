using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_PrintProductsCategoryDetails : System.Web.UI.Page
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

        dtbInvoice = objInvoice.getReport_Category_Details(sFrom, sTo);

        int ncount = dtbInvoice.Rows.Count;
        for (int i = 0; i < ncount; i++)
        {
            nProductCatID = Convert.ToInt32(dtbInvoice.Rows[i]["ProductCategoryID"]);
            nNumber = Convert.ToInt32(dtbInvoice.Rows[i]["Number"]);
            dtbCat = objCat.getByID(nProductCatID);

            sProductCatName = dtbCat.Rows[0]["ProductCategoryName"].ToString();

            dtbOverview.Rows.Add(nProductCatID, sProductCatName, nNumber);
        }

        rptProduct.DataSource = dtbOverview;
        rptProduct.DataBind();

    }

    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblProductCatID = (Label)e.Item.FindControl("lblProductCatID");
            Label lblProductCatName = (Label)e.Item.FindControl("lblProductCatName");
            Label lblStock = (Label)e.Item.FindControl("lblStock");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Stock"));

            lblProductCatID.Text = "C-" + nID;
            lblProductCatName.Text = sProductName;
            lblStock.Text = nStock.ToString();



        }
    }
    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void Print_Click(object sender, EventArgs e)
    {

    }
}