using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_PrintProductsDetails : System.Web.UI.Page
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

        string sNowMonth = DateTime.Now.Month.ToString();
        if (sNowMonth.Length < 2)
        {
            sNowMonth = "0" + sNowMonth;
        }
        string sDate = sNowMonth + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
        lblDateFrom.Text = sDate;
      
        int nProductID = 0;
        int nNumber = 0;

        string sProductName = "";
        string sImage = "";
        double fPrice = 0;
        int nStock = 0;

        DataTable dtbOverview = new DataTable();
        dtbOverview.Columns.Add("ProductID", typeof(string));
        dtbOverview.Columns.Add("ProductName", typeof(string));
        dtbOverview.Columns.Add("Price", typeof(double));
        dtbOverview.Columns.Add("Images", typeof(string ));
        dtbOverview.Columns.Add("Stock", typeof(int));

        Invoice objInvoice = new Invoice();
        DataTable dtbInvoice = new DataTable();

        Products objProduct = new Products();
        DataTable dtbProduct = new DataTable();

        

        dtbInvoice = objInvoice.getReport_Product_Details(sFrom, sTo);

        int ncount = dtbInvoice.Rows.Count;
        for (int i=0; i < ncount; i++)
        {
             nProductID =  Convert.ToInt32(dtbInvoice.Rows[i]["ProductID"]);
             nNumber = Convert.ToInt32(dtbInvoice.Rows[i]["Number"]);
             dtbProduct = objProduct.LoadByID(nProductID);
             sProductName = dtbProduct.Rows[0]["ProductName"].ToString();
             fPrice = Convert.ToDouble(dtbProduct.Rows[0]["Price"]);
             sImage = dtbProduct.Rows[0]["Images"].ToString();
             nStock = Convert.ToInt32( dtbProduct.Rows[0]["Stock"]);
             dtbOverview.Rows.Add(nProductID, sProductName, fPrice, sImage, nStock);
        }

        rptProduct.DataSource = dtbOverview;
        rptProduct.DataBind();

    }

    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblProductID = (Label)e.Item.FindControl("lblProductID");
            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblStock = (Label)e.Item.FindControl("lblStock");
            Image img = (Image)e.Item.FindControl("img");
        


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
          
            double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Stock"));
            string sImage = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            img.ImageUrl = "~/images/products/" + sImage;
            lblProductID.Text = "PD-" + nID;
            lblProductName.Text = sProductName;
            lblPrice.Text = dPrice.ToString() + "     $ ";
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