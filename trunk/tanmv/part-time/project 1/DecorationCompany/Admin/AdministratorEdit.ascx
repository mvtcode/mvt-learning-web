<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdministratorEdit.ascx.cs"
    Inherits="Admin_AdministratorEdit" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Administrator Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <div class="section">
                        <span class="label">Full Name *</span>
                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" SetFocusOnError="true" ControlToValidate="txtName"
                            Display="Dynamic" ValidationGroup="Admin" Text="Please enter your name !" Font-Size="11px"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="section">
                        <span class="label">Username *</span>
                        <asp:TextBox ID="txtUserName" runat="server" Width="200px" Enabled="false"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUserName" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtUserName" Display="Dynamic" ValidationGroup="Admin" Text="Please enter Username !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="section">
                        <span class="label">Password *</span>
                        <asp:TextBox ID="txtPassword" runat="server" Width="200px" TextMode="Password" Enabled="false"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPass" runat="server" Enabled="false" SetFocusOnError="true"
                            ControlToValidate="txtPassword" Display="Dynamic" ValidationGroup="Admin" Text="Please enter your password !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPasslengh" runat="server" ValidationExpression="\w{6,100}"
                            ControlToValidate="txtPassword" ValidationGroup="Admin" SetFocusOnError="True"
                            Text="Passwords must be at least 6 characters" Display="Dynamic" Style="text-shadow: none;"
                            ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
                    <div class="section">
                        <span class="label">Re-Password *</span><asp:TextBox ID="txtRePassword" runat="server"
                            Width="200px" TextMode="Password" Enabled="false"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvRePass" runat="server" Enabled="false" SetFocusOnError="true"
                            ControlToValidate="txtRePassword" Display="Dynamic" ValidationGroup="Admin" Text="Please enter your re-password!"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cpvPassword" runat="server" ControlToValidate="txtPassword"
                            SetFocusOnError="true" Operator="Equal" Type="String" ControlToCompare="txtRePassword"
                            ValidationGroup="Admin" Text="Re-password do not match !" Font-Size="11px" ForeColor="Red"
                            Display="Dynamic"></asp:CompareValidator>
                    </div>
                    <div class="section">
                        <span class="label">Email *</span>
                        <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" SetFocusOnError="true" ControlToValidate="txtEmail"
                            Display="Dynamic" ValidationGroup="Admin" Text="Please enter your email address !"
                            Font-Size="11px" Style="text-shadow: none;" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                            Font-Size="11px" SetFocusOnError="True" Text="Please enter a valid email address !"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Admin"
                            Display="Dynamic" Style="text-shadow: none;" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
                    <div class="section">
                        <span class="label">Phone</span><asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
                    </div>
                    <div class="section">
                        <span class="label">Address</span><asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"
                            Width="400px" Rows="3"></asp:TextBox>
                    </div>
                    <div class="section">
                        <span class="label">Role User</span>
                        <asp:DropDownList ID="ddlRole" runat="server">
                        </asp:DropDownList>
                    </div>
                    <div class="section">
                        <asp:Label ID="lblPassword" runat="server" Visible="false"></asp:Label>
                        <span class="label">&nbsp;</span>
                        <asp:Button ID="btUpdate" runat="server" Text="Update" OnClick="btUpdate_Click" ValidationGroup="Admin" />
                        &nbsp;
                        <asp:Button ID="btCancel" runat="server" Text="Cancel" OnClick="btCancel_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
