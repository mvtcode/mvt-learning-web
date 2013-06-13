<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsEdit.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        News Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <div class="section">
                        <span class="label">Category</span>
                        <asp:DropDownList ID="ddlCategoryLv2" runat="server">
                        </asp:DropDownList>
                    </div>
                    <div class="section">
                        <span class="label">Name *</span>
                        <asp:TextBox ID="txtName" runat="server" Width="400px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvURL" runat="server" SetFocusOnError="true" ControlToValidate="txtName"
                            Display="Dynamic" ValidationGroup="Admin" Text="Please enter name !" Font-Size="11px"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="section">
                        <span class="label">Image </span>
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="300px" />
                        <asp:Label ID="lblImage" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="lblImageWarning" runat="server" Visible="false"></asp:Label>
                    </div>
                    <div class="section" style="margin-left:140px;">
                        <asp:Image ID="img" runat="server" Width="150px" />
                     </div>
                    <div class="section">
                        <span class="label">InitContent </span>
                        <asp:TextBox ID="txtInit" runat="server" Width="400px" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                    
                    <div class="section">
                        <span class="label">Content </span>
                                               
                    </div>
                    <div class="section" style="padding-left:140px;">
                        <CKEditor:CKEditorControl ID="txtContent" runat="server" Width="95%" ></CKEditor:CKEditorControl>
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
