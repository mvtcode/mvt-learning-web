<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductCategorys.aspx.cs" Inherits="ProductCategorys" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="un_title">
            <div class="box_wrapper_title22">
                <div class="box_wrapper_title">
                    <span class="title-icon"></span>
                    <h1 class="cl_both ">
                        <asp:Label ID="lblCategoryName" runat="server" Text="Label"></asp:Label>
                    </h1>
                </div>
            </div>
        </div>
        <div class="contentContainer page_un">
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
                                                    <asp:LinkButton ID="lbtAddtoCard" runat="server" CommandName="AddCart" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-icon-primary ui-priority-secondary">
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

