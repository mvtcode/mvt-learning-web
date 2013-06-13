using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_AdministratorManager : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToRptAdministrator();
        }
    }
    private void BindataToRptAdministrator()
    {

        Administrator obj = new Administrator();
        rptAdministrator.DataSource = obj.getAllAdmin();
        rptAdministrator.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Administrator obj = new Administrator();
        switch (strCommand)
        {
            case "Delete":

                int nDelete = obj.deleteAdmin(nID);
                this.BindataToRptAdministrator();
                break;

            case "Edit":
                string sEdit = "~/Admin/Administrator.aspx?page=adminedit&action=edit&nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblUserName = (Label)e.Item.FindControl("lblUserName");
            Label lblEmail = (Label)e.Item.FindControl("lblEmail");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "AdminID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Name"));
            string sUserName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Username"));
            string sEmail = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Email"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));

            lblName.Text = sName;
            lblUserName.Text = sUserName;
            lblEmail.Text = sEmail;
            lblPhone.Text = sPhone;

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "AdminID"));
            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "AdminID"));
        }
    }
    protected void lbtAddnew_Click(object sender, EventArgs e)
    {
        string sEdit = "~/Admin/Administrator.aspx?page=adminedit&action=add";
        Response.Redirect(sEdit);
    }
}