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

        Staff ad = new Staff();
        rptStaff.DataSource = ad.GetAll();
        rptStaff.DataBind();
    }
  
    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        Staff obj = new Staff();
        switch (strCommand)
        {
            case "Delete":
              
                int nDelete = obj.delete(nID);
                this.BindataToRptAdministrator();
                break;

            case "Edit":
                string sEdit = "~/Admin/Administrator.aspx?page=staffedit&action=edit&nid=" + nID; 
                Response.Redirect(sEdit);
                break;

            
        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "StaffID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sAddess = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Address"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));

            lblName.Text = sName;
            lblPhone.Text = sPhone;
            lblAddress.Text = sAddess;

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "StaffID"));
            lnkDelete.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "StaffID"));
        }
    }
    protected void lbtAddnew_Click(object sender, EventArgs e)
    {
        string sEdit = "~/Admin/Administrator.aspx?page=staffedit&action=add";
        Response.Redirect(sEdit);
    }
}