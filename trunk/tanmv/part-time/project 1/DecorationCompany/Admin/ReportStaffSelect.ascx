<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportStaffSelect.ascx.cs"
    Inherits="Admin_ReportStaffSelect" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                         Staff Management Report</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad" style="padding-left: 10px;">
                    <div>
                        <span>Staff Detail Report</span> &nbsp;&nbsp;
                        <asp:Button ID="btProductReport" runat="server" ValidationGroup="order" Text="Print Report Staff"
                            OnClick="btOrder_Click" />
                    </div>
                    <div class="hr">
                    </div>
                    <div>
                        <%--<span>Date from</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="txtSaleDateFrom" runat="server" CssClass="DatepickerInput" ValidationGroup="product"
                            Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateFrom" Display="Dynamic" ValidationGroup="sale"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="txtSaleDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="sale"
                            Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateTo" Display="Dynamic" ValidationGroup="product"
                            Text="Please enter date to !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp; <span>Print report summary</span> &nbsp;&nbsp;--%>
                        <asp:Button ID="btChart" runat="server" Text="Print Report Summary" 
                            ValidationGroup="product" OnClick="btChart_Click" Visible="False" />
                    </div>
                    <div class="hr">
                        <div class="content topad">
                            <table class="tabularData">
                                <thead>
                                    <tr>
                                        <th>
                                            No
                                        </th>
                                        <th>
                                            Staff Code
                                        </th>
                                        <th>
                                            Staff Name
                                        </th>
                                        <th>
                                           
                                        </th>
                                        <th>
                                           
                                        </th>
                                        <th>
                                            Setting
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rptProduct" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
                                        OnItemDataBound="rptAdministrator_ItemDataBound">
                                        <ItemTemplate>
                                            <tr class="gradeX" style="height: 30px;">
                                                <td>
                                                    <%# Container.ItemIndex + 1 %>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblCode" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblStaffName" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td style="width: 100px;">
                                                    <asp:LinkButton ID="lnkEdit" runat="server" ToolTip="Edit" CommandName="report">Report Details</asp:LinkButton>&nbsp;&nbsp;
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
    </div>
