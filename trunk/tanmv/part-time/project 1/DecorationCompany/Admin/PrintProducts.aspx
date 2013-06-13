<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintProducts.aspx.cs" Inherits="Admin_PrintProducts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Exception Report</title>
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
            <asp:Label ID="Label1" runat="server" Text="PRODUCT  EXCEPTION REPORT" Font-Bold="True"
                Font-Size="17pt" ForeColor="#333333"></asp:Label>
            <br />
            --------------000--------------</div>

        <div>
            Date From : <asp:Label ID="lblDateFrom" runat="server" Text="Label"></asp:Label><br />
            Date To : <asp:Label ID="lblDateTo" runat="server" Text="Label"></asp:Label><br />
            <br />
            Sold product number <=2
        </div>
        <br />

        <table cellpadding="0" cellspacing="0" border="1" style="border-color: #C3C3C3;  height: 46px;">
            <tr style="border-bottom: 1px solid #969696; border-top: 1px solid #969696; background-color: #C3C3C3;">
                <td class="style_1" style="border-right: 1px solid #969696; color: #696969; vertical-align: middle;">
                    <asp:Label ID="Label5" runat="server" Text="Product ID" Font-Bold="True" ForeColor="#333333"></asp:Label>
                </td>
                <td class="style2" style="border-right: 1px solid #969696; color: #969696; vertical-align: middle;
                    text-align: center;">
                    <asp:Label ID="Label6" runat="server" Text="Product Name" Font-Bold="True" ForeColor="#333333"></asp:Label>
                </td>
                <td class="style1" style="border-right: 1px solid #969696; color: #969696; vertical-align: middle;
                    text-align: center;">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#333333" Text="Images"></asp:Label>
                </td>
                <td class="style1" style="border-left: 1px solid #969696; color: #969696; vertical-align: middle;
                    text-align: center;">
                    <asp:Label ID="Label7" runat="server" Text="Unit price " Font-Bold="True" ForeColor="#333333"></asp:Label>
                </td>
                <td class="style2" style="border-left: 1px solid #969696; color: #969696; vertical-align: middle;
                    text-align: center;">
                    <asp:Label ID="Label11" runat="server" Text="Number of product in stock" Font-Bold="True" ForeColor="#333333"></asp:Label>
                </td>
               
                
                
              
            </tr>
            <asp:Repeater ID="rptProduct" runat="server" OnItemDataBound="rptAdministrator_ItemDataBound" OnItemCommand="rptAdministrator_ItemCommand">
                <ItemTemplate>
                    <tr style="border-bottom: 1px solid #969696; border-top: 1px solid #969696; ">
                        <td class="style_1" style="border-right: 1px solid #969696; color: #696969; vertical-align: middle;">
                            <asp:Label ID="lblProductID" runat="server" Text="Code" Font-Bold="True" ForeColor="#333333"></asp:Label>
                            
                        </td>
                        <td class="style2" style="border-right: 1px solid #969696; color: #969696; vertical-align: middle;
                            text-align: center;">
                            <asp:Label ID="lblProductName" runat="server" Text="Name" Font-Bold="True" ForeColor="#333333"></asp:Label>
                        </td>
                       
                        <td class="style1" style="color: #969696; vertical-align: middle; text-align: center;">
                            <asp:Image ID="img" runat="server" Height="50px" Width="50px" />
                        </td>
                        <td class="style1" style="border-left: 1px solid #969696; color: #969696; vertical-align: middle;
                            text-align: center;">
                            <asp:Label ID="lblPrice" runat="server" Font-Bold="True" ForeColor="#333333"></asp:Label>
                        </td>
                        <td class="style2" style="border-left: 1px solid #969696; color: #969696; vertical-align: middle;
                            text-align: center;">
                            <asp:Label ID="lblStock" runat="server" Text="Date" Font-Bold="True" ForeColor="#333333"></asp:Label>
                        </td>
             
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <br />
        <asp:Button ID="Print" runat="server" Text="Print" onclick="Print_Click" />
    </div>
    </form>
</body>
</html>
