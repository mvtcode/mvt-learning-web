﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NNND._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Ngoại ngữ Nam Du</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Language" content="vi" />
    <link rel="shortcut icon" href="/Images/favicon.ico" type="image/x-icon"/>
    <link href="/CSS/Styles.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.2/themes/smoothness/jquery-ui.css" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="http://code.jquery.com/ui/1.10.2/jquery-ui.js"></script>
    <script type="text/javascript">
        window.$zopim || (function (d, s) {
            var z = $zopim = function (c) { z._.push(c); }, $ = z.s =
                d.createElement(s), e = d.getElementsByTagName(s)[0]; z.set = function (o) {
                    z.set._.push(o);
                }; z._ = []; z.set._ = []; $.async = !0; $.setAttribute('charset', 'utf-8');
            $.src = '//cdn.zopim.com/?1H0Ytb9d0pB3uXjTVbsKB33yoLSDFpNr'; z.t = +new Date; $.type = 'text/javascript';
            e.parentNode.insertBefore($, e);
        })(document, 'script');
        $zopim(function () {
            $zopim.livechat.setLanguage('vi');
            $zopim.livechat.bubble.setTitle('Bạn cần giúp đỡ?');
            $zopim.livechat.bubble.setText('Nhấn vào để được hỗ trợ trực tuyến');
            $zopim.livechat.setGreetings({
                'online': ['Click để gửi câu hỏi', 'Cảm ơn bạn đã ghé thăm. Bạn có thắc mắc hay góp ý gì về dịch của chúng tôi, hãy nhập một câu hỏi, nhân viên CSKH sẽ chat với bạn để giải đáp.'],
                'offline': ['Click để gửi lời nhắn', 'Cảm ơn bạn đã ghé thăm. Hiện đang ngoài giờ hành chính hoặc nhân viên CSKH đi vắng, bạn vui lòng để lại câu hỏi hoặc lời nhắn, chúng tôi sẽ trả lời qua email cho bạn trong thời gian sớm nhất.'],
                'away': ['Click để gửi lời nhắn', 'Cảm ơn bạn đã ghé thăm. Hiện nhân viên CSKH đi vắng, bạn vui lòng để lại câu hỏi hoặc lời nhắn, chúng tôi sẽ trả lời qua email cho bạn trong thời gian sớm nhất.']
            });
        });

        $(document).ready(function () {
            var $left_floater = $("ul#left_floater li");
            $left_floater.hover(function () {
                $(this).animate({ left: '100px' }, 200);
            }
            , function () {
                $(this).animate({ left: '0px' }, 200);
            });
        });
    </script>
    <script>        function googleTranslateElementInit() { new google.translate.TranslateElement({ pageLanguage: 'vi', includedLanguages: 'zh-CN,zh-TW,en,fr,de,ja,ko,ru,vi', autoDisplay: false, layout: google.translate.TranslateElement.InlineLayout.SIMPLE }, 'google_translate_element'); }</script>
    <script src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
    <style>
        .menu_floater_left
        {
            cursor: pointer;
            height: 198px;
            left: -100px;
            position: fixed;
            top: 200px;
            width: 163px;
            z-index: 3;
        }
        ul#left_floater li
        {
            display: list-item;
            float: left;
            margin: 0;
            position: relative;
        }
        ul#left_floater li a.left_tintuc
        {
            background: url("http://ccard.vn/skin/white/css/img3/left_tintuc.jpg") no-repeat scroll right center #02AF1F;
            float: left;
            height: 66px;
            margin: 0;
            position: relative;
            width: 163px;
        }
        ul#left_floater li a.left_dangky
        {
            background: url("http://ccard.vn/skin/white/css/img3/left_dangky.jpg") no-repeat scroll right center #FC8200;
            float: left;
            height: 66px;
            margin: 0;
            position: relative;
            width: 163px;
        }
        ul#left_floater li a.left_muathe
        {
            background: url("http://ccard.vn/skin/white/css/img3/left_muathe.jpg") no-repeat scroll right center #FC3A00;
            float: left;
            height: 66px;
            margin: 0;
            position: relative;
            width: 163px;
        }
        ul#left_floater li a.left_kichhoathe
        {
            background: url("http://ccard.vn/skin/white/css/img3/left_kichhoatthe_ccard.jpg") no-repeat scroll right center #92278F;
            float: left;
            height: 66px;
            margin: 0;
            position: relative;
            width: 163px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <%--<div id="BDBridgeIconWrap" style="text-align: left; display: block; width: 25px; height: 68px; position: fixed; top: 50%; left: 0px; margin-left: 8px; margin-top: -59px; overflow: hidden;">
        nằm im ở đây!
    </div>--%>
    <div style="top: 40%;" class="menu_floater_left">
        <ul id="left_floater">
            <li style="left: 0px;"><a href="/tin-tuc/index.htm" class="left_tintuc"></a></li>
            <li style="left: 0px;"><a href="/dang-ky.html" class="left_dangky"></a></li>
            <%--<li style="left: 0px;"><a href="/Mua-the/index.htm" class="left_muathe"></a></li>
            <li style="left: 0px;"><a href="/kich-hoat-the.html" class="left_kichhoathe"></a></li>--%>
        </ul>
    </div>
    <div id="MainBody">
        <div id="page">
            <div id="header">
                <div style="color: white; font-family: tahoma; font-size: 12px; font-weight: bold;
                    width: 160px; display: block; float: left; text-align: center;">
                    <h1>
                        Ngoại ngữ<br />
                        Nam Du</h1>
                </div>
                <div style="display: inline-block; width: 3px; height: 60px; margin-right: 10px;
                    background: white; float: left;">
                </div>
                <div style="color: #b2511c; font-family: tahoma; height: 60px; font-size: 18px; font-weight: bold;
                    width: 550px; display: block; float: left; text-align: center;">
                    <h2>
                        Lớp tập huấn tiếng hoa cấp tốc
                        <br />
                        đầu tiên tại Việt Nam</h2>
                </div>
                <div style="color: white; font-family: tahoma; font-size: 12px; font-weight: bold;
                    text-align: left;">
                    <h3>
                        Học thử trong phạm vi toàn cầu: 20:00-22:00
                        <br />
                        thứ 6 hàng tuần (giờ Hà Nội)<br />
                        Skype: ngoaingunamdu</h3>
                </div>
            </div>
            <div class="clear">
            </div>
            <div id="banner">
                <img src="/Images/site_Tham_Khao.jpg" title="site tham khảo" style="width: 100%"
                    alt="site tham khảo" />
                <img src="/Images/banner_bottom.jpg" title="Thông tin thêm" style="width: 100%" alt="Thông tin thêm" />
            </div>
            <div class="clear">
            </div>
            <div id="Content">
                <!--1-->
                <div class="TitleYellow">Title 1</div>
                <div class="FlashPlayerFrame">
                    <object width="100%" height="775" title="粤语学习01" id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"
                        style="visibility: inherit;">
                        <param value="http://player.youku.com/player.php/sid/XMjQ5NjU5MTU2/v.swf" name="movie">
                        <param value="high" name="quality">
                        <param value="opaque" name="wmode">
                        <param value="6.0.65.0" name="swfversion">
                        <param value="http://cama35.com/Scripts/expressInstall.swf" name="expressinstall">
                        <!--[if !IE]>-->
                        <object width="100%" height="775" data="http://player.youku.com/player.php/sid/XMjQ5NjU5MTU2/v.swf"
                            type="application/x-shockwave-flash">
                            <!--<![endif]-->
                            <param value="high" name="quality">
                            <param value="opaque" name="wmode">
                            <param value="6.0.65.0" name="swfversion">
                            <param value="http://cama35.com/Scripts/expressInstall.swf" name="expressinstall">
                            <div>
                                <h4>
                                    Download Adobe Flash Player。</h4>
                                <p>
                                    <a href="http://www.adobe.com/go/getflashplayer">
                                        <img width="112" height="33" alt="Download Adobe Flash Player" src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif"></a></p>
                            </div>
                            <!--[if !IE]>-->
                        </object>
                        <!--<![endif]-->
                    </object>
		        </div>
                <div class="DetailBot"></div>
                <!--2-->
                <div class="TitleYellow">Tite 2</div>
                <div class="CommentTop">Này thì comment</div>
                <div class="FlashPlayerFrame">
                    <object width="100%" height="775" title="粤语学习01" id="FlashID2" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"
                        style="visibility: inherit;">
                        <param value="http://player.youku.com/player.php/sid/XMjYzMDQzNjQ0/v.swf" name="movie">
                        <param value="high" name="quality" />
                        <param value="opaque" name="wmode">
                        <param value="6.0.65.0" name="swfversion">
                        <param value="http://cama35.com/Scripts/expressInstall.swf" name="expressinstall">
                        <!--[if !IE]>-->
                        <object width="100%" height="775" data="http://player.youku.com/player.php/sid/XMjYzMDQzNjQ0/v.swf"
                            type="application/x-shockwave-flash">
                            <!--<![endif]-->
                            <param value="high" name="quality">
                            <param value="opaque" name="wmode">
                            <param value="6.0.65.0" name="swfversion">
                            <param value="http://cama35.com/Scripts/expressInstall.swf" name="expressinstall">
                            <div>
                                <h4>
                                    Download Adobe Flash Player</h4>
                            </div>
                            <!--[if !IE]>-->
                        </object>
                        <!--<![endif]-->
                    </object>
	            </div>
                <div class="Advantise2"><img alt="" src="Images/adv2.jpg" /></div>
                <!--3-->
                <div class="TitleYellow">Title 3</div>
                <div class="FlashPlayerFrame">
                    <object width="100%" height="775" title="粤语学习01" id="FlashID3" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"
                        style="visibility: inherit;">
                        <param value="http://player.youku.com/player.php/sid/XMjQ5NjU5MTU2/v.swf" name="movie">
                        <param value="high" name="quality">
                        <param value="opaque" name="wmode">
                        <param value="6.0.65.0" name="swfversion">
                        <param value="http://cama35.com/Scripts/expressInstall.swf" name="expressinstall">
                        <!--[if !IE]>-->
                        <object width="100%" height="773" data="http://player.youku.com/player.php/sid/XMjQ5NjU5MTU2/v.swf"
                            type="application/x-shockwave-flash">
                            <!--<![endif]-->
                            <param value="high" name="quality">
                            <param value="opaque" name="wmode">
                            <param value="6.0.65.0" name="swfversion">
                            <param value="http://cama35.com/Scripts/expressInstall.swf" name="expressinstall">
                            <div>
                                <h4>
                                    Download Adobe Flash Player。</h4>
                                <p>
                                    <a href="http://www.adobe.com/go/getflashplayer">
                                        <img width="112" height="33" alt="Download Adobe Flash Player" src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif"></a></p>
                            </div>
                            <!--[if !IE]>-->
                        </object>
                        <!--<![endif]-->
                    </object>
	            </div>
                <div class="Advantise3"><img src="Images/adv3.JPG" /></div>
                <!--4-->
                    <div class="clear"></div>
                <div id="Content4">
                    <div class="TitleWhite">Title 4</div>
                    <div class="clear"></div>
                    <div class="ContentBg">
                        <img src="Images/Detail4.PNG" />
                    </div>
                </div>
                <div class="DetailBot"></div>
                <!--5-->
                <div id="Content5">
                    <div class="TitleWhite">Title 5</div>
                    <div class="AdvantiseTop"><img src="Images/adv5.PNG" /></div>
                    <img src="Images/5.png" width="100%" />
                </div>
                <a href="http://tieba.baidu.com/f?kz=1039355702">
                    </a>
                <img src="Images/diengiai5.png" width="100%" />
                <!--6-->
                <img src="Images/6.png" width="100%" />
                <img src="Images/diengiai6.png" width="100%" />
                <!--7-->
                <img src="Images/7.png" width="100%" />
                <!--8-->
                <img src="Images/8.png" />
                <img src="Images/9.png" width="100%" />
                <img src="Images/sach1.png" width="100%" />
                <img src="Images/cd2.png" width="100%" />
                <img src="Images/ngoai3.png" width="100%" />
                <img src="Images/sau3.png" width="100%" />
                <img src="Images/tongketmorong.png" width="100%" />
                <img src="Images/ex1.png" width="100%" />
            </div>
            <div id="facebook">
                <div id="fb-root">
                </div>
                <script>
                    (function (d, s, id) {
                        var js, fjs = d.getElementsByTagName(s)[0];
                        if (d.getElementById(id)) return;
                        js = d.createElement(s); js.id = id;
                        js.src = "//connect.facebook.net/en_US/all.js#xfbml=1&appId=368428579925646";
                        fjs.parentNode.insertBefore(js, fjs);
                    } (document, 'script', 'facebook-jssdk'));
                </script>
                <div class="fb-comments" data-href="http://ngoaingunamdu.com" data-width="940" data-num-posts="10">
                </div>
                <div class="fb-like" data-href="http://ngoaingunamdu.com" data-send="true" data-width="940"
                    data-show-faces="true">
                </div>
                <%--<div class="fb-facepile" data-href="http://ngoaingunamdu.com" data-action="like" data-size="large" data-max-rows="1" data-width="300"></div>
                <div class="fb-send" data-href="http://ngoaingunamdu.com" data-font="tahoma"></div>--%>
                <%--<div class="fb-activity" data-site="http://ngoaingunamdu.com" data-width="300" data-height="300" data-header="true" data-recommendations="false"></div>--%>
            </div>
            <div id="bottom">
                <img src="Images/bottom.jpg" width="100%" />
            </div>
        </div>
    </div>
    </form>
    <script type="text/javascript">
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments);
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
        m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g;
            m.parentNode.insertBefore(a, m);
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');
        ga('create', 'UA-40217379-2', 'ngoaingunamdu.com');
        ga('send', 'pageview');
    </script>
</body>
</html>
