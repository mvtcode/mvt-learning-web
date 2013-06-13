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

        Adv obj = new Adv();
        rptAdv.DataSource = obj.getAll();
        rptAdv.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Adv obj = new Adv();
        switch (strCommand)
        {
            case "Delete":

                int nDelete = obj.delete(nID);
                this.BindataToRpt();
                break;

            case "Edit":
                string sEdit = "~/Admin/Administrator.aspx?page=advedit&action=edit&nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblDescription = (Label)e.Item.FindControl("lblDescription");
            Label lblUrl = (Label)e.Item.FindControl("lblUrl");
                
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "AdvID"));
            string sDescript = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Description"));
            string sURL = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Url"));
          

            lblDescription.Text = sDescript;
            lblUrl.Text = sURL;


            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "AdvID"));
            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "AdvID"));
        }
    }
    protected void lbtAddnew_Click(object sender, EventArgs e)
    {
        string sEdit = "~/Admin/Administrator.aspx?page=advedit&action=add";
        Response.Redirect(sEdit);
    }
}