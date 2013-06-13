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
            
        }
    }


    protected void btOrder_Click(object sender, EventArgs e)
    {
        string sFrom = txtOrderDateFrom.Text.Trim();
        string sTo = txtOrderDateTo.Text.Trim();
        string surl = "~/Admin/Administrator.aspx?page=reportorder&datefrom="+sFrom+"&dateto=" + sTo;
        Response.Redirect(surl);
    }
    protected void btSale_Click(object sender, EventArgs e)
    {
        string sFrom = txtSaleDateFrom.Text.Trim();
        string sTo = txtSaleDateTo.Text.Trim();
        string surl = "~/Admin/Administrator.aspx?page=reportsale&datefrom=" + sFrom + "&dateto=" + sTo;
        Response.Redirect(surl);
    }

    private void BindataToDdl()
    {
        ProductCategory obj = new ProductCategory();
        DataTable dtb = new DataTable();
        dtb = obj.GetAllProductCat();
        ddlProducts.DataSource = dtb;
        ddlProducts.DataValueField = "ProductCategoryID";
        ddlProducts.DataTextField = "ProductCategoryName";
        ddlProducts.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sFrom = txtSaleDateFrom.Text.Trim();
        string sTo = txtSaleDateTo.Text.Trim();
        string surl = "~/Admin/Administrator.aspx?page=reportsale&datefrom=" + sFrom + "&dateto=" + sTo;
        Response.Redirect(surl);
    }
}