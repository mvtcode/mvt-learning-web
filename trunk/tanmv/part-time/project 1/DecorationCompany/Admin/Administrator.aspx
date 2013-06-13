<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Administrator.aspx.cs" Inherits="Admin_Administrator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <title>Administrator</title>
    <link href="css/style-explorer.css" rel="stylesheet" type="text/css" />
    <link href="css/style-calendar.css" rel="stylesheet" type="text/css" />
    <link href="css/style-custom.css" rel="stylesheet" type="text/css" />
    <link href="css/styler.css" rel="stylesheet" type="text/css" />
    <link href="css/Calendar/jquery-ui-1.8.14.custom.css" rel="stylesheet" type="text/css" />
    <link href="css/css_menu.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Form1" runat="server">
    <div id="header">
        <div class="nav-wrapper-left">
            <div class="nav-wrapper-right">
                <ul class="nav">
                    <li class="logo" style="width: 500px;">
                        <h1 style="padding-top: 20px; font-size: 25px;">
                            Nguyen Dai Duong - Home Decorating
                        </h1>
                        <h4>
                            Administrator</h4>
                    </li>
                    <li>
                        <img src="images/icons/nav/icon-settings.png" alt="tools" />
                        <h3>
                            <asp:LinkButton ID="lbtRestore" runat="server" Style="color: #626161; text-align: center;
                                line-height: 20px; font-size: 15px; text-decoration: none;" OnClick="lbtRestore_Click">Restore</asp:LinkButton>
                        </h3>
                        <span style="padding-left: 27px">Restore Data</span>
                        <div class="sel">
                        </div>
                    </li>
                    <li>
                        <img src="images/icons/nav/icon-backup.png" alt="tools" />
                        <h3>
                            <asp:LinkButton ID="lbtbackupDB" runat="server" OnClick="lbtbackupDB_Click" Style="color: #626161;
                                text-align: center; line-height: 20px; font-size: 15px; text-decoration: none;">Backup</asp:LinkButton>
                        </h3>
                        <span style="padding-left: 27px">Save Data</span>
                        <div class="sel">
                        </div>
                    </li>
                    <li style="width: 150px; padding-left: 100px; padding-top: 25px; height: 100px;">Hi
                        ,
                        <asp:Label ID="lbUserName" runat="server" ForeColor="#6D6D6D" Font-Size="14px"></asp:Label>
                        &nbsp;
                        <asp:LinkButton ID="lbtLogout" runat="server" CssClass="button-clean" Style="float: right;"
                            OnClick="lbtLogout_Click" CausesValidation="False">
                            <span style="margin:0;text-align:left"><img src="images/icon-minus.png" alt="Pin" style="padding:0;"/> Logout </span>
                        </asp:LinkButton>
                        <div class="sel">
                        </div>
                    </li>
                </ul>
            </div>
        </div>
        <div id="notice-wrapper-left">
            <div id="notice-wrapper-right">
                <div style="width: 960px; height: 40px; margin: 0 auto; padding: 0;">
                    <div runat="server" class="cssmenu">
                        <ul>
                            <li id="system_li" runat="server"  class='has-sub '><a href='#' style="line-height: 40px;"><span>System Management</span></a>
                                <ul>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkAdmin" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=admin">Account Management</asp:HyperLink>
                                    </li>
                                </ul>
                            </li>
                            <li id="interface_li" runat="server" class='has-sub '><a href='#' style="line-height: 40px;"><span>Interface Management</span></a>
                                <ul>
                                    <li class='has-sub'>
                                        <asp:HyperLink ID="lnkAdv" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=adv">Advertisement Management</asp:HyperLink>
                                    </li>
                                    <li class='has-sub'>
                                        <asp:HyperLink ID="lnkBanner" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=banner">Banner Management</asp:HyperLink>
                                    </li>
                                    <li class='has-sub'>
                                        <asp:HyperLink ID="lnkNews" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=news">News Management</asp:HyperLink>
                                    </li>
                                    <li class='has-sub'>
                                        <asp:HyperLink ID="lnkCatLv1" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=lv1">Category Lv1 Management</asp:HyperLink>
                                    </li>
                                    <li class='has-sub'>
                                        <asp:HyperLink ID="lnkCatLv2" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=lv2">Category Lv2 Management</asp:HyperLink>
                                    </li>
                                </ul>
                            </li>
                            <li id="manager_1" runat="server" class='has-sub '><a href='#' style="line-height: 40px;"><span>Category Managenment</span></a>
                                <ul>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkProductCat" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=procat">Products Type Managenment</asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkProduct" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=pro">Products Managenment</asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkStaff" runat="server" href="Administrator.aspx?page=staff">Staff Managenment</asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkCustomer" runat="server" NavigateUrl="Administrator.aspx?page=customer">Customer Managenment</asp:HyperLink>
                                    </li>
                                </ul>
                            </li>
                            <li id="manager_2" runat="server" class='has-sub '><a href='#' style="line-height: 40px;"><span>Order Management</span></a>
                                <ul>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkInvoiceDetails" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=invoicedetails">Order View</asp:HyperLink>
                                    </li>
                                </ul>
                            </li>
                           <li id="manager_3" runat="server" class='has-sub '><a href='#' style="line-height: 40px;"><span>Invoice Management</span></a>
                                <ul>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkInvoice" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=invoice"><span>Invoice View</span></asp:HyperLink>
                                    </li>
                                </ul>
                            </li>
                            <li id="manager_4" runat="server" class='has-sub '><a href='#' style="line-height: 40px;"><span>Report Management</span></a>
                                <ul>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkReportInvoice" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=rpinvoicesl"><span>Invoice Report Management</span></asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkReportOrder" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=rpordersl"><span>Order Report Management</span></asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkReportType" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=rpcategorysl"><span>Products Type Report Management</span></asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkReportProduct" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=rpproductsl"><span>Products Report Management</span></asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkReportStaff" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=rpstaffsl"><span>Staff Report Management</span></asp:HyperLink>
                                    </li>
                                    <li class='has-sub '>
                                        <asp:HyperLink ID="lnkReportCustomer" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=rcustomersl"><span>Customer Report Management</span></asp:HyperLink>
                                    </li>
                                </ul>
                            </li>
                            
                        </ul>
                    </div>
                    <div>
                    <asp:HyperLink ID="lnkChart" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=chart" Visible="false">Chart</asp:HyperLink>
                        <asp:HyperLink ID="lnkDelivery" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=delivery"
                            Visible="false">Delivery</asp:HyperLink>
                        <asp:HyperLink ID="lnkReport" runat="server" NavigateUrl="~/Admin/Administrator.aspx?page=report"
                            Visible="false">Report</asp:HyperLink>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="container" class="clearfix fixed fluid_">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <!-- Webtunes Styler -->
    </div>
    <!--  #container  -->
    <div id="style-background">
    </div>
    <div id="style-shadow">
    </div>
    </form>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui.min.js"></script>
    <script type="text/javascript" src="js/explorer-extra.js"></script>
    <script type="text/javascript" src="js/explorer-custom.js"></script>
    <script src="js/Calendar/jquery.ui.core.js" type="text/javascript"></script>
    <script src="js/Calendar/jquery.ui.widget.js" type="text/javascript"></script>
    <script src="js/Calendar/jquery.ui.datepicker.js" type="text/javascript"></script>
    <script src="js/Calendar/DatePickerDemo.js" type="text/javascript"></script>
</body>
</html>
