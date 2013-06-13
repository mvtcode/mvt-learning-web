<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportProductCategorySelect.ascx.cs" Inherits="Admin_ReportProductCategorySelect" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Report Category Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad" style="padding-left: 10px;">
                    <div>

                        <span>Date from</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateFrom" runat="server" CssClass="DatepickerInput" ValidationGroup="product"  Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateFrom" Display="Dynamic" ValidationGroup="product"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="product"
                            Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtSaleDateTo" Display="Dynamic" ValidationGroup="product" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="btProductReport" runat="server" ValidationGroup="product" Text="Print Detail Report"
                            OnClick="btOrder_Click" />
                    </div>
                    <div class="hr">
                    </div>
                     <div>

                        <span>Date from</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtDateFrom2" runat="server" CssClass="DatepickerInput" ValidationGroup="product2"  Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateFrom2" Display="Dynamic" ValidationGroup="product2"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtDateTo2" runat="server" CssClass="DatepickerInput" ValidationGroup="product2"
                            Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateTo2" Display="Dynamic" ValidationGroup="product2" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" ValidationGroup="product2" 
                             Text="Print Exeption Report" onclick="Button1_Click"/>
                    </div>
                    <div class="hr">
                    </div>
                    <div>
                         <span>Date from</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtDateFrom3" runat="server" CssClass="DatepickerInput" ValidationGroup="product3"  Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateFrom3" Display="Dynamic" ValidationGroup="product3"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtDateTo3" runat="server" CssClass="DatepickerInput" ValidationGroup="product3"
                            Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateTo3" Display="Dynamic" ValidationGroup="product3" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="btChart" runat="server" ValidationGroup="product3" Text="Print Report Summary" 
                             onclick="btChart_Click" />
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
                                        Category Name
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
                                                <asp:Label ID="lblCategoryName" runat="server" Text="Label"></asp:Label>
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
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>