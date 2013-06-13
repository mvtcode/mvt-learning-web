<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="contentContainer first">
            <div class="contentPadd prods_info_page">
                <div class="prods_info decks big">
                    <div class="forecastle">
                        <ol class="masthead">
                            <li class="port_side left_side_pic-1">
                                <div class="outer">
                                    <ul class="relative" style="display: block; height: 244px; width: 220px;padding:0;">
                                        <li class="wrapper_pic_div first" style="position: absolute;">
                                            <asp:Image ID="img" runat="server" Width="220px" Height="220px" />
                                        </li>
                                    </ul>
                                </div>
                            </li>
                            <li class="starboard_side right_side_pic-1">
                                <div class="info">
                                    <h2>
                                        <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                                        <br/>
                                    </h2>
                                    <h2 class="price">
                                        <b>Price:&nbsp;&nbsp;</b>
                                        <asp:Label ID="lblPrice" runat="server" Text="Label" CssClass="productSpecialPrice"></asp:Label>
                                    </h2>
                                    <div class="desc desc_padd">
                                        <p style="padding-top: 0px;">
                                            <asp:Label ID="lblMaincontent" runat="server" Text="Label"></asp:Label>
                                        </p>
                                        
                                    </div>
                                    <div class="buttonSet">
                                        <div class="fl_right" align="right">
                                            <div class="button__padd">
                                                <strong class="button_content button_content2">
                                                    <strong class="button bg_button">
                                                        <strong class="button-t">
                                                            <asp:LinkButton ID="lbtAddtoCard" runat="server" CommandName="AddCart" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-icon-primary ui-priority-secondary" onclick="lbtAddtoCard_Click">
                                                                <span class="ui-button-icon-primary ui-icon ui-icon-cart"></span>
                                                                <span class="ui-button-text">Add&nbsp;to&nbsp;Cart</span>
                                                            </asp:LinkButton>
                                                        </strong>
                                                    </strong>
                                                </strong>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class="box_wrapper_title22">
            <div class="box_wrapper_title">
                <span class="title-icon"></span>
                <h1 class="cl_both ">
                    Other Products You Might Like
                </h1>
            </div>
        </div>
        <div class="contentContainer page_un last">
            <div class="contentPadd">
                <div class="prods_content prods_table">
                    <ul class="row_new_products_name row_new_products_block" id="row-0">
                        <asp:Repeater ID="rptProductHome" runat="server"  onitemcommand="rptProductHome_ItemCommand"  onitemdatabound="rptProductHome_ItemDataBound">
                            <ItemTemplate>
                                <li style="width: 160px;" class="wrapper_prods equal-height_new_products_block hover">
                                    <div class="border_prods">
                                        <div class="pic_padd wrapper_pic_div" style="width: 160px; height: 160px;">
                                            <asp:HyperLink ID="lnkimg" runat="server" CssClass="prods_pic_bg" Style="width: 160px;
                                                height: 160px;">
                                                <asp:Image ID="img" runat="server" Width="160px" Height="160px" />
                                            </asp:HyperLink>
                                        </div>
                                        <div class="prods_padd">
                                            <div class="name name_padd equal-height_new_products_name">
                                                <span>
                                                    <asp:HyperLink ID="lnkProductName" runat="server">HyperLink</asp:HyperLink>
                                                </span>
                                            </div>
                                            <div class="desc desc_padd">
                                                <asp:Label ID="lblInit" runat="server" Text="Label"></asp:Label>
                                            </div>
                                            <div class="price price_padd ">
                                                <b>Price:&nbsp;&nbsp;</b>
                                                <asp:Label ID="lblPrice" runat="server" Text="Label" class="productSpecialPrice"></asp:Label>
                                            </div>
                                            <div class="button__padd">
                                                <strong class="button_content button_content2"><strong class="button bg_button"><strong
                                                    class="button-t">
                                                    <asp:LinkButton ID="lbtAddtoCard" runat="server"  CommandName="AddCart" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-icon-primary ui-priority-secondary">
                                                        <span class="ui-button-icon-primary ui-icon ui-icon-cart"></span>
                                                        <span class="ui-button-text">Add&nbsp;to&nbsp;Cart</span>
                                                    </asp:LinkButton>
                                                </strong></strong></strong>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
