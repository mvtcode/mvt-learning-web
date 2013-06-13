<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="RegisterSussces.aspx.cs" Inherits="RegisterSussces" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="bodyContent" class="grid_18 push_6 ">
        <div class="box_wrapper_title22">
            <div class="box_wrapper_title">
                <span class="title-icon"></span>
                <h1>
                    Create new account
                </h1>
            </div>
        </div>
        <div>
            <br />
            Register Successful!<br />
            Click
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">here</asp:HyperLink>
            to return to previous home page
        </div>
    </div>
</asp:Content>
