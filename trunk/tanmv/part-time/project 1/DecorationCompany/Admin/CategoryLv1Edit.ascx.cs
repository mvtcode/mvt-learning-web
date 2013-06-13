using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_AdministratorEdit : System.Web.UI.UserControl
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
        string sAction = Request.QueryString["action"].ToString();
        if (sAction == "edit")
        {
            int nID = Convert.ToInt32(Request.QueryString["nid"]);
            CategoryLv1 obj = new CategoryLv1();
            DataTable dtb = obj.getByID(nID);
            txtName.Text = dtb.Rows[0]["Description"].ToString();

        }
       
    }



    protected void btUpdate_Click(object sender, EventArgs e)
    {
        CategoryLv1 obj = new CategoryLv1();

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        string sName = txtName.Text;
      
        string sAction = Request.QueryString["action"].ToString();
        
        

        switch (sAction)
        { 
            case "add":

                if (obj.insert(sName) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=lv1&message=1";
                        Response.Redirect(sUrl);
                    }
                break;
                
            case "edit":

                if (obj.update(nID,sName) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=lv1&message=2";
                        Response.Redirect(sUrl);
                    }
                break;
        }
    }

    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=lv1";
        Response.Redirect(sUrl);
    }
}