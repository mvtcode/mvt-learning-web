<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Report.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Report Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad" style="padding-left: 10px;">
                <h1>
                        Report products</h1>
                    <br />
                    <div>
                        <span>Product category</span>
                        <asp:DropDownList ID="ddlProducts" runat="server">
                        </asp:DropDownList>
                        <asp:Button ID="Button1" runat="server" ValidationGroup="order" 
                            Text="Report Products" onclick="Button1_Click" />
                    </div>
                    <div class="hr">
                    </div>
                    <h1>
                        Report ordered products</h1>
                    <br />
                    <div>
                        <span>Date from</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtOrderDateFrom" runat="server" CssClass="DatepickerInput" ValidationGroup="order"
                            Width="100px" />
                            <asp:RequiredFieldValidator ID="rfvFrom" runat="server" SetFocusOnError="true" ControlToValidate="txtOrderDateFrom"
                            Display="Dynamic" ValidationGroup="order" Text="Please enter date from !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtOrderDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="order"
                            Width="100px" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true" ControlToValidate="txtOrderDateTo"
                            Display="Dynamic" ValidationGroup="order" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="btOrder" runat="server" ValidationGroup="order" Text="Report Ordered"
                            OnClick="btOrder_Click" />
                    </div>
                    <div class="hr">
                    </div>




                    <h1>
                        Report product sales</h1>
                    <br />
                    <div>
                        <span>Date from</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateFrom" runat="server" CssClass="DatepickerInput" ValidationGroup="sale" Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true" ControlToValidate="txtSaleDateFrom"
                            Display="Dynamic" ValidationGroup="sale" Text="Please enter date fom !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <span>Date to</span>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSaleDateTo" runat="server" CssClass="DatepickerInput" ValidationGroup="sale"  Width="100px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true" ControlToValidate="txtSaleDateTo"
                            Display="Dynamic" ValidationGroup="sale" Text="Please enter date to !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                        <asp:Button ID="btSale" runat="server" ValidationGroup="sale" 
                            Text="Report Sales" onclick="btSale_Click" />
                    </div>
                    <div class="hr">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
