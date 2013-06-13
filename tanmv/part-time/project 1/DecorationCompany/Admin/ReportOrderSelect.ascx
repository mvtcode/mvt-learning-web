<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportOrderSelect.ascx.cs"
    Inherits="Admin_ReportOrderSelect" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Report Order Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad" style="padding-left: 10px;">
                    <div>
                        <span>Date from</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateFrom" runat="server" CssClass="DatepickerInput" ValidationGroup="sale"
                            Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateFrom" Display="Dynamic" ValidationGroup="sale"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="sale"
                            Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateTo" Display="Dynamic" ValidationGroup="sale" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="btSale" runat="server" ValidationGroup="sale" Text="Print Report Sales"
                            OnClick="btSale_Click" />
                    </div>
                    <div class="hr">
                    </div>
                    <div>
                       <%--  <span>Print report summary</span> &nbsp;&nbsp;--%>
                        <asp:Button ID="btChart" runat="server" Text="Print Report Summary" 
                             onclick="btChart_Click" Visible="False" />
                    </div>
                    <div class="hr">
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
                                <asp:Repeater ID="rptInvoiceDetails" runat="server" OnItemCommand="rptAdministrator_ItemCommand"
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
                                                <asp:LinkButton ID="lnkEdit" runat="server" ToolTip="Report" CommandName="report">Report</asp:LinkButton>
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
