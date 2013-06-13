using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_ReportProductSelect : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            
            //this.BindataToRpt();
        }
    }


    //private void BindataToRpt()
    //{

    //    Products obj = new Products();
    //    rptProduct.DataSource = obj.getAll();
    //    rptProduct.DataBind();
    //}

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Products obj = new Products();
        switch (strCommand)
        {

            case "report":
                string sEdit = "~/Admin/PrintProductsDetails.aspx?nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblStock = (Label)e.Item.FindControl("lblStock");
            Image imgProduct = (Image)e.Item.FindControl("imgProduct");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            //LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
            double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Stock"));
            string sImage = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Images"));
            imgProduct.ImageUrl = "~/images/products/" + sImage;
            lblProductName.Text = sProductName;
            lblPrice.Text = dPrice.ToString() + "     $ ";
            lblStock.Text = nStock.ToString();


            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            //lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductID"));
        }
    }
    protected void btOrder_Click(object sender, EventArgs e)
    {
        string sDateFrom = txtSaleDateFrom.Text;
        string sDateTo = txtSaleDateTo.Text;

        string surl = "~/Admin/PrintProductsDetails.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }

    protected void btChart_Click(object sender, EventArgs e)
    {
        string sDateFrom = txtDateFrom3.Text;
        string sDateTo = txtDateTo3.Text;

        string surl = "~/Admin/PrintProductsSummary.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }
    protected void btChartException_Click(object sender, EventArgs e)
    {
        string sDateFrom = txtDateFrom.Text;
        string sDateTo = txtDateTo.Text;

        string surl = "~/Admin/PrintProducts.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }
}