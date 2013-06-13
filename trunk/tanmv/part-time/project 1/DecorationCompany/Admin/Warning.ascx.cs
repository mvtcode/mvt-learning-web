using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Warning : System.Web.UI.UserControl
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
        div_blue.Visible = false;
        div_red.Visible = false;
        int nMess = Convert.ToInt32(Request.QueryString["message"]);

        switch (nMess)
        { 
            case 1:
                div_blue.Visible = true;
                lblBlue.Text = " Add new record successfully !";
                break;
            case 2:
                div_blue.Visible = true;
                lblBlue.Text = "Edit record successfully !";
                break;
        }
    }
}