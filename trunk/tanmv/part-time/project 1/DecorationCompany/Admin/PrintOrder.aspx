<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintOrder.aspx.cs" Inherits="PrintOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print Order</title>
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
            <asp:Label ID="Label1" runat="server" Text="REPORT ORDERED" Font-Bold="True" Font-Size="17pt"
                ForeColor="#333333"></asp:Label>
            <br />
            --------------000--------------</div>
        <div>
            Date from :
            <asp:Label ID="lblDateFrom" runat="server" Text="Label"></asp:Label><br />
            Date to :
            <asp:Label ID="lblDateTo" runat="server" Text="Label"></asp:Label><br />
        </div>
        <br />
        <div class="content topad">
                   
                    
                   
                    <div class="section">
                        <table style="width: 100%; margin: 0 auto; border: 1px solid;">
                            <thead style="color: #fff; background: #423F3C;">
                                <tr>
                                    <th style="width: 70px; padding-left: 10px;font-size: 12px;">
                                        STT
                                    </th>
                                     <th style="width: 100px; padding-left: 10px;font-size: 12px;">
                                        Order Code 
                                    </th>
                                    <th style="width: 100px; padding-left: 10px;font-size: 12px;">
                                        Customer Name 
                                    </th>
                                    <th style="width: 170px; padding-left: 10px;font-size: 12px;">
                                        Phone
                                    </th>
                                    <th style="width: 200px; padding-left: 10px;font-size: 12px;">
                                        Address
                                    </th>
                                    <th style="width: 170px; padding-left: 10px;font-size: 12px;">
                                        Staff Name
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
                                   
                                   
                                </tr>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptReportOrder" runat="server" OnItemDataBound="rptProducts_ItemDataBound">
                                    <ItemTemplate>
                                        <tr style="height: 30px;">
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <%# Container.ItemIndex + 1 %>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
                                             
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblCustomerName" runat="server" Text="Label"></asp:Label>
                                             
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="StaffName" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                   
                </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Print" />
       
    </div>
    </form>
</body>
</html>
