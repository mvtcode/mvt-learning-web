<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NNND._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/CSS/Styles.css" rel="stylesheet" type="text/css" />
    <link href="CSS/style-slider.css" rel="stylesheet" type="text/css" />
    <link href="CSS/default-slider.css" rel="stylesheet" type="text/css" />
    <link href="CSS/nivo-slider.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.nivo.slider.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="MainBody">
        <div id="header">
            <%--<img src="/Images/banner.jpg" alt="Ngoại ngữ Nam Du" />--%>
            <div id="wrapper">
                <div class="slider-wrapper">
                    <div id="slider" class="nivoSlider">
                        <img src="Images/Banner/nemo.jpg" />
                        <img src="Images/Banner/walle.jpg" />
                        <img src="Images/Banner/up.jpg" />
                    </div>
                </div>
            </div>
            <script type="text/javascript">
                $(window).load(function () {
                    $('#slider').nivoSlider({
                        effect: 'random', // Specify sets like: 'fold,fade,sliceDown'
                        slices: 15, // For slice animations
                        boxCols: 8, // For box animations
                        boxRows: 4, // For box animations
                        animSpeed: 500, // Slide transition speed
                        pauseTime: 8000, // How long each slide will show
                        startSlide: 0, // Set starting Slide (0 index)
                        directionNav: true, // Next & Prev navigation
                        directionNavHide: true, // Only show on hover
                        controlNav: false, // 1,2,3... navigation
                        controlNavThumbs: false, // Use thumbnails for Control Nav
                        pauseOnHover: true, // Stop animation while hovering
                        manualAdvance: false, // Force manual transitions
                        prevText: 'Prev', // Prev directionNav text
                        nextText: 'Next', // Next directionNav text
                        randomStart: true, // Start on a random slide
                        beforeChange: function () { }, // Triggers before a slide transition
                        afterChange: function () { }, // Triggers after a slide transition
                        slideshowEnd: function () { }, // Triggers after all slides have been shown
                        lastSlide: function () { }, // Triggers when last slide is shown
                        afterLoad: function () { } // Triggers when slider has loaded
                    });
                });
            </script>
        </div>
        <div class="clear"></div>
        <div id="banner">
            <h1>Ngoại ngữ Nam Du</h1>
        </div>
        <div id="Content">
            Nội dung bài viết
        </div>
        <div id="footer">
            Footer
        </div>
    </div>
    </form>
</body>
</html>
