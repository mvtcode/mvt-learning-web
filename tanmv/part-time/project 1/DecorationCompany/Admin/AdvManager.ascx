<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvManager.ascx.cs" Inherits="Admin_AdvManager" %>
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
<div>
    <asp:LinkButton ID="lbtAddnew" runat="server" CssClass="button-clean" Style="float: right;" onclick="lbtAddnew_Click">
        <span style="margin:0;"><img src="images/icon-plus.png" alt="Pin"/>Create new</span>
    </asp:LinkButton>
</div>
<div id="content">
    <div class="section">
        <div class="full">
            
            <div class="panel">
                <div class="title-large" style="width: 100%;">
                    <h2>
                        Advertisement Management</h2>
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
                                    Description
                                </th>
                                <th>
                                    Url
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
                            <asp:Repeater ID="rptAdv" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
                                OnItemDataBound="rptAdministrator_ItemDataBound">
                                <ItemTemplate>
                                    <tr class="gradeX" style="height: 30px;">
                                        <td>
                                            <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblUrl" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                        </td>
                                        <td>
                                            &nbsp;
                                        </td>
                                        <td style="width: 100px;">
                                            <asp:LinkButton ID="lnkEdit" runat="server" ToolTip="Edit" CommandName="Edit">Edit</asp:LinkButton>&nbsp;&nbsp;
                                            <asp:LinkButton ID="lnkDelete" runat="server"  OnClientClick="return confirmDelete();" ToolTip="Delete" CommandName="Delete">Delete</asp:LinkButton>
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
