<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Shopping.aspx.cs" Inherits="Shopping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="box_wrapper_title22">
            <div class="box_wrapper_title">
                <span class="title-icon"></span>
                <h1>
                    What's In My Cart?</h1>
            </div>
        </div>
        <div class="contentContainer page_cart first last">
            <div class="contentPadd">
             <br />
                <asp:Label ID="lblWarning" runat="server" Visible="false" ForeColor="Red" Text="You need to login to purchase" ></asp:Label>
                 <asp:HyperLink ID="lnkLogin" runat="server" NavigateUrl="~/Login.aspx" Visible="false">Click here to Login</asp:HyperLink>
                 <br />
                  <br />
                <table border="0" cellspacing="0" cellpadding="0" class="prods_content cart">
                    <tbody>
                        <tr>
                            <th class="th1">
                                Product(s)
                            </th>
                            <th>
                                Qty.
                            </th>
                            <th class="th3" style="border-right-width: 0px;">
                                Total
                            </th>
                        </tr>
                        <asp:Repeater ID="rptCart" runat="server" OnItemCommand="rptCart_ItemCommand" OnItemDataBound="rptCart_ItemDataBound">
                            <ItemTemplate>
                                <tr class="row">
                                    <td class="cart_prods" align="center" style="border-width: 0px 1px 1px 0px;">
                                        <table border="0" cellspacing="0" cellpadding="0" class="hover">
                                            <tbody>
                                                <tr>
                                                    <td colspan="2">
                                                        <div class="name name_padd equal-height" style="min-height: 21px;">
                                                            <div>
                                                                <asp:HyperLink ID="lnkName" runat="server">HyperLink</asp:HyperLink>
                                                                <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" style="width: 100%;">
                                                        <div class="pic_padd wrapper_pic_div" style="width: 110px; height: 110px;">
                                                            <asp:HyperLink ID="lnkimg" runat="server" class="prods_pic_bg">
                                                                <asp:Image ID="img" runat="server" Width="110px" Height="110px" />
                                                            </asp:HyperLink>
                                                        </div>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td class="cart_update" style="border-width: 0px 1px 1px 0px;">
                                        <div class="name name_padd equal-height" style="min-height: 21px;">
                                            <div>
                                                &nbsp;</div>
                                        </div>
                                        <asp:TextBox ID="txtQuantity" runat="server" Width="80px"></asp:TextBox>
                                        <div class="buttonSet">
                                            <strong class="button_content button_content2"><strong class="button bg_button"><strong
                                                class="button-t">
                                                <asp:LinkButton ID="lbtUpdate" CommandName="Update" runat="server" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-icon-primary ui-priority-secondary">
                                                            <span class="ui-button-icon-primary ui-icon ui-icon-cart"></span>
                                                            <span class="ui-button-text">Update &nbsp;</span>
                                                </asp:LinkButton>
                                            </strong></strong></strong>
                                            <br />
                                            <br />
                                            <br />
                                            <strong class="button_content button_content2"><strong class="button bg_button"><strong
                                                class="button-t">
                                                <asp:LinkButton ID="lbtRemove" CommandName="Remove" runat="server" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-icon-primary ui-priority-secondary">
                                                            <span class="ui-button-icon-primary ui-icon ui-icon-cart"></span>
                                                            <span class="ui-button-text">Remove</span>
                                                </asp:LinkButton>
                                            </strong></strong></strong>
                                        </div>
                                    </td>
                                    <td class="cart_price" style="border-width: 0px 0px 1px;">
                                        <div class="name name_padd equal-height" style="min-height: 21px;">
                                            <div>
                                                &nbsp;</div>
                                        </div>
                                        <asp:Label ID="lblPrice" runat="server" Text="Label" class="productSpecialPrice"></asp:Label>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <tr class="cart_total">
                            <td>
                                &nbsp;
                            </td>
                            <td style="border-width: 0px 1px 0px 0px;">
                                Sub-Total:
                            </td>
                            <td class="productSpecialPrice">
                                <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <!--  <div class="prods_hseparator"></div> -->
                <div class="prods_hseparator">
                    <img src="images/spacer.gif" alt="" width="1" height="1"></div>
                <div class="cl_both ofh cart_total buttonSet">
                    <div class="button__padd">
                        <strong class="button_content button_content2"><strong class="button bg_button"><strong
                            class="button-t">
                            <asp:LinkButton ID="lbtCheckOut" runat="server" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-icon-primary ui-priority-secondary"
                                OnClick="lbtCheckOut_Click">
                                                            <span class="ui-button-icon-primary ui-icon ui-icon-cart"></span>
                                                            <span class="ui-button-text">CheckOut</span>
                            </asp:LinkButton>
                        </strong></strong></strong>
                    </div>
                </div>
               
            </div>
        </div>
    </div>
</asp:Content>
