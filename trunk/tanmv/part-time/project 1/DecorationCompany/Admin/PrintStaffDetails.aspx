<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintStaffDetails.aspx.cs" Inherits="Admin_PrintStaffDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Category Details</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            
        }
        .style2
        {
            width: 167px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0 auto;width:700px;">
          
          <div style="margin:0;width:699px;">
              <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="13pt" ForeColor="#333333"
                Text="NGUYEN DAI DUONG HOME DECORATION COMPANY"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Addess : 215 - Thai Ha -Dong Da - Ha Noi"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email : NguyenDaiDuong_Company@gmail.com"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Website : daiduongcompany.com.vn"></asp:Label>
        </div>
        <div style="margin: 0; width: 700px; text-align: center; padding-top: 50px; padding-bottom: 20px;">
            <asp:Label ID="Label1" runat="server" Text="REPORT STAFF DETAILS" Font-Bold="True"
                Font-Size="17pt" ForeColor="#333333"></asp:Label>
            <br />
                --------------000--------------</div>
         <table class="style1" cellpadding="0" cellspacing="0" border="1" 
                style="border-color:#C3C3C3;margin-bottom:100px;">
                <tr style="border-bottom:1px solid #C3C3C3;border-top:1px solid #C3C3C3;">
                    <td class="style2" style="border-right:1px solid #C3C3C3;color:#696969;vertical-align:middle;">
                       Code : </td>
                    <td style="color:#696969;">
                        &nbsp;<asp:Label ID="lblCode" runat="server"></asp:Label>
                        &nbsp;</td>
                </tr>
                <tr style="border-bottom:1px solid #C3C3C3;border-top:1px solid #C3C3C3;">
                    <td class="style2" style="border-right:1px solid #C3C3C3;color:#696969;vertical-align:middle;">
                       Staff Name : </td>
                    <td style="color:#696969;">
                        &nbsp;<asp:Label ID="lblStaffName" runat="server"></asp:Label>
                        &nbsp;</td>
                </tr>
                <tr style="border-bottom:1px solid #C3C3C3;border-top:1px solid #C3C3C3;">
                    <td class="style2" style="border-right:1px solid #C3C3C3;color:#696969;vertical-align:middle;">
                       Phone : </td>
                    <td style="color:#696969;">
                        &nbsp;<asp:Label ID="lblPhone" runat="server"></asp:Label>
                        &nbsp;</td>
                </tr>
                <tr style="border-bottom:1px solid #C3C3C3;border-top:1px solid #C3C3C3;">
                    <td class="style2" style="border-right:1px solid #C3C3C3;color:#696969;vertical-align:middle;">
                       Address : </td>
                    <td style="color:#696969;">
                        &nbsp;<asp:Label ID="lblAddress" runat="server"></asp:Label>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
