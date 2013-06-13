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
            this.BindatatoDdlStaff();
            this.LoadData();
        }
    }

    private void LoadData()
    {
        string sAction = Request.QueryString["action"].ToString();
        int nID = Convert.ToInt32(Request.QueryString["nid"]);

            Delivery_Invoice obj = new Delivery_Invoice();
            DataTable dtb = new DataTable();
            dtb = obj.getByID(nID);
            lblStaffID.Text = dtb.Rows[0]["StaffID"].ToString();
            ddlStaff.SelectedValue = dtb.Rows[0]["StaffID"].ToString();
            lblDate.Text = dtb.Rows[0]["Date"].ToString();
            int nInvoiceDetailID = Convert.ToInt32( dtb.Rows[0]["InvoiceDetailsID"]);
            lblIInoiveDetails.Text = nInvoiceDetailID.ToString();
                
            InvoiceDetails objDetails = new InvoiceDetails();
            dtb = objDetails.getByID(nInvoiceDetailID);
            string sInvoiceID = dtb.Rows[0]["InvoiceID"].ToString();

            Invoice objInvoice = new Invoice();
            dtb = objInvoice.getMultipleID(sInvoiceID);
            rptProducts.DataSource = dtb;
            rptProducts.DataBind();
    }


    private void BindatatoDdlStaff()
    {
        Staff obj = new Staff();
        DataTable dtb = new DataTable();
        dtb = obj.GetAll();
        ddlStaff.DataSource = dtb;
        ddlStaff.DataValueField = "StaffID";
        ddlStaff.DataTextField = "FullName";
        ddlStaff.DataBind();
    }

    protected void BtPrint_Click(object sender, EventArgs e)
    {
        string sName = ddlStaff.Text;
        string fileName = "Delivery-" + sName + ".doc";
        // You can add whatever you want to add as the HTML and it will be generated as Ms Word docs
        Response.AppendHeader("Content-Type", "application/vnd.msword");
        Response.AppendHeader("Content-disposition", "attachment; filename=" + fileName);
        Response.Write(sContent());
    }
    
    protected void btUpdate_Click(object sender, EventArgs e)
    {
        Delivery_Invoice obj = new Delivery_Invoice();

        int nID = Convert.ToInt32(Request.QueryString["nid"]);
        int nStaffID = Convert.ToInt32(ddlStaff.SelectedValue);
        int nStatus = Convert.ToInt32(ddlStatus.SelectedValue);

        if (obj.updateStatus(nID, nStaffID, nStatus) > 0)
        {
            MessageBoxss.Show("Update successful !");
        }
    }

    private StringBuilder sContent()
    {
        int nID = Convert.ToInt32(Request.QueryString["nid"]);

        string sOrderID = lblIInoiveDetails.Text;


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
                                " <div style=\"text-align:right\">" + "<br/><i>BILL ID : " + "BD-" + nID + "</div></i>	" +
                                  " <div style=\"text-align:right\">" + "<br/><i>Date" + " " + DateTime.Today.Day + " " + "month" + " " + DateTime.Today.Month + " " + "year" + " " + DateTime.Today.Year + "</div></i>	" +
                                 "  <br/><br/><center><strong><div><span style=\"font-size:20px\">BILL PAYMENT AND PRODUCT RECEIVED</span></div></strong></center>	" +
   
                                 "  <div  style=\"text-align:right\">" +
                                     "  <div>&nbsp;</div>" +
                                      " <div>&nbsp; </div>" +
                                  " </div>" +
                                  " <br />" +
                                  " <div style=\"padding-bottom: 10px;\">Order ID : OD-" + sOrderID +   "</div>" +

                                  " <br />" +

                                 " <div style =\"padding-bottom:10px;\">" +
                                     "<table border=1 cellpadding=0 cellspacing =0  style=\" border:1px solid black; width:100%\">" +
                                          " <tr>" +
                                             "  <td style=\"text-align:center;width:50px;\">STT</td>" +
                                             "  <td style=\"text-align:center; width:250px;\">Products Name</td>" +
                                              " <td style=\"text-align:center; width:200px;\">Price</td>" +
                                              " <td style=\"text-align:center; width:90px;\">Number</td>" +
                                              " <td style=\"text-align:center; width:100px;\">The number of pay</td>" +
                                                   " <td style=\"text-align:center; width:100px;\">The number of remaining delivery</td>"+
                                         "  </tr>" +
                                       this.sProductContent() +



                                          "  <tr>" +
                                              " <td colspan =4>&nbsp;</td>" +

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
                  " <td style=\"text-align:center\">&nbsp;</td>" +
                  "  </tr>";
            i += 1;
        }

        return sContent;

    }


    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=delivery";
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


    
}