using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_MenuTop : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            this.CheckUserName();

    }

    private void CheckUserName()
    {
        try
        {
            string sUser = Session["Username"].ToString();
            if (sUser != "")
            {
                lblUserName.Text = sUser;
                MultiView1.ActiveViewIndex = 1;

            }
            else
            {
                MultiView1.ActiveViewIndex = 0;
            }
        }
        catch {
            MultiView1.ActiveViewIndex = 0;
        }
      
    }
    protected void lbtLogOut_Click(object sender, EventArgs e)
    {
        Session["Username"] = "";
        MultiView1.ActiveViewIndex = 0;
    }
}