using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_AdministratorEdit : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindataToDdlRole();
            this.LoadData();
        }
    }

    private void LoadData()
    {
        string sAction = Request.QueryString["action"].ToString();
        if (sAction == "edit")
        {
            int nID = Convert.ToInt32(Request.QueryString["nid"]);
            Administrator obj = new Administrator();
            DataTable dtServices = obj.getAccountByID(nID);
            txtName.Text = dtServices.Rows[0]["Name"].ToString();
            txtUserName.Text = dtServices.Rows[0]["Username"].ToString();  
            txtEmail.Text = dtServices.Rows[0]["Email"].ToString();
            txtAddress.Text = dtServices.Rows[0]["Address"].ToString();
            txtPhone.Text = dtServices.Rows[0]["Phone"].ToString();

            lblPassword.Text = dtServices.Rows[0]["Password"].ToString();

            ddlRole.SelectedValue = dtServices.Rows[0]["RoleID"].ToString();
        }
        else
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtRePassword.Enabled = true;
            rfvPass.Enabled = true;
            rfvRePass.Enabled = true;
        }
    }

    private void BindataToDdlRole()
    {
        RoleUser obj = new RoleUser();
        DataTable dtb = new DataTable();
        dtb = obj.GetAll();
        ddlRole.DataSource = dtb;
        ddlRole.DataValueField = "RoleID";
        ddlRole.DataTextField = "Description";
        ddlRole.DataBind();
    }
    
    protected void btUpdate_Click(object sender, EventArgs e)
    {
        Administrator obj = new Administrator();

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        string sName = txtName.Text;
        string sUserName = txtUserName.Text;
        string sEmail = txtEmail.Text;
        string sAddress = txtAddress.Text;
        string sPhone = txtPhone.Text;
        string sPassword = lblPassword.Text;
        int nRoleID = Convert.ToInt32(ddlRole.SelectedValue);
        string sAction = Request.QueryString["action"].ToString();
        
        

        switch (sAction)
        { 
            case "add":

                if (obj.insertAdministrator(sUserName, sPassword, sName, sEmail, sPhone, sAddress,nRoleID ) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=admin&message=1";
                        Response.Redirect(sUrl);
                    }
                break;
                
            case "edit":

                if (obj.updateAdmin(nID, sUserName, sPassword, sName, sEmail, sPhone, sAddress,nRoleID ) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=admin&message=2";
                        Response.Redirect(sUrl);
                    }
                break;
        }
    }

    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=admin";
        Response.Redirect(sUrl);
    }
}