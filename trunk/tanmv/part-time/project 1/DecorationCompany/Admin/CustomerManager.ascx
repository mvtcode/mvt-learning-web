<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomerManager.ascx.cs" Inherits="Admin_AdministratorManager" %>
<%@ Register src="Warning.ascx" tagname="Warning" tagprefix="uc1" %>
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
<uc1:Warning ID="Warning2" runat="server" />
    
<div id="content">
    <uc1:Warning ID="Warning1" runat="server" />
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Customer Management</h2>
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
                                    Name
                                </th>
                                <th>
                                    Phone
                                </th>
                                <th>
                                    Email
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
                            <asp:Repeater ID="rptCustomer" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
                                OnItemDataBound="rptAdministrator_ItemDataBound">
                                <ItemTemplate>
                                    <tr class="gradeX" style="height:30px;">
                                        <td>
                                            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;                                        </td>
                                        <td style="width:100px;">
                                            <asp:LinkButton ID="lnkEdit" runat="server" ToolTip="Edit" CommandName="Edit">Edit</asp:LinkButton>&nbsp;&nbsp;
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
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
