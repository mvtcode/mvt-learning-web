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
            Products obj = new Products();
            DataTable dtb = obj.LoadByID(nID);
            txtProductName.Text = dtb.Rows[0]["ProductName"].ToString();
            txtPrice.Text = dtb.Rows[0]["Price"].ToString();
            txtStock.Text = dtb.Rows[0]["Stock"].ToString();
            txtInit.Text = dtb.Rows[0]["InitContent"].ToString();
            txtContent.Text = dtb.Rows[0]["MainContent"].ToString();
            lblImage.Text = dtb.Rows[0]["Images"].ToString();
            img.ImageUrl = "~/images/products/" + dtb.Rows[0]["Images"].ToString();
            ddlProductCategory.SelectedValue = dtb.Rows[0]["ProductCategoryID"].ToString();
        }
       
    }

    private void BindataToDdl()
    {
        ProductCategory obj = new ProductCategory();
        DataTable dtb = new DataTable();
        dtb = obj.GetAllProductCat();
        ddlProductCategory.DataSource = dtb;
        ddlProductCategory.DataValueField = "ProductCategoryID";
        ddlProductCategory.DataTextField = "ProductCategoryName";
        ddlProductCategory.DataBind();
    }

    private void UploadImages()
    {
        string savePath = Server.MapPath("~/images/products/");
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
        Products obj = new Products();

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        string sProductName = txtProductName.Text;
        string sInit = txtInit.Text;
        string sContent = txtContent.Text;
        double dPrice =Convert.ToDouble(txtPrice.Text);
        int nStock = Convert.ToInt32(txtStock.Text);
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

        int nCat = Convert.ToInt32(ddlProductCategory.SelectedValue);
        string sAction = Request.QueryString["action"].ToString();
        
        

        switch (sAction)
        { 
            case "add":

                if (obj.insert(sProductName, dPrice, sImage,  nStock, nCat, sInit, sContent) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=pro&message=1";
                        Response.Redirect(sUrl);
                    }
                break;
                
            case "edit":

                if (obj.update(nID, sProductName, dPrice, sImage, nStock, nCat, sInit, sContent) > 0)
                    {
                        string sUrl = "~/Admin/Administrator.aspx?page=pro&message=2";
                        Response.Redirect(sUrl);
                    }
                break;
        }
    }

    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=pro";
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