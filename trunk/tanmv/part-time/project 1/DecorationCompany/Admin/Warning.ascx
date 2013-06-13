<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Warning.ascx.cs" Inherits="Admin_Warning" %>
<div class="section" style="min-height:1px;margin:0;height;1px;">
    <div class="full ui-sortable" style="min-height:1px;">
        <div id="div_blue" runat="server" visible="false" class="notice blue" style="height: 30px;padding: 10px 0 0 10px;width:500px;">
            <asp:Label ID="lblBlue" runat="server" style="color: #fff;font-size: 12px;"></asp:Label>
            
            <span class="close"></span>
        </div>
        <div class="notice red" id="div_red" runat="server" visible="false" style="height: 30px;padding: 10px 0 0 10px;width:500px;">
            <asp:Label ID="lblRed" runat="server" style="color: #fff;font-size: 12px;"></asp:Label>
            
            <span class="close"></span>
        </div>
        
        
    </div>
</div>
