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
            this.ConfigCkeditor();
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
            News obj = new News();
            DataTable dtb = obj.getByID(nID);
            txtName.Text = dtb.Rows[0]["Name"].ToString();
            txtInit.Text = dtb.Rows[0]["InitContent"].ToString();
            txtContent.Text = dtb.Rows[0]["Content"].ToString();
            lblImage.Text = dtb.Rows[0]["Images"].ToString();
            img.ImageUrl = "~/images/News/" + dtb.Rows[0]["Images"].ToString();
            ddlCategoryLv2.SelectedValue = dtb.Rows[0]["CategoryLv2ID"].ToString();
        }
       
    }

    private void BindataToDdl()
    {
        CategoryLv2 obj = new CategoryLv2();
        DataTable dtb = new DataTable();
        dtb = obj.GetAll();
        ddlCategoryLv2.DataSource = dtb;
        ddlCategoryLv2.DataValueField = "CategoryLv2ID";
        ddlCategoryLv2.DataTextField = "Description";
        ddlCategoryLv2.DataBind();
    }

    private void UploadImages()
    {
        string savePath = Server.MapPath("~/images/News/");
        string fileName = FileUpload1.FileName;
        if (FileUpload1.HasFile)
        {
            savePath = savePath + @"\" + fileName;
            int fileSize = FileUpload1.PostedFile.ContentLength;
            string extend = Path.GetExtension(fileName);
            if (extend.ToLower().Equals(".jpg") || extend.ToLower().Equals(".gif"))
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
        News obj = new News();

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        string sName = txtName.Text;
        string sInit = txtInit.Text;
        string sContent = txtContent.Text;
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

        int nCat = Convert.ToInt32(ddlCategoryLv2.SelectedValue);
        string sAction = Request.QueryString["action"].ToString();
        
        

        switch (sAction)
        { 
            case "add":

                if (obj.insert(sName, sInit, sContent,sImage, nCat) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=news&message=1";
                        Response.Redirect(sUrl);
                    }
                break;
                
            case "edit":

                if (obj.update(nID,sName, sInit, sContent, sImage, nCat) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=news&message=2";
                        Response.Redirect(sUrl);
                    }
                break;
        }
    }

    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=news";
        Response.Redirect(sUrl);
    }


    protected void ConfigCkeditor()
    {

        txtContent.Language = "vi";
        txtContent.config.filebrowserImageBrowseUrl = "../ckfinder/ckfinder.html?type=Images";
        txtContent.config.filebrowserImageUploadUrl = "../ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images";
        CKFinder.FileBrowser _FileBrowser = new CKFinder.FileBrowser();
        _FileBrowser.BasePath = "../ckfinder/";
        _FileBrowser.SetupCKEditor(txtContent);
    }
}