using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_ReportStaffSelect : System.Web.UI.UserControl
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

        Staff obj = new Staff();
        rptProduct.DataSource = obj.GetAll();
        rptProduct.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
       
        switch (strCommand)
        {

            case "report":
                string sEdit = "~/Admin/PrintStaffDetails.aspx?nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblCode = (Label)e.Item.FindControl("lblCode");
            Label lblStaffName = (Label)e.Item.FindControl("lblStaffName");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "StaffID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));
            string sAddress = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Address"));


            lblCode.Text = "ST-" + nID;
            lblStaffName.Text = sName;
            lblPhone.Text = sPhone;
            lblAddress.Text = sAddress;
            

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "StaffID"));
           
        }
    }
    protected void btOrder_Click(object sender, EventArgs e)
    {

        string surl = "~/Admin/PrintStaff.aspx";
        Response.Redirect(surl);
    }

    protected void btChart_Click(object sender, EventArgs e)
    {

        string sDateFrom = txtSaleDateFrom.Text;
        string sDateTo = txtSaleDateTo.Text;

        string surl = "~/Admin/PrintStaffSummary.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }
}