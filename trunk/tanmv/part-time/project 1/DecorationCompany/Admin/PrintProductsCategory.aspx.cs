using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_PrintProductsCategory : System.Web.UI.Page
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
       // int nProductID = 0;
        int nNumber = 0;

        string sProductCatName = "";
       // string sProductName = "";
       // string sImage = "";
       // double fPrice = 0;
        //int nStock = 0;
        int nProductCatID = 0;

        DataTable dtbOverview = new DataTable();

        dtbOverview.Columns.Add("ProductCategoryID", typeof(int));
        dtbOverview.Columns.Add("ProductCategoryName", typeof(string));
        dtbOverview.Columns.Add("Number", typeof(int));

        Invoice objInvoice = new Invoice();
        DataTable dtbInvoice = new DataTable();

        Products objProduct = new Products();
        DataTable dtbProduct = new DataTable();

        ProductCategory objProductCategory = new ProductCategory();
        DataTable dtbProductCategory = new DataTable();

        dtbInvoice = objInvoice.getReport_Product_Details_2(sFrom, sTo);

        int ncount = dtbInvoice.Rows.Count;
        for (int i = 0; i < ncount; i++)
        {
            // nProductID = Convert.ToInt32(dtbInvoice.Rows[i]["ProductID"]);
            nNumber = Convert.ToInt32(dtbInvoice.Rows[i]["Number"]);
            // dtbProduct = objProduct.LoadByID(nProductID);

            nProductCatID = Convert.ToInt32(dtbInvoice.Rows[i]["ProductCategoryID"]);

            // dtbProductCategory = objProductCategory.getByID(nProductCatID);
            sProductCatName = dtbInvoice.Rows[i]["ProductCategoryName"].ToString();

            //fPrice = Convert.ToDouble(dtbProduct.Rows[0]["Price"]);
            //sImage = dtbProduct.Rows[0]["Images"].ToString();
            //nStock = Convert.ToInt32(dtbProduct.Rows[0]["Stock"]);
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
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));

            lblProductCatID.Text = "PC-" + nID;
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