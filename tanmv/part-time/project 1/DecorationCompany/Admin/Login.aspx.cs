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

public partial class Admin_Login : System.Web.UI.Page
{
    Administrator pd = new Administrator();
    protected void Page_Load(object sender, EventArgs e)
    {
        SetFocus(txtUser);
        if (!Page.IsPostBack)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }
    }

    protected void btLogin_Click(object sender, EventArgs e)
    {
        string Username = txtUser.Text;
        string Password = txtPassword.Text;


        if (pd.checkLoginAdmin(Username, Password) > 0)
        {

            Session["UsernameAdmin"] = Username;
            Response.Redirect("Administrator.aspx");
        }
       

        else
        {
            lbStatus.Text = "INVALID USER NAME OR PASSWORD! PLEASE TRY AGAIN.!";
        }
    }
}