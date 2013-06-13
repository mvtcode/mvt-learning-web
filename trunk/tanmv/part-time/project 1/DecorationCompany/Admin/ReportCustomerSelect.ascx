<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportCustomerSelect.ascx.cs"
    Inherits="Admin_ReportCustomerSelect" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                         Customer Report Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad" style="padding-left: 10px;">
                    <div>
                        <span>From Date</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateFrom" runat="server" CssClass="DatepickerInput" ValidationGroup="product"  Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateFrom" Display="Dynamic" ValidationGroup="sale"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>To Date</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="sale"
                            Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateTo" Display="Dynamic" ValidationGroup="product" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="btProductReport" runat="server" ValidationGroup="product" Text="Print Details Report"
                            OnClick="btOrder_Click" />
                    </div>
                    <div class="hr">
                    </div>
 
                     <div >
                 
                       <%--  <span>Date from</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="txtDateFrom2" runat="server" CssClass="DatepickerInput" 
                             ValidationGroup="product2"  Width="100px" Visible="False" />
                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateFrom2" Display="Dynamic" ValidationGroup="product2"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="txtDateTo2" runat="server" CssClass="DatepickerInput" ValidationGroup="product2"
                            Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateTo2" Display="Dynamic" ValidationGroup="product2" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                        <asp:Button ID="btChart" runat="server" Text="Print Exception" 
                             ValidationGroup="product2" onclick="btChart_Click1" Visible="False"
                            />
                    </div>
                    <div class="hr">
                    <div><br />
                        <%-- <span>Date from</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="DatepickerInput" 
                            ValidationGroup="product3"  Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" SetFocusOnError="true"
                            ControlToValidate="TextBox1" Display="Dynamic" ValidationGroup="product3"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="DatepickerInput" ValidationGroup="product3"
                            Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" SetFocusOnError="true"
                            ControlToValidate="TextBox2" Display="Dynamic" ValidationGroup="product3" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                        <asp:Button ID="Button1" runat="server" Text="Print Summary"  
                             ValidationGroup="product3" onclick="Button1_Click" Visible="False" 
                            />
                    </div>
                    <div class="hr">
                    </div>
                    <div class="content topad" style="display:none;">
                        <table class="tabularData">
                            <thead>
                                <tr>
                                    <th>
                                        STT
                                    </th>
                                    <th>
                                        Code
                                    </th>
                                    <th>
                                        Customer Name
                                    </th>
                                    <th>
                                        Email
                                    </th>
                                    <th>
                                        Phone
                                    </th>
                                    <th>
                                        Address
                                    </th>

                                    <th>
                                        CMT
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
                                                <asp:Label ID="lblCustomerName" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblCMT" runat="server" Text="Label"></asp:Label>
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
