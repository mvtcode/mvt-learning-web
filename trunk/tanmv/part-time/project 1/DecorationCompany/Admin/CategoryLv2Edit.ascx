<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CategoryLv2Edit.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Category Lv2 Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <div class="section">
                        <span class="label"> Category Name *</span>
                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvURL" runat="server" SetFocusOnError="true" ControlToValidate="txtName"
                            Display="Dynamic" ValidationGroup="Admin" Text="Please enter product category name !" Font-Size="11px"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="section">
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
