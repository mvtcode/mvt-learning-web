using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_ReportCustomerSelect : System.Web.UI.UserControl
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

        User obj = new User();
        rptProduct.DataSource = obj.getAll();
        rptProduct.DataBind();
    }

    protected void rptAdministrator_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);

        switch (strCommand)
        {

            case "report":
                string sEdit = "~/Admin/PrintCustomerDetails.aspx?nid=" + nID;
                Response.Redirect(sEdit);
                break;


        }
    }
    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {

            Label lblCode = (Label)e.Item.FindControl("lblCode");
            Label lblCustomerName = (Label)e.Item.FindControl("lblCustomerName");
            Label lblEmail = (Label)e.Item.FindControl("lblEmail");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");
            Label lblCMT = (Label)e.Item.FindControl("lblCMT");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "UserID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sEmail = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Email"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));
            string sAddress = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Address"));
            string sCMT = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "CMT"));

            lblCode.Text = "C-" + nID;
            lblCustomerName.Text = sName;
            lblEmail.Text = sEmail;
            lblPhone.Text = sPhone;
            lblAddress.Text = sAddress;
            lblCMT.Text = sCMT;

            lnkEdit.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "UserID"));

        }
    }
    protected void btOrder_Click(object sender, EventArgs e)
    {

        string sDateFrom = txtSaleDateFrom.Text;
        string sDateTo = txtSaleDateTo.Text;

        string surl = "~/Admin/PrintCustomerDetails.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo;
        Response.Redirect(surl);
    }
  
    protected void btChart_Click1(object sender, EventArgs e)
    {
        string sDateFrom = txtDateFrom2.Text;
        string sDateTo = txtDateTo2.Text;
        Response.Redirect("~/Admin/PrintCustomer.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sDateFrom = TextBox1.Text;
        string sDateTo = TextBox2.Text;
        Response.Redirect("~/Admin/PrintCustomerSummary.aspx?datefrom=" + sDateFrom + "&dateto=" + sDateTo);
    }
}