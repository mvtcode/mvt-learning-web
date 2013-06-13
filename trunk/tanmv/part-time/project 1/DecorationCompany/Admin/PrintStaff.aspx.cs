using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_PrintStaff : System.Web.UI.Page
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
        DataTable dtb = new DataTable();
        dtb = obj.GetAll();
        rptProduct.DataSource = dtb;
        rptProduct.DataBind();
    }


    protected void rptAdministrator_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblCode = (Label)e.Item.FindControl("lblCode");
            Label lblSatffName = (Label)e.Item.FindControl("lblSatffName");
            Label lblPhone = (Label)e.Item.FindControl("lblPhone");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");
            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "StaffID"));
            string sName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FullName"));
            string sPhone = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Phone"));
            string sAddress = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Address"));
            lblCode.Text = "ST-" + nID;
            lblSatffName.Text = sName;
            lblPhone.Text = sPhone;
            lblAddress.Text = sAddress;

        }
    }
}