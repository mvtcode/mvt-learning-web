<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NivoSlider.ascx.cs" Inherits="Control_NivoSlider" %>
<div class="row_3">
    <div class="container_24">
        <div class="grid_">
            <div class="grid_24">
                <script type="text/javascript">
                    $(window).load(function () {
                        $('#slider').nivoSlider({
                            effect: 'boxRainGrow',
                            slices: 15,
                            boxCols: 8,
                            boxRows: 4,
                            animSpeed: 500,
                            pauseTime: 5000,
                            startSlide: 0, //Set starting Slide (0 index)
                            directionNav: false, //Next & Prev
                            directionNavHide: true, //Only show on hover
                            controlNav: true, //1,2,3...
                            controlNavThumbs: false, //Use thumbnails for Control Nav
                            controlNavThumbsFromRel: false, //Use image rel for thumbs
                            controlNavThumbsSearch: '.jpg', //Replace this with...
                            controlNavThumbsReplace: '_thumb.jpg'/*tpa=http://livedemo00.template-help.com/osc_44255/_thumb.jpg*/, //...this in thumb Image src
                            keyboardNav: true, //Use left & right arrows
                            pauseOnHover: true, //Stop animation while hovering
                            manualAdvance: false, //Force manual transitions
                            captionOpacity: 0.8, //Universal caption opacity
                            beforeChange: function () { },
                            afterChange: function () { },
                            slideshowEnd: function () { }, //Triggers after all slides have been shown
                            prevText: 'Prev',
                            nextText: 'Next'
                        });
                    });

                </script>
                <div class="nivoSlider_wrapper">
                    <div class="js_bg">
                        <div id="slider" class="nivoSlider">
                            <asp:Repeater ID="rptSlide" runat="server"  onitemdatabound="rptSlide_ItemDataBound">
                                <ItemTemplate>
                                    <asp:HyperLink ID="lnkimg" runat="server">
                                        <asp:Image ID="img" runat="server" Width="950px" Height="370px" />
                                    </asp:HyperLink>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</div>
