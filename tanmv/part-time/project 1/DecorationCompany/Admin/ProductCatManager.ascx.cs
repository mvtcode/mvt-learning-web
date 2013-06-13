using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_AdvManager : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRpt();
        }
    }
    private void BindataToRpt()
    {

        ProductCategory obj = new ProductCategory();
        rptProductCat.DataSource = obj.GetAllProductCat();
        rptProductCat.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        ProductCategory obj = new ProductCategory();
        switch (strCommand)
        {
            case "Delete":

                int nDelete = obj.delete(nID);
                this.BindataToRpt();
                break;

            case "Edit":
                string sEdit = "~/Admin/Administrator.aspx?page=procatedit&action=edit&nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblProductCat = (Label)e.Item.FindControl("lblProductCat");
                           
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));
            
          

            lblProductCat.Text = sName;

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryID"));
        }
    }
    protected void lbtAddnew_Click(object sender, EventArgs e)
    {
        string sEdit = "~/Admin/Administrator.aspx?page=procatedit&action=add";
        Response.Redirect(sEdit);
    }
}