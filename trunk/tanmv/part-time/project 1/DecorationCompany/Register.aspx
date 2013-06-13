<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="box_wrapper_title22">
            <div class="box_wrapper_title">
                <span class="title-icon"></span>
                <h1>
                    Register
                </h1>
            </div>
        </div>
        <div class="contentContainer off first last">
            <div class="contentPadd">
                <div>
                    <h3 class="first_h3">
                         Personal Infomation</h3>
                </div>
                <div class="contentInfoText">
                    <table border="0" cellspacing="2" cellpadding="2" width="100%">
                        <tbody>
                            <tr>
                                <td class="fieldKey">
                                    Sex:
                                </td>
                                <td class="fieldValue radio">
                                    <div>
                                        <asp:RadioButton ID="rdbMale" runat="server" Text="Male" GroupName="sex" Checked="true" />
                                    </div>
                                    <div>
                                        <asp:RadioButton ID="rdbFeMale" runat="server" Text="FeMale" GroupName="sex" />&nbsp;<span
                                            class="inputRequirement">*</span>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    Name :
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtFullName" runat="server" class="input"></asp:TextBox>&nbsp;<span
                                        class="inputRequirement">*</span>
                                    <asp:RequiredFieldValidator ID="rfvName" runat="server" SetFocusOnError="true" ControlToValidate="txtFullName"
                                        Display="Dynamic" ValidationGroup="Admin" Text="Please enter your name !" Font-Size="11px"
                                        ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    UserName :
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtUserName" runat="server" class="input"></asp:TextBox>&nbsp;<span
                                        class="inputRequirement">*</span>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true"
                                        ControlToValidate="txtUserName" Display="Dynamic" ValidationGroup="Admin" Text="Please enter username !"
                                        Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revPasslengh" runat="server" ValidationExpression="\w{6,100}"
                                        ControlToValidate="txtUserName" ValidationGroup="Admin" SetFocusOnError="True"
                                        Text="Username must be at least 6 characters.Try again !" Display="Dynamic" Style="text-shadow: none;" Font-Size="11px"
                                        ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    Password:
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="input"></asp:TextBox>
                                    &nbsp;<span class="inputRequirement">*</span>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true"
                                        ControlToValidate="txtPassword" Display="Dynamic" ValidationGroup="Admin" Text="Please enter password !"
                                        Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>

                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w{6,100}"
                                        ControlToValidate="txtPassword" ValidationGroup="Admin" SetFocusOnError="True"
                                        Text="Password must be at least 6 characters. Try again !" Display="Dynamic" Style="text-shadow: none;" Font-Size="11px"
                                        ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    Re-Password:
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtRepassword" runat="server" TextMode="Password" class="input"></asp:TextBox>
                                    &nbsp;<span class="inputRequirement">*</span>
                                    <asp:CompareValidator ID="cpvPassword" runat="server" ControlToValidate="txtPassword"
                                        SetFocusOnError="true" Operator="Equal" Type="String" ControlToCompare="txtRepassword"
                                        ValidationGroup="Admin" Text="Re-password do not match !" Font-Size="11px" Style="text-shadow: none;"
                                        ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    D.O.B:
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtBirthDay" runat="server" class="input hasDatepicker"></asp:TextBox>
                                    &nbsp;<span class="inputRequirement"> (Ejem. 21/05/1970)</span><script type="text/javascript">                                                                                                       jQuery(document).ready(function () { $('#dob').datepicker({ dateFormat: 'dd/mm/yy', changeMonth: true, changeYear: true, yearRange: '-100:+0' }); })</script>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    Email:
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtEmail" runat="server" class="input"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true"
                                        ControlToValidate="txtEmail" Display="Dynamic" ValidationGroup="Admin" Text="Please enter your emaill address !"
                                        Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                                        Font-Size="11px" SetFocusOnError="True" Text="Please enter a valid email address !"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Admin"
                                        Display="Dynamic" Style="text-shadow: none;" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    Phone:
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtPhone" runat="server" class="input"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldKey">
                                    Addess:
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtAddess" runat="server" class="input"></asp:TextBox>
                                    &nbsp;<span class="inputRequirement">*</span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <h3>
                    Identity Card Number </h3>
                <div class="contentInfoText">
                    <table border="0" cellspacing="2" cellpadding="2" width="100%">
                        <tbody>
                            <tr>
                                <td class="fieldKey">
                                    Your Identity Card Number :
                                </td>
                                <td class="fieldValue">
                                    <asp:TextBox ID="txtCMT" runat="server" class="input"></asp:TextBox>
                                    &nbsp;<span class="inputRequirement">*</span>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true"
                                        ControlToValidate="txtCMT" Display="Dynamic" ValidationGroup="Admin" Text="Please enter your ID Card !"
                                        Font-Size="11px" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="buttonSet fl_right" style="width: 510px;">
                    <div class="button__padd" style="margin-right: 20px; float: left;">
                        <strong class="button_content button_content2"><strong class="button bg_button"><strong
                            class="button-t">
                            <asp:LinkButton ID="lbtRegister" runat="server" class="ui-button " OnClick="lbtRegister_Click"
                                ValidationGroup="Admin">
                                            <span class="ui-button-text" >Register</span>
                            </asp:LinkButton>
                        </strong></strong></strong>
                    </div>
                    <div class="button__padd">
                        <strong class="button_content button_content2"><strong class="button bg_button"><strong
                            class="button-t">
                            <asp:LinkButton ID="lbtReset" runat="server" class="ui-button " OnClick="lbtReset_Click">
                                            <span class="ui-button-text">Reset</span>
                            </asp:LinkButton>
                        </strong></strong></strong>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
