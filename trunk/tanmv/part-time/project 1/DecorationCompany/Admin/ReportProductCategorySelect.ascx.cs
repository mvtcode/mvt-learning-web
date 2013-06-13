using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_ReportProductCategorySelect : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            //this.BindataToRpt();
        }
    }

    private void BindataToRpt()
    {

        ProductCategory obj = new ProductCategory();
        rptProduct.DataSource = obj.GetAllProductCat();
        rptProduct.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Products obj = new Products();
        switch (strCommand)
        {

            case "report":
                string sEdit = "~/Admin/PrintProductsCategoryDetails.aspx?nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblCode = (Label)e.Item.FindControl("lblCode");
            Label lblCategoryName = (Label)e.Item.FindControl("lblCategoryName");
         
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            //LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
            string sCategoryName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));

            lblCode.Text = "PC-" + nID;
            lblCategoryName.Text = sCategoryName;

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
            //lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductID"));
        }
    }
    protected void btOrder_Click(object sender, EventArgs e)
    {
        string sDateFrom = txtSaleDateFrom.Text;
        string sDateTo = txtSaleDateTo.Text;

        string surl = "~/Admin/PrintProductsCategoryDetails.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }
    protected void btChart_Click(object sender, EventArgs e)
    {
        string sDateFrom = txtDateFrom3.Text;
        string sDateTo = txtDateTo3.Text;
        Response.Redirect("~/Admin/PrintProductCategorySummary.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sDateFrom = txtDateFrom2.Text;
        string sDateTo = txtDateTo2.Text;

        string surl = "~/Admin/PrintProductsCategory.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }
}