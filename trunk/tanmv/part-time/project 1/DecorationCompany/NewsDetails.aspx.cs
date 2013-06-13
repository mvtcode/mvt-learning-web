using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class NewsDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            this.LoadData();
        }
    }
    private void LoadData()
    {
        News pro = new News();
        int nID = Convert.ToInt32(Request.QueryString["nid"]);

        DataTable dtb = pro.getByID(nID);
        lnkName.Text = dtb.Rows[0]["Name"].ToString();
        lblInit.Text = " $ " + dtb.Rows[0]["InitContent"].ToString();
        img.ImageUrl = "~/images/News/" + dtb.Rows[0]["Images"].ToString();
        ltrContent.Text = dtb.Rows[0]["Content"].ToString();
   
    }
}