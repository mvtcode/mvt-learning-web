<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuTop.ascx.cs" Inherits="Control_MenuTop" %>
<asp:MultiView ID="MultiView1" runat="server">
    <asp:View ID="View1" runat="server">
        <div class="box_header_user_menu">
            <ul class="user_menu">
                <li class="">
                    <a href="Register.aspx">
                    <div class="button-t">
                        <span>Create an Account</span>
                    </div>
                    </a>
                </li>
                <li class="">
                    <a href="Login.aspx">
                        <div class="button-t">
                            <span>Log in</span>
                        </div>
                    </a>
                </li>
            </ul>
        </div>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <div class="box_header_user_menu">
            <ul class="user_menu">
                <li class="">
                    <div class="button-t">
                       Hello <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label> &nbsp;&nbsp;|&nbsp;&nbsp; 
                        <asp:LinkButton ID="lbtLogOut" runat="server" onclick="lbtLogOut_Click">Logout</asp:LinkButton>
                    </div>

                </li>
            </ul>
        </div>
    </asp:View>
</asp:MultiView>
