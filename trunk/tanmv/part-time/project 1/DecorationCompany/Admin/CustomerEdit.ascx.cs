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
            User obj = new User();
            DataTable dtb = obj.getByID(nID);

            lblName.Text = dtb.Rows[0]["FullName"].ToString();
            lblUserName.Text = dtb.Rows[0]["Username"].ToString();
            lblPhone.Text = dtb.Rows[0]["Phone"].ToString();
            lblAddress.Text = dtb.Rows[0]["Address"].ToString();
            lblEmail.Text = dtb.Rows[0]["Email"].ToString();
            lblBirthdy.Text = dtb.Rows[0]["BirthDay"].ToString();
            lblIDCard.Text = dtb.Rows[0]["CMT"].ToString();

            int nGender = Convert.ToInt32(dtb.Rows[0]["Sex"]);
            if (nGender == 1)
            { lblGender.Text = "Male"; }
            else { lblGender.Text = "Female"; }
        }
       
    }


}