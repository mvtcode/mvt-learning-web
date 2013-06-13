<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Search.ascx.cs" Inherits="Control_Search" %>
<div class="search">
    <div class="inner">
        <div class="button-t">
            <span class="tdbLink">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/search_button.png" onclick="ImageButton1_Click" />
            </span>
            <script type="text/javascript">
                $("#tdb1").button().addClass("ui-priority-secondary").parent().removeClass("tdbLink");
            </script>
        </div>
        <div class="input-width fl_right">
            <div class="width-setter">
                <asp:TextBox ID="txtKeyword" runat="server" class="go fl_left" onblur="if(this.value=='') this.value='Site Search'" onfocus="if(this.value =='Site Search' ) this.value=''"></asp:TextBox>
                
            </div>
        </div>
        <label class="fl_left">
            Search</label>
    </div>
</div>
