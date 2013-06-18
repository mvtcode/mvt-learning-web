<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NNND._Default" %>

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
            background: url("/Images/Background/left_hotro.jpg") no-repeat scroll right center #02AF1F;
            float: left;
            height: 66px;
            margin: 0;
            position: relative;
            width: 163px;
        }
        ul#left_floater li a.left_dangky
        {
            background: url("/Images/Background/left_dangky.jpg") no-repeat scroll right center #FC8200;
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
            <li style="left: 0px;"><a href="ymsgr:sendIM?ngoaingunamdu" class="left_tintuc"></a></li>
            <li style="left: 0px;"><a href="javascript:void(0)" class="left_dangky"></a></li>
        </ul>
    </div>
    <div id="MainBody">
        <div id="page">
            <div id="header">
                <div style="text-align: center; display: block; float: left; margin-right: 17px; margin-top: 10px; width: 250px; font-weight: bold">
                    <div style="color: #00572e; font-family: tahoma; font-size: 11px;">
                        <h1>Ngoại ngữ Nam Du</h1>
                    </div>
                    <div style="color: rgb(136, 33, 29); padding-top: 0px; margin-top: 6px; margin-bottom: 0px; size: 20px; font-size: 24px;">
                        南愉國際外語學院
                    </div>
                    <div style="color: white; font-style: italic; margin-top: 6px; font-weight: bold; font-size: 12px; padding-left: 10px; text-align: center;">
                        Tương lai cho các bạn, sự nghiệp của chúng tôi
                    </div>
                </div>
                <div style="display: inline-block; width: 2px; height: 70px; margin: 20px 10px 10px;background: red url('Images/Background/bgLineHeader.jpg'); float: left;">
                </div>
                <div style=" font-weight: bold; width: 690px; display: block; float: left; text-align: center;  background: url('Images/Background/logo-online.png') no-repeat scroll 240px 0px transparent; margin-top: 0px; padding-top: 17px;">
                    <div style="color: #882118; font-family: tahoma; height: 46px;font-size: 14px;" >
                        <h2>Lớp tập huấn tiếng Hoa&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;cấp tốc đầu tiên tại Việt Nam</h2>
                    </div>
                    <div style="color: black;font-size: 18px;text-shadow: 0px 2px 2px #fff, 0px 4px 2px #fff /*1*/, 0px -2px 2px #fff, 0px -4px 2px #fff/*2*/, 2px 0px 2px #fff, 4px 0px 2px #fff/*3*/, -2px 0px 2px #fff, -4px 0px 2px #fff/*4*/, 2px 2px 2px #fff, 4px 4px 2px #fff/*11*/, -2px -2px 2px #fff, -4px -4px 2px #fff/*22*/, -2px 2px 2px #fff, -4px 4px 2px #fff/*33*/, 2px -2px 2px #fff, 4px -4px 2px #fff/*44*/;">
                        <h2>Chữ tàu</h2>
                    </div>
                </div>
                <%--<div style="color: white; font-family: tahoma; font-size: 12px; font-weight: bold;
                    text-align: left;">
                    <h3>
                        Học thử trong phạm vi toàn cầu: 20:00-22:00
                        <br />
                        thứ 6 hàng tuần (giờ Hà Nội)<br />
                        Skype: ngoaingunamdu</h3>
                </div>--%>
            </div>
            <div class="clear">
            </div>
            <div id="banner">
                <div style="display: block;position: relative">
                    <img src="/Images/Background/Banner.jpg" title="site tham khảo" style="width: 100%"
                        alt="Ngoại ngữ Nam Du" />
                </div>
                <div style="background: #68b92e;color: white;font-weight: bold;padding: 20px;">
                    <div style="font-size: 18px;">
                        Học tiếng Hoa nói riêng, ngoại ngữ nói chung không thể là "học chơi", bạn đã tham gia bao nhiêu lớp học thiếu hiệu quả...
                    </div>
                    <div style="font-size: 37px;">
                        Ngoại ngữ Nam Du sẽ giúp bạn 30 ngày nói được tiếng Hoa
                    </div>
                    <div id="banner-bottom" style="border-radius: 25px;background: white;width: 940px;margin-top: 20px;color: black;padding: 10px 0px 10px 20px;">
                        <div style="font-size: 22px;">Lớp tập huấn tiếng Hoa <span style="color: #d8231a">Online</span> đầu tiên tại Việt Nam, khiến bạn nóng lên cùng hoài bão của mình:</div>
                        <div style="width: 410px;display: block;float: left">
                            <ul>
                                <li><span class="list">0</span> trở ngại, dễ dàng phát ngôn</li>
                                <li><span class="list">1</span> mẹo nhanh chóng vượt cửa ải nghe hiểu</li>
                                <li><span class="list">3</span> bước cập nhật vốn từ tiếng Hoa</li>
                            </ul>
                        </div>
                        <div style="width: 320px;display: inline-block">
                            <ul>
                                <li><span class="list">5</span> nâng cao tốc độ đọc</li>
                                <li><span class="list">7</span> ngày hoàng kim nhập môn</li>
                                <li><span class="list">30</span> ngày nói được tiếng Hoa</li>
                            </ul>
                        </div>
                        <div style="display: inline-block">
                            <a href="javascript:void(0)"><img src="/Images/Background/bt_dangkyi.jpg" alt="đăng ký"/></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
            <div id="Content">
                <!--1-->
                <div class="TitleLine">
                    <span class="number">1</span>
                    <span class="content">Bật mí cho học viên: Tôi đã nói được tiếng Hoa sau 1 tháng như thế nào?</span>
                </div>
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
                <%--<div class="DetailBot"></div>--%>
                <!--2-->
                <div class="TitleLine">
                    <span class="number">2</span>
                    <span class="content">Xem clip: làm thế nào để nói được tiếng hoa trong 3 tháng?</span>
                </div>
                <div class="CommentTop">Bật loa lên và click vào nút Play để xem</div>
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
                <%--<div class="Advantise2"><img alt="" src="Images/adv2.jpg" /></div>--%>
                <div id="Adv2" style="border-radius: 25px;background: white;width: 980px; margin-top: 40px;margin-bottom: 20px;color: black;padding: 10px 0px 10px 20px;position: relative">
                    <div style="position: absolute;top:-25px;left: -12px;"><img src="Images/Background/public.png" alt="công khai" /></div>
                    <div style="color: black; font-weight: bold; text-align: left; margin-left: 125px; font-size: 26px;"><span style="color: red">90</span> ngày "Tiếng Hoa cho người bận rộn Nam Du" gồm những nội dung gì?</div>
                    <div style="height: 20px;display: block;width: 100%"></div>
                    <div class="GroupList">
                        <div class="list1">
                            <div class="item">
                                <div class="number">1</div>
                                <div class="title">Tuần hoàng kim cho học viên mới</div>
                                <div class="desc">Lần đầu dễ dàng nhập môn
                                <br/>giữa học viên mới, trợ giảng và giảng viên</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">2</div>
                                <div class="title">Làm nhạy thính giác</div>
                                <div class="desc">Đột nhiên nghe được lúc nào không hay
                                <br/>phương tiện giải trí</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">3</div>
                                <div class="title">Phương pháp thẩm thấu ngôn ngữ</div>
                                <div class="desc">Nhanh chóng tận dụng kho dữ liệu mở cảm giác.</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">4</div>
                                <div class="title">Khéo léo vận dụng phương tiện tăng tốc  </div>
                                <div class="desc">Phần mềm/sách điện tử/mp3/clip</div>
                            </div>
                        </div>
                    </div>
                    <div class="GroupList">
                        <div class="list1">
                            <div class="item">
                                <div class="number">5</div>
                                <div class="title">sức mạnh của môi trường ngôn ngữ</div>
                                <div class="desc">Thành tích học tập tiếng Hoa mạnh gấp 50 lần trong 1 tháng</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">6</div>
                                <div class="title">hệ thống sát hạch 5 sao</div>
                                <div class="desc">Gắn sao, khẳng định tiến bộ rõ rệt</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">7</div>
                                <div class="title">Chiến lược học tập toàn diện</div>
                                <div class="desc">Kết hợp nội khóa, ngoại khóa, online, offline</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">8</div>
                                <div class="title">Máy ghi âm khủng</div>
                                <div class="desc">Thành tích học tập tiếng Hoa mạnh gấp 50 lần trong 1 tháng</div>
                            </div>
                        </div>
                    </div>
                    <div class="GroupList">
                        <div class="list1">
                            <div class="item">
                                <div class="number">9</div>
                                <div class="title">mô hình tương tác 3 giai đoạn</div>
                                <div class="desc">Tương tác đa chiều</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">10</div>
                                <div class="title">Bí mật của mạng truyền thông</div>
                                <div class="desc">Cảm nhận sự kỳ diệu của tiếng Hoa bằng </div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">11</div>
                                <div class="title">Phương pháp học 3 trong 1</div>
                                <div class="desc">Đồng thời phát huy nghe, nhìn và cảm giác.</div>
                            </div>
                        </div>
                        <div class="list1">
                            <div class="item">
                                <div class="number">12</div>
                                <div class="title">Thể hiện tiếng Hoa</div>
                                <div class="desc">3 tháng nói được tiếng Hoa, khiến người thân của bạn chứng kiến sức hút của lớp tiếng Hoa Nam Du.</div>
                            </div>
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div style="background: #68b92e;color: white;font-weight: bold;padding: 20px;width: 920px;margin-top: 20px">
                        <div>
                            <div style="color: white; font-weight: bold; text-align: left; font-size: 21px;">Sau 90 ngày, được tiếp tục tham gia phụ đạo trong 3 năm, đảm bảo sự nắm bắt vững vàng cho bạn.</div>
                            <div>30 ngày, dễ dàng nhập môn, vượt qua rào cản nghe hiểu</div>
                            <div>60 ngày, đặt nền móng vững chắc cho khả năng nói         </div>
                            <div>90 ngày, tiếng Hoa tự nhiên, giao tiếp không hạn chế</div>
                        </div>
                    </div>
                </div>
                <!--3-->
                <div class="TitleLine">
                    <span class="number">3</span>
                    <span class="content">Click để biết bạn có thích hợp tham gia lớp "Tiếng Hoa cho người bận rộn Nam Du" không?</span>
                </div>
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
                <%--<div class="Advantise3"><img src="Images/adv3.JPG" /></div>--%>
                <!--4-->
                    <div class="clear"></div>
                <div id="Content4">
                    <span class="number">4</span>
                    <div class="TitleWhite">Ai là giảng viên chính tại "TIẾNG HOA CHO NGƯỜI BẬN RỘN NAM DU"?</div>
                    <div class="clear"></div>
                    <div class="ContentBg">
                        <div id="contentbg1t">
                        <div id=contentbg1>
                            <div id="pcontent4">
                            <p>Đặng Nam Du</p>
                            <p>- Giáo viên Hán Ngữ đối ngoại quốc tế (TCSOL)</p>
                            <p>- Tác giả cuốn "Tiếng Việt & Tiếng Hoa thực hành cấp tốc"</p>
                            <p>- Phương án học tập toàn diện</p>
                            <p>- Người sáng lập ngoại ngữ quốc tế Nam Du - "Phương án học tập toàn diện" trực tiếp tham gia giảng dạy</p>
                            </div>
                        </div>
                        <div id="contentbg11">
                            <div id="syo">
                                <img src="Images/Background/Content4/youtube-logo2.jpeg" />
                                <input id="input" type="text" name="seachyoutube"/>
                            </div>
                            <div id="sgo">
                                <img src="Images/Background/Content4/Google-logo1.jpg" />
                                <input id="inpu1t" type="text" name="seachgoogle" />
                            </div>
                            
                        </div>
                        </div>
                        <div id=contentbg2>
                            <p>"TIẾNG HOA CHO NGƯỜI BẬN RỘN NAM DU"</p>
                            <p>Từ khi công khai các clip bài giảng, luôn được chú ý, các bạn đồng nghiệp mô phỏng và các học viên đón nhận</p>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <p>Đứng đầu trong các trang tìm kiếm với từ khóa "tự học tiếng Hoa"</p>
                        </div>
                    </div>
                </div>
                <div class="DetailBot"></div>
                <!--5-->
                <div id="Content5">
                    <span class="number">5</span>
                    <div class="TitleWhite">Có những ai đã từng học tại "TIẾNG HOA CHO NGƯỜI BẬN RỘN NAM DU"</div>
                    <div class="AdvantiseTop">
                        <div id="imagevn"><img src="Images/Background/Content5/298vietnam.jpg" alt="Bản đồ Việt Nam"/></div>
                        <div id="infor">
                            <p>"TIẾNG HOA CHO NGƯỜI BẬN RỘN NAM DU" là trung tâm tiếng Hoa uy tín tại Bình Dương. Thành lập từ tháng 7 năm 2010
                            tới nay, đã cung cấp cho thị trường hơn 1000 học viên với mọi trình độ, trong đó có một học viên xuất sắc hiện đang
                            đảm nhiệm công việc phiên dịch cho các công ty liên doanh Đài Loan, Trung Quốc... các nước thuộc khối Hoa Ngữ</p>
                            <p>Tháng 8 năm 2013, trường ngoại ngữ quốc tế Nam Du chính thức đưa vào hoạt động mô hình tập huấn tiếng Hoa online trên
                            phạm vi toàn cầu</p>
                        </div>
                    </div>
                </div>
                <a href="http://tieba.baidu.com/f?kz=1039355702"></a>
                
                <!--6-->
                <div id="Content6">
                    <div class="TitleLine">
                        <span class="number">6</span>
                        <span class="content">CLICK GHÉ THĂM FACEBOOK "NGOẠI NGỮ NAM DU" NGAY, BẠN SẼ ĐƯỢC...</span>
                    </div>
                    <div class="ContentDetail">
                        <iframe src="//www.facebook.com/plugins/likebox.php?href=http://www.facebook.com/pages/Ngo%E1%BA%A1i-Ng%E1%BB%AF-Nam-Du/476570295765236&width=1000&height=500&show_faces=true&colorscheme=light&stream=false&border_color=%23cccccc&header=false" scrolling="no" frameborder="0" style="border: none; overflow: hidden; width: 1000px; height: 500px;" allowtransparency="true"></iframe>
                    </div>
                </div>
                <%--<div class="DetailBot"></div>--%>
                <!--7-->
                <div class="TitleLine">
                    <span class="number">7</span>
                    <span class="content">Cở sở đầu tiên trong toàn quốc đảm bảo hiệu quả: Tiến bộ ngay từ 7 ngày đầu tiên, nếu không sẽ miễn phí</span>
                </div>
                <div class="DetailDot"><img src="Images/Detail7.png" height="100%" width="100%" /></div>
                <!--8-->
                <div id="Content8">
                    <div class="TitleWhite">Tham gia lớp học như thế nào?</div>
                    <div class="Detail8">
                        <div class="Video8"><img src="Images/Video8.png" width="100%" height="100%" /></div>
                        <div class="Contact8"><img src="Images/Contact8.png" width="95%" height="95%" /></div>
                        <div class="BotDetail"><img src="Images/CommentBot.png" height="100%" /></div>
                    </div>
                </div>
                <div class="DetailBot"><img src="Images/Detail8.png" /></div>
                <img src="Images/9.png" width="100%" />
                <img src="Images/sach1.png" width="100%" />
                <img src="Images/cd2.png" width="100%" />
                <img src="Images/ngoai3.png" width="100%" />
                <div class="DetailBot"><img src="Images/sau3.png" width="100%" /></div>
                <img src="Images/tongketmorong.png" width="100%" />
                <div class="AdvantiseRectange"><img src="Images/advRec.png" width="100%" /></div>
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
