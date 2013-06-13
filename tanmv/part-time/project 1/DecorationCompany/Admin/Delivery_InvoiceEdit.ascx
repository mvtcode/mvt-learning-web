﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Delivery_InvoiceEdit.ascx.cs"
    Inherits="Admin_AdministratorEdit" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Delivery Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                
                    <div class="section">
                        <span class="label" style="width:120px;">Staff Name : </span>
                        <asp:DropDownList ID="ddlStaff" runat="server">
                        </asp:DropDownList>
                          
                        <asp:Label ID="lblStaffID" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="lblIInoiveDetails" runat="server" Visible="false"></asp:Label>
                        
                    </div>
                    <div class="section">
                        <span class="label" style="width:120px;"> Date : </span>
                        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                    </div>
                    
                    <div class="section">
                        <span class="label" style="width:120px;">List products  </span>
                    </div>
                    <div class="section">
                        <table style="width: 96%; margin: 0 auto; border: 1px solid;">
                            <thead style="color: #fff; background: #423F3C;">
                                <tr>
                                    <th style="width: 70px; padding-left: 10px;">
                                        STT
                                    </th>
                                    <th style="width: 384px;">
                                        Products Name
                                    </th>
                                    <th style="width: 187px;">
                                        Price
                                    </th>
                                    <th style="width: 163px;">
                                        Quantity
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
                                </tr>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptProducts" runat="server" onitemdatabound="rptProducts_ItemDataBound">
                                    <ItemTemplate>
                                        <tr style="height: 30px;">
                                            <td style="padding-left: 10px; border-right: 1px solid;border-bottom: 1px dotted;">
                                                <%# Container.ItemIndex + 1 %>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid;border-bottom: 1px dotted;">
                                                <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                                                <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                            </td>
                                           <td style="padding-left: 10px; border-right: 1px solid;border-bottom: 1px dotted;">
                                                <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid;border-bottom: 1px dotted;">
                                                <asp:Label ID="lblNumber" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                    <div class="section">
                        <span class="label" style="width:120px;">Total : </span>
                        <asp:Label ID="lblTotalNumber" runat="server" Text="Label"></asp:Label>
                    </div>
                    <div class="section">
                        <span class="label" style="width:120px;">Status </span>
                        <asp:DropDownList ID="ddlStatus" runat="server">
                            <asp:ListItem Value="0">Not yet approved</asp:ListItem>
                            <asp:ListItem Value="1">Done</asp:ListItem>
                            
                        </asp:DropDownList>
                    </div>
                    <div class="section">
                       
                        <span class="label" style="width:120px;">&nbsp;</span>
                        <asp:Button ID="btUpdate" runat="server" Text="Update" OnClick="btUpdate_Click" />
                        &nbsp;
                          <asp:Button ID="BtPrint" runat="server" Text="Print Order" 
                            onclick="BtPrint_Click" />
                        &nbsp;
                        <asp:Button ID="btCancel" runat="server" Text="Cancel" OnClick="btCancel_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
