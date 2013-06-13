<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportProductSelect.ascx.cs"
    Inherits="Admin_ReportProductSelect" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Report Products Management</h2>
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
                            ControlToValidate="txtSaleDateFrom" Display="Dynamic" ValidationGroup="sale"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="sale"
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
                        <%--<span>Date from</span> &nbsp;&nbsp;--%>
                         <asp:TextBox ID="txtDateFrom" runat="server" CssClass="DatepickerInput" 
                            ValidationGroup="product2"  Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateFrom" Display="Dynamic" ValidationGroup="sale"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="txtDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="product2"
                            Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateTo" Display="Dynamic" ValidationGroup="product2" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;--%>
                        <asp:Button ID="btChartException" runat="server" Text="Print Exception Report" 
                            ValidationGroup="product2" onclick="btChartException_Click" 
                            Visible="False" />
                    </div>
                    <div class="hr">
                    </div>
                       <div>
                        <%--<span>Date from</span> &nbsp;&nbsp;--%>
                         <asp:TextBox ID="txtDateFrom3" runat="server" CssClass="DatepickerInput" 
                               ValidationGroup="product3"  Width="100px" Visible="False" />
                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateFrom3" Display="Dynamic" ValidationGroup="sale"
                            Text="Please enter date fom !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;--%>
                        <asp:TextBox ID="txtDateTo3" runat="server" CssClass="DatepickerInput" ValidationGroup="product3"
                            Width="100px" Visible="False" />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDateTo3" Display="Dynamic" ValidationGroup="product3" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;--%>
                        <asp:Button ID="btSummary" runat="server" Text="Print Summary Report" 
                               OnClick="btChart_Click" ValidationGroup="product3" Visible="False" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
