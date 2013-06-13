using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_PrintStaffDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.LoadData();
        }

    }

    private void LoadData()
    {

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        Staff obj = new Staff();
        DataTable dtb = obj.getByID(nID);
        lblCode.Text = "ST-" + nID;
        lblStaffName.Text = dtb.Rows[0]["FullName"].ToString();
        lblPhone.Text = dtb.Rows[0]["Phone"].ToString();
        lblAddress.Text = dtb.Rows[0]["Address"].ToString();

    }
}