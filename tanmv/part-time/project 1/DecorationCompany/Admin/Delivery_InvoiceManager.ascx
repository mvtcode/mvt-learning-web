<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Delivery_InvoiceManager.ascx.cs" Inherits="Admin_BannerManager" %>
<%@ Register src="Warning.ascx" tagname="Warning" tagprefix="uc1" %>

<uc1:Warning ID="Warning1" runat="server" />

<div id="content">
    <div class="section">
        <div class="full">
            
            <div class="panel">
                <div class="title-large" style="width: 100%;">
                    <h2>
                        Delivery Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <table class="tabularData">
                        <thead>
                            <tr>
                                <th>
                                    Customer
                                </th>
                                <th>
                                    Date
                                </th>
                                <th>
                                   Status
                                </th>
                                <th>
                                   &nbsp;
                                </th>
                                
                                <th>
                                   &nbsp;
                                </th>
                                
                                <th>
                                    Setting
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rptDelivery" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
                                OnItemDataBound="rptAdministrator_ItemDataBound">
                                <ItemTemplate>
                                    <tr class="gradeX" style="height: 30px;">
                                        <td>
                                            <asp:Label ID="lblCustomer" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                           <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                        </td>
                                        
                                        <td>
                                            &nbsp;
                                        </td>
                                        
                                        <td style="width: 100px;">
                                           <asp:LinkButton ID="lnkEdit" runat="server" ToolTip="Delete" CommandName="Edit">View</asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" ToolTip="Delete" CommandName="Delete">Delete</asp:LinkButton>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                        <tfoot>
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
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
