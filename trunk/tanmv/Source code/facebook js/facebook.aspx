<%@ Page Language="C#" AutoEventWireup="true" CodeFile="facebook.aspx.cs" Inherits="facebook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns:fb="http://ogp.me/ns/fb#">
<head runat="server">
    <title>Test facebook</title>
    <meta property="fb:app_id" content="265184206952303" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="fb-root">
        </div>
        <div class="fb-comments" data-href="http://theviet.vn/voucher/Nha-Hang-Quan-An/nha-hang-an-lac11.htm"
            data-width="670px" data-num-posts="10">
        </div>
        <script language="javascript" type="text/javascript">
            (function (d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) return;
                js = d.createElement(s);
                js.id = id;
                js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1&appId=265184206952303";
                fjs.parentNode.insertBefore(js, fjs);
            }
            (document, 'script', 'facebook-jssdk')); 
        </script>
        <%--<div class="fb-like" data-send="true" data-width="450" data-show-faces="true">--%>
        <fb:like send="true" width="450" show_faces="true"></fb:like>
        </div>
        <script>
            setTimeout(function () {
//                FB.getLoginStatus(function (response) {
//                    if (response.status === 'connected') {
//                        // the user is logged in and has authenticated your
//                        // app, and response.authResponse supplies
//                        // the user's ID, a valid access token, a signed
//                        // request, and the time the access token 
//                        // and signed request each expire
//                        var uid = response.authResponse.userID;
//                        var accessToken = response.authResponse.accessToken;
//                    } else if (response.status === 'not_authorized') {
//                        // the user is logged in to Facebook, 
//                        // but has not authenticated your app
//                    } else {
//                        // the user isn't logged in to Facebook.
//                    }
//                });
//                FB.login(function (response) {
//                    if (response.authResponse) {
//                        console.log('Welcome!  Fetching your information.... ');
//                        FB.api('/me', function (response) {
//                            console.log('Good to see you, ' + response.name + '.');
//                        });
//                    } else {
//                        console.log('User cancelled login or did not fully authorize.');
//                    }
//                });
                              
//                FB.ui({
//                    method: 'feed',
//                    name: 'The Facebook SDK for Javascript',
//                    caption: 'Bringing Facebook to the desktop and mobile web',
//                    description: (
//                  'A small JavaScript library that allows you to harness ' +
//                  'the power of Facebook, bringing the user\'s identity, ' +
//                  'social graph and distribution power to your site.'
//               ),
//                    link: 'https://developers.facebook.com/docs/reference/javascript/',
//                    picture: 'http://www.fbrell.com/public/f8.jpg'
//                },
//              function (response) {
//                  if (response && response.post_id) {
//                      alert('Post was published.');
//                  } else {
//                      alert('Post was not published.');
//                  }
//              });

              FB.api('/me', function (response) {
                  alert('Your name is ' + response.name);
              });
            }, 3000);
        </script>
    </div>
    </form>
</body>
</html>
