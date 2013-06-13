﻿using System;
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
            this.LoadData();
        }
    }

    private void LoadData()
    {
        string sFrom = Request.QueryString["datefrom"].ToString();
        string sTo = Request.QueryString["dateto"].ToString();
        lblDateFrom.Text = sFrom;
        lblDateTo.Text = sTo;
        Invoice objInvoice = new Invoice();
        DataTable dtb = new DataTable();
        dtb = objInvoice.ReportByDate(sFrom,sTo);
        rptReportOrder.DataSource = dtb;
        rptReportOrder.DataBind();
        
    }

    
    protected void btUpdate_Click(object sender, EventArgs e)
    {
       
       string fileName = "Report_Order.doc";
        // You can add whatever you want to add as the HTML and it will be generated as Ms Word docs
        Response.AppendHeader("Content-Type", "application/vnd.msword");
        Response.AppendHeader("Content-disposition", "attachment; filename=" + fileName);
        Response.Write(sContent());
    }

    private StringBuilder sContent()
    {

        string sFrom = Request.QueryString["datefrom"].ToString();
        string sTo = Request.QueryString["dateto"].ToString();

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
                                          "<div style=\"padding-bottom: 10px;\">Address: " + sAddress + "</div>" +
                                           "<div style=\"padding-bottom: 10px;\">Phone: " + sPhone + "</div>" +
                                          "<div style=\"padding-bottom: 10px;\">Email: " + sEmail + " " + " - " + " " + "Website: " + " " + sWebsite + "</div>" +
                                       "</td>" +

                                  " </tr>" +
                               "</table>" +
                             
                                 "  <br/><br/><center><strong><div><span style=\"font-size:20px\">REPORT ORDERED PRODUCTS</span></div></strong></center>	" +
                                
                                 "  <div  style=\"text-align:right\">" +
                                     "  <div>&nbsp;</div>" +
                                      " <div>&nbsp; </div>" +
                                  " </div>" +
                                  " <br />" +
                                  " <div style=\"padding-bottom: 10px;\">Date from : " + sFrom +  
                                   " <div style=\"padding-bottom: 10px;\">Date to : " + sTo + " </div>" +
                                  " <br />" +

                                 " <div style =\"padding-bottom:10px;\">" +
                                     "<table border=1 cellpadding=0 cellspacing =0  style=\" border:1px solid black; width:100%\">" +
                                          " <tr>" +
                                             "  <td style=\"text-align:center;width:50px;\">STT</td>" +
                                             "  <td style=\"text-align:center; width:50px;\">ID</td>" +
                                              " <td style=\"text-align:center; width:200px;\">Product Name</td>" +
                                              " <td style=\"text-align:center; width:200px;\">Category</td>" +
                                              " <td style=\"text-align:center; width:100px;\">Price</td>" +
                                              " <td style=\"text-align:center; width:50px;\">Quantity</td>" +
                                              " <td style=\"text-align:center; width:200px;\">Date</td>" +
                                              " <td style=\"text-align:center; width:200px;\">Total</td>" +
                                         "  </tr>" +
                                       this.sProductContent() +



                                          "  <tr>" +
                                              " <td colspan =6>&nbsp;</td>" +

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
        foreach (RepeaterItem RepeaterReport in rptReportOrder.Items)
        {
            nID = Convert.ToInt32(((Label)RepeaterReport.FindControl("lblID")).Text);
            sContent = sContent+
                  " <tr>" +
                  "  <td style=\"text-align:center\">" + Convert.ToString(i + 1) + "</td>" +
                  "  <td style=\"text-align:center;\">" + ((Label)RepeaterReport.FindControl("lblProductID")).Text + "</td>" +
                  "  <td style=\"text-align:center;\">" + ((Label)RepeaterReport.FindControl("lblProductName")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblProductCat")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblPrice")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblQuantity")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblDate")).Text + "</td>" +
                  " <td style=\"text-align:center\">" + ((Label)RepeaterReport.FindControl("lblTotal")).Text + "</td>" +
                  "  </tr>";
            i += 1;
        }

        return sContent;

    }


    protected void btCancel_Click(object sender, EventArgs e)
    {
        string sUrl = "~/Admin/Administrator.aspx?page=report";
        Response.Redirect(sUrl);
    }

    protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        
            if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
            {
                Label lblID = (Label)e.Item.FindControl("lblID");
                Label lblProductID = (Label)e.Item.FindControl("lblProductID");
                Label lblProductName = (Label)e.Item.FindControl("lblProductName");
                Label lblProductCat = (Label)e.Item.FindControl("lblProductCat");
                Label lblQuantity = (Label)e.Item.FindControl("lblQuantity");
                Label lblPrice = (Label)e.Item.FindControl("lblPrice");
                Label lblDate = (Label)e.Item.FindControl("lblDate");
                Label lblTotal = (Label)e.Item.FindControl("lblTotal");


                int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "InvoiceID"));
                int nProductID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ProductID"));
                string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductName"));
                string sCatName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ProductCategoryName"));
                string sDate = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "DateBuy"));
                double dPrice = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Price"));
                double dTotal = Convert.ToDouble(DataBinder.Eval(e.Item.DataItem, "Total"));
                int nQuantity = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));

                lblID.Text= nID.ToString();
                lblProductID.Text = nProductID.ToString();
                lblProductName.Text = sProductName;
                lblProductCat.Text = sCatName;
                lblDate.Text = sDate;
                lblPrice.Text = dPrice.ToString() + "     $ ";
                lblQuantity.Text = nQuantity.ToString();
                double dTotal_round = Math.Round(dTotal, 2, MidpointRounding.AwayFromZero);
                lblTotal.Text = dTotal_round.ToString() + " $ ";
                fTotal += dPrice * nQuantity;

                lblTotalNumber.Text = "<span style=\"color:#D35638;font-weight:bold;\">" + fTotal.ToString() + " $ </span>";
            }
    }

    
}