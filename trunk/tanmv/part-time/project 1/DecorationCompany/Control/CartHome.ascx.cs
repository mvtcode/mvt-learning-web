using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Control_CartHome : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = (DataTable)Session["giohang"];
        if (dt != null && dt.Rows.Count != 0)
        {
            lnkCart.Text = "(" + dt.Rows.Count + ")" + " items ";
        }
        else
            lnkCart.Text = "";
    }
}