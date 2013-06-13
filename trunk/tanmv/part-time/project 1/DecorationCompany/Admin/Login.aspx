<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login Adminítrator</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <link href="css/style-explorer.css" rel="stylesheet" type="text/css" />
    <link href="css/style-calendar.css" rel="stylesheet" type="text/css" />
    <link href="css/style-custom.css" rel="stylesheet" type="text/css" />
    <link href="css/styler.css" rel="stylesheet" type="text/css" />

    <!--[if lt IE 9]>		<link rel="stylesheet" type="text/css" href="css/style-ie.css" /> 	<![endif]-->

    <link href="css/css-family=Droid+Sans-regular,bold.css" rel="stylesheet" type="text/css">
    <link href="css/css?family=PT+Sans+Narrow" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <div id="container" class="clearfix fixed fluid_" style="margin-top: 100px;">
        <div id="content">
            <div class="exp-form">
                <div class="exp-wrapper">
                    <div class="brand">
                        <!--<img src="images/login-form-logo.png" alt="" />-->
                        <h1 style="padding-top: 30px; font-size: 30px;">
                            Login Administrator</h1>
                    </div>
                    <div class="hr">
                    </div>
                    <div id="exp-login" class="form">
                        <label>
                            Username</label>
                        <div class="input">
                            <asp:TextBox ID="txtUser" runat="server"  CssClass="text"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser"
                                ErrorMessage="(*)"></asp:RequiredFieldValidator>
                        </div>
                        <label>
                            Password</label>
                        <div class="input">
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="text" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                                ErrorMessage="(*)"></asp:RequiredFieldValidator>
                        </div>
                        <div class="clearfix">
                           
                            <asp:Button ID="btLogin" runat="server" Text="Login" OnClick="btLogin_Click" CssClass="submit right" />
                        </div>
                        <asp:Label ID="lbStatus" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="hr">
                    </div>
                    <div class="options clearfix">
                        <a href="#" class="btn-recovery">Password recovery<span>You forgot your password?</span></a>
                        <a href="#" class="btn-register">Register account<span>Register a new accound here!</span></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--  #container  -->
    <div id="style-background">
    </div>
    <div id="style-shadow">
    </div>
    </form>
</body>
</html>
