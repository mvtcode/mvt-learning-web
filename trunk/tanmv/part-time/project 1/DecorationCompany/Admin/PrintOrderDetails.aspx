<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintOrderDetails.aspx.cs" Inherits="Admin_PrintOrderDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Report Order Details</title>
     <link href="css/style-report.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 0 auto; width: 900px;">
        <div style="margin: 0; width: 900px;">
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
            <asp:Label ID="Label1" runat="server" Text="REPORT ORDER DETAILS" Font-Bold="True"
                Font-Size="17pt" ForeColor="#333333"></asp:Label>
            <br />
            --------------000--------------</div>
        <div class="content topad">
            <div class="section">
                <span class="label" style="width: 120px;">Order Code : </span>
                <asp:Label ID="lblCodeOrder" runat="server" Text="Label"></asp:Label>
                
            </div>
            <div class="section">
                <span class="label" style="width: 120px;">Staff Name : </span>
                <asp:Label ID="lblStaff" runat="server" Text="Label"></asp:Label>
                
            </div>
           <div class="section">
                <span class="label" style="width: 120px;">Date : </span>
                <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                
            </div>
            <br />
            <div class="section">
                <table style="width: 100%; margin: 0 auto; border: 1px solid;">
                    <thead style="color: #fff; background: #423F3C;">
                        <tr>
                            <th style="width: 150px; padding-left: 10px;">
                                Product Code
                            </th>
                            <th style="width: 300px;">
                                Products Name
                            </th>
                            <th style="width: 100px;">
                                Price
                            </th>
                            <th style="width: 100px;">
                                Quantity
                            </th>
                            <th style="width: 200px;">
                                Category
                            </th>
                            <th style="width: 150px;">
                                Date
                            </th>
                            <th style="width: 150px;">
                                Total
                            </th>
                        </tr>
                    </thead>
                    <tfoot style="color: #fff; background: #423F3C;">
                        <tr>
                            <th>
                                &nbsp;
                            </th>
                            <th>
                                &nbsp;
                            </th>
                            <th>
                                &nbsp;
                            </th>
                            <th>
                                &nbsp;
                            </th>
                            <th>
                                &nbsp;
                            </th>
                            <th>
                                &nbsp;
                            </th>
                            <th>
                                &nbsp;
                            </th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <asp:Repeater ID="rptProducts" runat="server" OnItemDataBound="rptProducts_ItemDataBound">
                            <ItemTemplate>
                                <tr style="height: 30px;">
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblProductID" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblQuantity" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblCategory" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                        <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
                <br />
                <br />
                <div>
                    Amount (in numbers) :
                    <asp:Label ID="lblTotalNumber" runat="server" Text="Label"></asp:Label></div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
