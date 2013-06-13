<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintOrderSummary.aspx.cs"
    Inherits="Admin_PrintOrderSummary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Order Summary</title>
    <link href="css/style-explorer.css" rel="stylesheet" type="text/css" />
    <link href="css/style-calendar.css" rel="stylesheet" type="text/css" />
    <link href="css/style-custom.css" rel="stylesheet" type="text/css" />
    <link href="css/styler.css" rel="stylesheet" type="text/css" />
    <link href="css/Calendar/jquery-ui-1.8.14.custom.css" rel="stylesheet" type="text/css" />
    <link href="css/css_menu.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="container" class="clearfix fixed fluid_">
        <div id="content">
            <div class="section" style="display: none;">
                <div class="full">
                    <div class="panel charts">
                        <div class="title-large">
                            <h2>
                                Bar Charts</h2>
                            <div class="theme">
                            </div>
                            <div class="drop">
                            </div>
                        </div>
                        <div class="content">
                            <div id="exp-bar-chart" class="charts">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="section" style="display: none;">
                <div class="large">
                    <div class="panel">
                        <div class="title">
                            <h4>
                                Pie Chart</h4>
                            <div class="theme">
                            </div>
                            <div class="drop">
                            </div>
                        </div>
                        <div class="content">
                            <div id="exp-bar-pie" class="charts">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="large">
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
            <div class="section">
                <div class="content">
                    <div id="exp-line-chart" class="charts">
                    </div>
                </div>
            </div>
            <table class="chartData" style="display: none;">
                <caption>
                    2013 Order report</caption>
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
                        <th scope="col">
                            July
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">
                            Order total
                        </th>
                        <td>
                            <asp:Label ID="lblT1" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblT2" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblT3" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblT4" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblT5" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblT6" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblT7" runat="server"></asp:Label>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui.min.js"></script>
    <script type="text/javascript" src="js/explorer-extra.js"></script>
    <script type="text/javascript" src="js/explorer-custom.js"></script>
</body>
</html>
