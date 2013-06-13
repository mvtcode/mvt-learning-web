<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintCustomerSummary.aspx.cs"
    Inherits="Admin_PrintInvoiceSummary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Report Customer Summary</title>
    <link href="css/style-explorer.css" rel="stylesheet" type="text/css" />
    <link href="css/style-calendar.css" rel="stylesheet" type="text/css" />
    <link href="css/style-custom.css" rel="stylesheet" type="text/css" />
    <link href="css/styler.css" rel="stylesheet" type="text/css" />
    <link href="css/Calendar/jquery-ui-1.8.14.custom.css" rel="stylesheet" type="text/css" />
    <link href="css/css_menu.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-color: #fff;">
    <form id="form1" runat="server">
    <div style="margin: 0 auto; width: 900px;">
        <div style="margin: 0; width: 900px;">
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="13pt" ForeColor="#333333"
                Text="NGUYEN DAI DUONG HOME DECORATION COMPANY"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Addess : 215 - Thai Ha -Dong Da - Ha Noi"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email : NguyenDaiDuong_Company@gmail.com"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Website : daiduongcompany.com.vn"></asp:Label>
        </div>
        <div style="margin: 0; width: 900px; text-align: center; padding-top: 50px; padding-bottom: 20px;">
            <asp:Label ID="Label1" runat="server" Text="CUSTOMER  SUMMARY REPORT" Font-Bold="True"
                Font-Size="17pt" ForeColor="#333333"></asp:Label>
            <br />
            --------------000--------------</div>
        <div>
            Date From :
            <asp:Label ID="lblDateFrom" runat="server" Text="Label"></asp:Label><br />
            Date To :
            <asp:Label ID="lblDateTo" runat="server" Text="Label"></asp:Label><br />
        </div>
        <br />
        <div id="container" class="clearfix fixed fluid_">
            <div id="content">
                <div class="section" style="display: none;">
                    <div class="content">
                        <div id="exp-bar-chart" class="charts">
                        </div>
                    </div>
                </div>
                <div class="section">
                    <div class="large">
                        <div class="content">
                            <div id="exp-bar-pie" class="charts">
                            </div>
                        </div>
                    </div>
                    <div class="large" style="display: none;">
                        <div class="panel">
                            <div class="title">
                                <h4>
                                    Zone Chart</h4>
                                <div class="theme">
                                </div>
                                <div class="drop">
                                </div>
                            </div>
                            <div class="content">
                                <div id="exp-bar-zone" class="charts">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="section" style="display: none;">
                    <div class="content">
                        <div id="exp-line-chart" class="charts">
                        </div>
                    </div>
                </div>
                <table class="chartData" style="display: none;">
                    <caption>
                        2013 Report Summary</caption>
                    <thead>
                        <tr>
                            <td>
                            </td>
                            <th scope="col">
                                January
                            </th>
                            <th scope="col">
                                February
                            </th>
                            <th scope="col">
                                March
                            </th>
                            <th scope="col">
                                April
                            </th>
                            <th scope="col">
                                May
                            </th>
                            <th scope="col">
                                June
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">
                                Le Van A
                            </th>
                            <td>
                                3
                            </td>
                        </tr>
                         <tr>
                            <th scope="row">
                                Le Van B
                            </th>
                            <td>
                                5
                            </td>
                        </tr>
                         <tr>
                            <th scope="row">
                                Le Van C
                            </th>
                            <td>
                                2
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                All
                            </th>
                            <td>
                                20
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    </form>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui.min.js"></script>
    <script type="text/javascript" src="js/explorer-extra.js"></script>
    <script type="text/javascript" src="js/explorer-custom.js"></script>
</body>
</html>
