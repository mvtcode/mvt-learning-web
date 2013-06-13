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
using System.Text.RegularExpressions;

using System.Text;
using System.IO;


public partial class Admin_AdministratorEdit : System.Web.UI.UserControl
{
    double fTotal = 0;
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
        int nID = Convert.ToInt32(Request.QueryString["nid"]);

            InvoiceDetails obj = new InvoiceDetails();
            DataTable dtb = new DataTable();
            dtb = obj.getByID(nID);
            lblCustomerID.Text = dtb.Rows[0]["UserID"].ToString();
            lblCustomerName.Text = dtb.Rows[0]["FullName"].ToString();
            lblPhone.Text = dtb.Rows[0]["Phone"].ToString();
            lblAddress.Text = dtb.Rows[0]["Address"].ToString();
            lblCMT.Text = dtb.Rows[0]["CMT"].ToString();
            lblMultipleID.Text = dtb.Rows[0]["InvoiceID"].ToString();
            string sInvoiceID = dtb.Rows[0]["InvoiceID"].ToString();
            Invoice objInvoice = new Invoice();
            dtb = objInvoice.getMultipleID(sInvoiceID);
            rptProducts.DataSource = dtb;
            rptProducts.DataBind();
    }

    
    protected void btUpdate_Click(object sender, EventArgs e)
    {
       string sName = lblCustomerName.Text;
       string sUserID = lblCustomerID.Text;
       string fileName = "Order_Customer.doc";
        // You can add whatever you want to add as the HTML and it will be generated as Ms Word docs
        Response.AppendHeader("Content-Type", "application/vnd.msword");
        Response.AppendHeader("Content-disposition", "attachment; filename=" + fileName);
        Response.Write(sContent());
    }

    private void BindataToDdl()
    {
        Staff obj = new Staff();
        DataTable dtb = new DataTable();
        dtb = obj.GetAll();
        ddlStaff.DataSource = dtb;
        ddlStaff.DataValueField = "StaffID";
        ddlStaff.DataTextField = "FullName";
        ddlStaff.DataBind();
    }

    private StringBuilder sContent()
    {
        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        int nCustomerID = Convert.ToInt32(lblCustomerID.Text);
        User ad = new User();
        DataTable dtchange = ad.getByID(nCustomerID);
        string sNameUser = dtchange.Rows[0]["FullName"].ToString();
        string sEmailUser = dtchange.Rows[0]["Email"].ToString();
        string sPhoneUser = dtchange.Rows[0]["Phone"].ToString();
        string sAddressUser = dtchange.Rows[0]["Address"].ToString();
        string sCMTUser = dtchange.Rows[0]["CMT"].ToString();

        StringBuilder strBody = new StringBuilder("");

        string sCompanyName = "NGUYEN DAI DUONG HOME DECORATION COMPANY";
        string sAddress = "215 - Thai Ha -Dong Da - Ha Noi ";
        string sPhone = "04.3123321";
        string sEmail = "NguyenDaiDuong_Company@gmail.com";
        string sWebsite = "daiduongcompany.com.vn";


        strBody.Append("<html " +
                   "xmlns:o='urn:schemas-microsoft-com:office:office' " +
                   "xmlns:w='urn:schemas-microsoft-com:office:word'" +
                   "xmlns='http://www.w3.org/TR/REC-html40'>" +
                   "<head><title>Order Form</title>");

        strBody.Append("<!--[if gte mso 9]>" +
                                 "<xml>" +
                                 "<w:WordDocument>" +
                                 "<w:View>Print</w:View>" +
                                 "<w:Zoom>100</w:Zoom>" +
                                 "<w:DoNotOptimizeForBrowser/>" +
                                 "</w:WordDocument>" +
                                 "</xml>" +
                                 "<![endif]-->");

        strBody.Append("<style>" +
                                "<!-- /* Style Definitions */" +
                                "@page Section2" +
                                "   {size:841.7pt 595.45pt;mso-page-orientation:landscape;" + //size:820px 560px;"
                                "   margin:1.0in 1.25in 1.0in 1.25in ; " +
                                "   mso-header-margin:.5in; " +
                                "   mso-footer-margin:.5in; mso-paper-source:0;}" +

                                " div.Section2 {page:Section2;}" +

                               "</style></head>");

        strBody.Append("<body lang=EN-US style='tab-interval:.5in'>" +


           "<div class=Section2>" +
                                "<table >" +
                               "<tr><td>&nbsp;</td></tr>" +
                                  " <tr>" +
                                  "<td>&nbsp;</td>" +
                                        "<td style=\"padding-right:5px;width:160px;\"></td>" +
                                       "<td style=\"padding-right:1px;width:700px; \" colspan=\"5\">" +
                                           "<div style=\"padding-bottom: 10px;font-size:17px;\"><strong>" + sCompanyName + "</strong></div>" +
                                          "<div style=\"padding-bottom: 10px;\">Đ/C: " + sAddress + "</div>" +
                                           "<div style=\"padding-bottom: 10px;\">Điện thoại: " + sPhone + "</div>" +
                                          "<div style=\"padding-bottom: 10px;\">Email: " + sEmail + " " + " - " + " " + "Website: " + " " + sWebsite + "</div>" +
                                       "</td>" +

                                  " </tr>" +
                               "</table>" +
                             "  <div>" +
                                  " <div style=\"text-align:right\">" + "<br/><i>Ha Noi, date" + " " + DateTime.Today.Day + " " + "month" + " " + DateTime.Today.Month + " " + "year" + " " + DateTime.Today.Year + "</div></i>	" +
                                 "  <br/><br/><center><strong><div><span style=\"font-size:20px\">ORDER FORM</span></div></strong></center>	" +
                                  " <center><div><span>Number : OD-" +nID+"</span></div></center>	" +
                                 "  <div  style=\"text-align:right\">" +
                                     "  <div>&nbsp;</div>" +
                                      " <div>&nbsp; </div>" +
                                  " </div>" +
                                  " <br />" +
                                  " <div style=\"padding-bottom: 10px;\">Customer : " + sNameUser +  
                                   " <div style=\"padding-bottom: 10px;\">Phone : " + sPhoneUser + " </div>" +
                                  " <div style=\"padding-bottom: 10px;\">Address : " + sAddress + " </div>" +
                                  " <div style=\"padding-bottom: 10px;\">Identity card number : " + sCMTUser + " </div>" +
                                  " <br />" +

                                 " <div style =\"padding-bottom:10px;\">" +
                                     "<table border=1 cellpadding=0 cellspacing =0  style=\" border:1px solid black; width:100%\">" +
                                          " <tr>" +
                                             "  <td style=\"text-align:center;width:50px;\">STT</td>" +
                                             "  <td style=\"text-align:center; width:250px;\">Products Name</td>" +
                                              " <td style=\"text-align:center; width:200px;\">Price</td>" +
                                              " <td style=\"text-align:center; width:90px;\">Number</td>" +
                                              " <td style=\"text-align:center; width:100px;\">Total</td>" +

                                         "  </tr>" +
                                       this.sProductContent() +



                                          "  <tr>" +
                                              " <td colspan =3>&nbsp;</td>" +

                                               "<td>Total : </td>" +
                                             "  <td colspan =1>" + lblTotalNumber.Text + "</td>" +

                                          " </tr>" +
                                      " </table>" +
                                   "</div>" +
                                  
                                    
                              " </div>" +
                              "</div>" +
       "</body>" +
           "</html>");

        return strBody;

    }

    private string sProductContent()
    {

        string sContent = "";
        int i = 0;
        int nID = 0;
        foreach (RepeaterItem RepeaterReport in rptProducts.Items)
        {
            nID = Convert.ToInt32(((Label)RepeaterReport.FindControl("lblID")).Text);
            sContent = sContent+
                  " <tr>" +
                  "  <td style=\"text-align:center\">" + Convert.ToString(i + 1) + "</td>" +
                  "  <td style=\"text-align:center;\">" + ((Label)RepeaterReport.FindControl("lblProductName")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblPrice")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblNumber")).Text + "</td>" +
                  " <td style=\"text-align:center\">&nbsp;</td>" +
                  "  </tr>";
            i += 1;
        }

        return sContent;

    }


    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=invoicedetails";
        Response.Redirect(sUrl);
    }

    protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            Label lblID = (Label)e.Item.FindControl("lblID");
            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblNumber = (Label)e.Item.FindControl("lblNumber");

            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
            double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
            int nStock = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));

            lblID.Text= nID.ToString();
            lblProductName.Text = sProductName;
            lblPrice.Text = dPrice.ToString() + "     $ ";
            lblNumber.Text = nStock.ToString();
            fTotal += dPrice * nStock;
            lblTotalNumber.Text = "<span style=\"color:#D35638;font-weight:bold;\">" + fTotal.ToString() + " $ </span>";
        }
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        int nStatus = Convert.ToInt32(ddlStatus.SelectedValue);
        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        InvoiceDetails obj = new InvoiceDetails();
        int nRes = obj.updateStatus(nID, nStatus);
        string sDate = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
        int nStaff = Convert.ToInt32(ddlStaff.SelectedValue);
         if(nRes>0)
         {
            switch (nStatus)
            { 
                case 0:
                    MessageBoxss.Show("Update successful !");
                    break;
                case 1:
                    Delivery_Invoice objDelivery = new Delivery_Invoice();
                    objDelivery.insert(nStaff, sDate, nID, 0);
                    MessageBoxss.Show("Add successful delivery bill !");
                    
                    break;  
                case 2:
                    MessageBoxss.Show("Update successful !");
                    break;
            }

        }
    }
}