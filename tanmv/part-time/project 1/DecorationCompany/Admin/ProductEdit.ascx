<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductEdit.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Product Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <div class="section">
                        <span class="label">Category</span>
                        <asp:DropDownList ID="ddlProductCategory" runat="server">
                        </asp:DropDownList>
                    </div>
                    <div class="section">
                        <span class="label">Product Name *</span>
                        <asp:TextBox ID="txtProductName" runat="server" Width="400px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvURL" runat="server" SetFocusOnError="true" ControlToValidate="txtProductName"
                            Display="Dynamic" ValidationGroup="Admin" Text="Please enter product name !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="section">
                        <span class="label">Price *</span>
                        <asp:TextBox ID="txtPrice" runat="server" Width="400px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtPrice" Display="Dynamic" ValidationGroup="Admin" Text="Please enter product price !"
                            Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>

                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtPrice"
                            SetFocusOnError="true" Operator="GreaterThan" Type="Integer"
                            ValidationGroup="Admin" Text="Please endter a vaild Price  !" Font-Size="11px" ForeColor="Red"
                            Display="Dynamic" ValueToCompare="0"></asp:CompareValidator>

                    </div>
                    <div class="section">
                        <span class="label">Stock</span>
                        <asp:TextBox ID="txtStock" runat="server" Width="50px"></asp:TextBox>
                       <asp:CompareValidator ID="cpvPassword" runat="server" ControlToValidate="txtStock"
                            SetFocusOnError="true" Operator="GreaterThan" Type="Integer"
                            ValidationGroup="Admin" Text="Please endter a vaild Stock  !" Font-Size="11px" ForeColor="Red"
                            Display="Dynamic" ValueToCompare="0"></asp:CompareValidator>
                    </div>
                    <div class="section">
                        <span class="label">Image </span>
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="300px" />
                        <asp:Label ID="lblImage" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="lblImageWarning" runat="server" Visible="false"></asp:Label>
                    </div>
                    <div class="section" style="margin-left: 140px;">
                        <asp:Image ID="img" runat="server" Width="150px" />
                    </div>
                    <div class="section">
                        <span class="label">InitContent </span>
                        <asp:TextBox ID="txtInit" runat="server" Width="400px" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                    <div class="section">
                        <span class="label">Content </span>
                    </div>
                    <div class="section" style="padding-left: 140px;">
                        <CKEditor:CKEditorControl ID="txtContent" runat="server" Width="95%"></CKEditor:CKEditorControl>
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
