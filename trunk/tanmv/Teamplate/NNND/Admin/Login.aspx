<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NNND.Admin.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
	<title>Login - Cpanel</title>
	<script type="text/javascript" src="./js/jquery.js"></script>
	<script type="text/javascript" src="./js/jquery.query-2.1.7.js"></script>
	<script type="text/javascript" src="./js/rainbows.js"></script>
	<link type="text/css" rel="stylesheet" href="css/login.css" media="screen" />
<script type="text/javascript">
    $(document).ready(function () {
        $("#submit1").hover(
	    function () {
	        $(this).animate({ "opacity": "0" }, "slow");
	    },
	    function () {
	        $(this).animate({ "opacity": "1" }, "slow");
	    });
	});
    
    function ForgotPass() {
        alert('Contact to Administrator');
    }
</script>
</head>
<body>
	<div id="wrapper">
		<div id="wrappertop"></div>
		<div id="wrappermiddle">
			<h2>Login</h2>
			<div id="username_input">
				<div id="username_inputleft"></div>
				<div id="username_inputmiddle">
					<input type="text" class="input" name="link" id="username" value="username" onclick="this.value = ''">
					<img id="url_user" src="./images/mailicon.png" alt="">
				</div>
				<div id="username_inputright"></div>
			</div>
			<div id="password_input">
				<div id="password_inputleft"></div>
				<div id="password_inputmiddle">
					<input type="password" class="input" name="link" id="password" value="Password" onclick="this.value = ''">
					<img id="url_password" src="./images/passicon.png" alt="">
				</div>
				<div id="password_inputright"></div>
			</div>
			<div id="submit">
				<input type="image" src="./images/submit_hover.png" id="submit1" value="Sign In">
				<input type="image" src="./images/submit.png" id="submit2" value="Sign In">
			</div>
			<div id="links_left">
			<a href="javascript:void(0)" onclick="ForgotPass()">Forgot your Password?</a>
			</div>
			<%--<div id="links_right"><a href="#">Not a Member Yet?</a></div>--%>
		</div>
		<div id="wrapperbottom"></div>
		<div id="powered">
		<p>Powered by <a href="http://www.facebook.com/macvantan">Mạc Văn Tân</a></p>
		</div>
	</div>
</body>
</html>