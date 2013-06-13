<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="box_wrapper_title22">
            <div class="box_wrapper_title">
                <span class="title-icon"></span>
                <h1>
                    Login</h1>
            </div>
        </div>
        <div class="contentContainer loginPage first last">
            <div class="contentPadd">
                <div style="width: 49.5%; margin-left: 30%; border-left: 0px solid #e5e5e5;">
                    <div class="contentInfoText marg-bottom marg-top" style="position: relative; height: 160px;">
                        <table border="0" cellspacing="0" cellpadding="0" width="100%">
                            <tbody>
                                <tr>
                                    <td style="width: 80px; padding-top: 5px;">
                                        UserName
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtAccount" runat="server" CssClass="input" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Password
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="input"
                                            Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <div>
                            <asp:CheckBox ID="cbRemem" runat="server" Text="Remember Password" />
                            <br />
                            <div class="button__padd">
                                <strong class="button_content button_content2"><strong class="button bg_button"><strong
                                    class="button-t">
                                    <asp:LinkButton ID="lbtLogin" runat="server" class="ui-button " OnClick="lbtLogin_Click">
                                            <span class="ui-button-text">Login</span>
                                    </asp:LinkButton>
                                </strong></strong></strong>
                            </div>
                            <br />
                            <asp:Label ID="lblWarning" runat="server" Text="Login not successful! " Font-Size="11px" ForeColor="Red" Visible="false"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
