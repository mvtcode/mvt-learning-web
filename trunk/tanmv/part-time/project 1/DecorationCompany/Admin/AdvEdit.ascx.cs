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
            this.BindataToDdl();
            this.LoadData();
        }
    }

    private void LoadData()
    {
        string sAction = Request.QueryString["action"].ToString();
        if (sAction == "edit")
        {
            int nID = Convert.ToInt32(Request.QueryString["nid"]);
            Adv obj = new Adv();
            DataTable dtb = obj.getByID(nID);
            txtUrl.Text = dtb.Rows[0]["Url"].ToString();
            txtDescription.Text = dtb.Rows[0]["Description"].ToString();

            lblImage.Text = dtb.Rows[0]["Images"].ToString();
            img.ImageUrl = "~/images/Adv/" + dtb.Rows[0]["Images"].ToString();
            ddlCategoryLv1.SelectedValue = dtb.Rows[0]["CategoryLv1"].ToString();
        }
       
    }

    private void BindataToDdl()
    {
        CategoryLv1 obj = new CategoryLv1();
        DataTable dtb = new DataTable();
        dtb = obj.GetAll();
        ddlCategoryLv1.DataSource = dtb;
        ddlCategoryLv1.DataValueField = "CategoryLv1";
        ddlCategoryLv1.DataTextField = "Description";
        ddlCategoryLv1.DataBind();
    }

    private void UploadImages()
    {
        string savePath = Server.MapPath("~/images/Adv/");
        string fileName = FileUpload1.FileName;
        if (FileUpload1.HasFile)
        {
            savePath = savePath + @"\" + fileName;
            int fileSize = FileUpload1.PostedFile.ContentLength;
            string extend = Path.GetExtension(fileName);
            if (extend.ToLower().Equals(".jpg") || extend.ToLower().Equals(".gif") || extend.ToLower().Equals(".png"))
            {

            }
            else
            {
                lblImageWarning.Visible = true;
                lblImageWarning.Text = "Invalid file type, you can upload file .jpg, gif";
                return;
            }
            if (fileSize < 5100000)
            {
                FileUpload1.SaveAs(savePath);
            }
            else
            {
                lblImageWarning.Visible = true;
                lblImageWarning.Text = "Invalid file size, max is 5Mb";
                return;
            }
        }
        
    }

    protected void btUpdate_Click(object sender, EventArgs e)
    {
        Adv obj = new Adv();

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        string sURL = txtUrl.Text;
        string sDescription = txtDescription.Text;
        string sImage = "";
        if (FileUpload1.HasFile)
        {
            sImage = FileUpload1.FileName;
            this.UploadImages();
        }
        else
        {
            sImage = lblImage.Text;
        }

        int nCat = Convert.ToInt32(ddlCategoryLv1.SelectedValue);
        string sAction = Request.QueryString["action"].ToString();
        
        

        switch (sAction)
        { 
            case "add":

                if (obj.insert(sDescription,sURL,sImage,nCat ) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=adv&message=1";
                        Response.Redirect(sUrl);
                    }
                break;
                
            case "edit":

                if (obj.update(nID,sDescription, sURL, sImage, nCat) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=adv&message=2";
                        Response.Redirect(sUrl);
                    }
                break;
        }
    }

    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=adv";
        Response.Redirect(sUrl);
    }
}