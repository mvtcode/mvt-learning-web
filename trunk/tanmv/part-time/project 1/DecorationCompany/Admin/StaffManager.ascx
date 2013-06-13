<%@ Control Language="C#" AutoEventWireup="true" CodeFile="StaffManager.ascx.cs" Inherits="Admin_AdministratorManager" %>
<%@ Register src="Warning.ascx" tagname="Warning" tagprefix="uc1" %>

<uc1:Warning ID="Warning2" runat="server" />
<div>
    <asp:LinkButton ID="lbtAddnew" runat="server" CssClass="button-clean" Style="float: right;" onclick="lbtAddnew_Click">
        <span style="margin:0;"><img src="images/icon-plus.png" alt="Pin"/>Create new</span>
    </asp:LinkButton>
</div>
<div id="content">
    <uc1:Warning ID="Warning1" runat="server" />
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Staff Management</h2>
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
                                    
                                </th>
                                <th>
                                    
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
                            <asp:Repeater ID="rptStaff" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
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
                                            <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;                                        </td>
                                        <td style="width:100px;">
                                            <asp:LinkButton ID="lnkEdit" runat="server" ToolTip="Edit" CommandName="Edit">Edit</asp:LinkButton>&nbsp;&nbsp;
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
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
