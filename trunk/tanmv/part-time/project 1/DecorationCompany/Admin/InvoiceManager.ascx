<%@ Control Language="C#" AutoEventWireup="true" CodeFile="InvoiceManager.ascx.cs" Inherits="Admin_BannerManager" %>
<%@ Register src="Warning.ascx" tagname="Warning" tagprefix="uc1" %>

<uc1:Warning ID="Warning1" runat="server" />
<script type="text/javascript" language="javascript">
    function confirmDelete() {
        var ok = confirm("Do you want to delete?");
        if (ok == true) {
            return true;
        }
        else {
            return false;
        }
    }
</script>
<div id="content">
    <div class="section">
        <div class="full">
            
            <div class="panel">
                <div class="title-large" style="width: 100%;">
                    <h2>
                        Invoice Management</h2>
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
                                    ProductName
                                </th>
                                <th>
                                    Image
                                </th>
                                <th>
                                   Price
                                </th>
                                <th>
                                   Number
                                </th>
                                
                                <th>
                                   Date buy
                                </th>
                                
                                <th>
                                    Setting
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rptInvoice" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
                                OnItemDataBound="rptAdministrator_ItemDataBound">
                                <ItemTemplate>
                                    <tr class="gradeX" style="height: 30px;">
                                        <td>
                                            <asp:Label ID="lblProduct" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td style="padding-top:5px;">
                                            <asp:Image ID="imgProduct" runat="server" Width="50px" />
                                        </td>
                                        <td>
                                           <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblNumber" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        
                                        <td>
                                           <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        
                                        <td style="width: 100px;">
                                           
                                            <asp:LinkButton ID="lnkDelete" runat="server" OnClientClick="return confirmDelete();" ToolTip="Delete" CommandName="Delete">Delete</asp:LinkButton>
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
