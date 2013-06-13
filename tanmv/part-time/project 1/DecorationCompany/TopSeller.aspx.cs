using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TopSeller : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRptProductCat();
        }
    }

    private void BindataToRptProductCat()
    {
        int nCat = Convert.ToInt32(Request.QueryString["nCat"]);
        Products pc = new Products();
        rptBestSeller.DataSource = pc.getTop10();
        rptBestSeller.DataBind();
    }
    protected void rptBestSeller_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkimg = (HyperLink)e.Item.FindControl("lnkimg");
            Image img = (Image)e.Item.FindControl("img");
            HyperLink lnkProductName = (HyperLink)e.Item.FindControl("lnkProductName");
            Label lblInit = (Label)e.Item.FindControl("lblInit");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            LinkButton lbtAddtoCard = (LinkButton)e.Item.FindControl("lbtAddtoCard");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            string sImages = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
            double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Stock"));
            string sInit = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "InitContent"));
            if (sInit.Length > 100)
            { sInit = sInit.Substring(0, 100) + "..."; }

            string sUrl = "~/ProductDetail.aspx?nid=" + nID;

            lnkimg.NavigateUrl = sUrl;
            img.ImageUrl = "~/images/products/" + sImages;
            lnkProductName.Text = sProductName;
            lnkProductName.NavigateUrl = sUrl;
            lblInit.Text = sInit;
            lblPrice.Text = " $ " + dPrice;

            lbtAddtoCard.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductID"));
        }
    }
    protected void rptBestSeller_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Products pro = new Products();
        DataTable dtb = pro.LoadByID(nID);
        string sProductName = dtb.Rows[0]["ProductName"].ToString();
        string sPrice = dtb.Rows[0]["Price"].ToString();
        string sImages = dtb.Rows[0]["Images"].ToString();
        switch (strCommand)
        {
            case "AddCart":
                try
                {
                    this.CreateCart();
                    DataTable dt = (DataTable)Session["giohang"];
                    DataRow dr = dt.Rows.Find(nID);
                    if (dr == null)
                    {
                        dr = dt.NewRow();
                        dr["ID"] = nID;
                        dr["Name"] = sProductName;
                        dr["Price"] = float.Parse("0" + sPrice);
                        dr["Number"] = 1;
                        dr["Image"] = sImages;
                        dt.Rows.Add(dr);
                    }
                    else
                    {
                        dr["Number"] = int.Parse(dr["Number"].ToString()) + 1;
                    }
                    Response.Redirect("Shopping.aspx");
                }
                catch (Exception ex)
                {
                    //Response.Write("Erorr: " + ex.Message);
                }
                break;

        }
    }
    private void CreateCart()
    {
        if (Session["giohang"] != null)
            return;

        DataTable dt = new DataTable();
        dt.Columns.Add("ID", typeof(string));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Number", typeof(int));
        dt.Columns.Add("Price", typeof(float));
        dt.Columns.Add("Image", typeof(string));
        dt.Columns.Add("Total", typeof(float), "Number*Price");

        dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
        Session["giohang"] = dt;

    }
}