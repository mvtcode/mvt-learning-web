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

public partial class Register : System.Web.UI.Page
{
    User user = new User();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }

    private void Reset()
    { 
         txtUserName.Text = "";
         txtPassword.Text = "";
         txtFullName.Text = "";
         txtAddess.Text = "";
         txtBirthDay.Text = "";
         txtCMT.Text = "";
         txtEmail.Text = "";
         txtPhone.Text = "";
            
    }
    protected void lbtReset_Click(object sender, EventArgs e)
    {
        this.Reset();
    }
    protected void lbtRegister_Click(object sender, EventArgs e)
    {
        string sDateCMT = DateTime.Now.Date.ToString();
        string sName = txtFullName.Text;
        string sUsername = txtUserName.Text;
        string sPassword = txtPassword.Text;
        string sAddress = txtAddess.Text;
        string sEmail = txtEmail.Text;
        string sPhone = txtPhone.Text;
        string sBirthday = txtBirthDay.Text;
        string sCMT = txtCMT.Text;
        int nSex = 0;
 
        int nRoleID= 3;
        if (rdbMale.Checked == true)
        {
             nSex = 1;
        }
        if (rdbFeMale.Checked == true)
        {
             nSex = 2;
        }
       

        if (user.CreateNewAccount(sUsername, sPassword, sEmail, sName, nSex,sPhone,sAddress,sCMT,nRoleID,sBirthday) > 0)
            {
                this.Reset();
                Response.Redirect("RegisterSussces.aspx");
                
            }
        
    }

}