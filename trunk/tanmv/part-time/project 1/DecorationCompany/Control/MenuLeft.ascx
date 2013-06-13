<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuLeft.ascx.cs" Inherits="Control_MenuLeft" %>
<div id="columnLeft" class="grid_6 pull_18">
    <div>
        <div class="infoBoxWrapper list border_none">
            <div class="box_wrapper">
                <div class="infoBoxHeading">
                    <div class="box_wrapper_title22">
                        <div class="box_wrapper_title">
                            <h1>
                                <span class="title-icon"></span>Categories</h1>
                        </div>
                    </div>
                </div>
                <div class="infoBoxContents">
                    <ul class="categories">
                        <asp:Repeater ID="rptMenuLeft" runat="server" onitemdatabound="rptMenuLeft_ItemDataBound">
                            <ItemTemplate>
                                <li class="">
                                    <div class="div_2">
                                        <asp:HyperLink ID="lnkProductCat" runat="server">
                                            <div class="div_2">
                                                <div class="list_bg"></div>
                                                <asp:Label ID="lblProductCatName" runat="server" Text="Label"></asp:Label>
                                            </div>
                                        </asp:HyperLink>
                                        
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                        
                        
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
