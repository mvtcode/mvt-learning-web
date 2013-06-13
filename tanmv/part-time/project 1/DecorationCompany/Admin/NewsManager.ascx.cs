using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_BannerManager : System.Web.UI.UserControl
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

        News obj = new News();
        rptNews.DataSource = obj.getAll();
        rptNews.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        News obj = new News();
        switch (strCommand)
        {
            case "Delete":

                int nDelete = obj.delete(nID);
                this.BindataToRpt();
                break;

            case "Edit":
                string sEdit = "~/Admin/Administrator.aspx?page=newsedit&action=edit&nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblCategory = (Label)e.Item.FindControl("lblCategory");
                
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "NewID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Name"));
            string sCategory = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Description"));


            lblName.Text = sName;
            lblCategory.Text = sCategory;

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "NewID"));
            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "NewID"));
        }
    }
    protected void lbtAddnew_Click(object sender, EventArgs e)
    {
        string sEdit = "~/Admin/Administrator.aspx?page=newsedit&action=add";
        Response.Redirect(sEdit);
    }
}