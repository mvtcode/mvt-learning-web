<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BannerEdit.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Banner Management</h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <div class="section">
                        <span class="label">Category</span>
                        <asp:DropDownList ID="ddlCategoryLv1" runat="server">
                        </asp:DropDownList>
                    </div>
                    <div class="section">
                        <span class="label">Url *</span>
                        <asp:TextBox ID="txtUrl" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvURL" runat="server" SetFocusOnError="true" ControlToValidate="txtUrl"
                            Display="Dynamic" ValidationGroup="Admin" Text="Please enter Url !" Font-Size="11px"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="section">
                        <span class="label">Description *</span>
                        <asp:TextBox ID="txtDescription" runat="server" Width="400px" TextMode="MultiLine"
                            Rows="3"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDescription" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtDescription" Display="Dynamic" ValidationGroup="Admin"
                            Text="Please enter Username !" Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
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
