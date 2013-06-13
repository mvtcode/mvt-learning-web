<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="New.aspx.cs" Inherits="New" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="un_title">
            <div class="box_wrapper_title22">
                <div class="box_wrapper_title">
                    <span class="title-icon"></span>
                    <h1 class="cl_both ">
                        News
                    </h1>
                </div>
            </div>
        </div>
        <div class="contentContainer page_listing first last">
            <div class="contentPadd r_view" style="display: block;">
                <div class="prods_content prods_table">
                    <asp:Repeater ID="rptNews" runat="server" OnItemDataBound="rptNews_ItemDataBound">
                        <ItemTemplate>
                            <ul class="row row3 first" id="row0">
                                <li style="width: 100%;" class="wrapper_prods hover first last">
                                    <div class="border_prods">
                                        <div class="fl_left" style="width: 100px; margin-right: 14px;">
                                            <div class="pic_padd wrapper_pic_div" style="width: 100px; height: 100px;">
                                                <asp:HyperLink ID="lnkimg" runat="server" Style="width: 100px; height: 100px;">
                                                    <asp:Image ID="img" runat="server" Width="100px" Height="100px" Style=" margin: 0px 0px 0px 0px;" />
                                                </asp:HyperLink>
                                                <div class="sale">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="prods_padd">
                                            <h2 class="name name2_padd">
                                                <span>
                                                    <asp:HyperLink ID="lnkName" runat="server"></asp:HyperLink>
                                                </span>
                                            </h2>
                                            <div class="desc desc2_padd">
                                                <asp:Label ID="lblInit" runat="server" Text="Label"></asp:Label>
                                            </div>
                                           
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
