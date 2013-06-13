<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReporProducts.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<div id="content">
    <div class="section">
        <div class="full">
            <div class="panel">
                <div class="title-large">
                    <h2>
                        Report Products
                    </h2>
                    <div class="theme">
                    </div>
                    <div class="drop">
                    </div>
                </div>
                <div class="content topad">
                    <h1 style="padding-left:10px;">
                        Report Products</h1>
                    <br />

                    <div class="section" style="padding-left:10px;">
                        <span style="width: 120px;">Category : </span>
                        <asp:Label ID="lblCategoryName" runat="server" Text="Label" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                     
                    </div>
                    
                   
                    <div class="section">
                        <table style="width: 96%; margin: 0 auto; border: 1px solid;">
                            <thead style="color: #fff; background: #423F3C;">
                                <tr>
                                    <th style="width: 50px; padding-left: 10px;font-size: 12px;">
                                        STT
                                    </th>
                                    <th style="width: 100px; padding-left: 10px;font-size: 12px;">
                                        Products ID 
                                    </th>
                                    <th style="width: 200px; padding-left: 10px;font-size: 12px;">
                                        Product Name
                                    </th>
                                    <th style="width: 150px; padding-left: 10px;font-size: 12px;">
                                        Category
                                    </th>
                                                                        
                                    <th style="width: 100px; padding-left: 10px;font-size: 12px;">
                                        Price
                                    </th>
                                 
                                </tr>
                            </thead>
                            <tfoot style="color: #fff; background: #423F3C;">
                                <tr>
                                    <th>
                                        &nbsp;
                                    </th>
                                    <th>
                                        &nbsp;
                                    </th>
                                    <th>
                                        &nbsp;
                                    </th>
                                    <th>
                                        &nbsp;
                                    </th>
                                    <th>
                                        &nbsp;
                                    </th>
                                   
                                 
                                </tr>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptReportSale" runat="server" OnItemDataBound="rptProducts_ItemDataBound">
                                    <ItemTemplate>
                                        <tr style="height: 30px;">
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <%# Container.ItemIndex + 1 %>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblProductID" runat="server" Text="Label"></asp:Label>
                                                
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblProductCat" runat="server" Text="Label"></asp:Label>
                                            </td>
                                           
                                            <td style="padding-left: 10px; border-right: 1px solid; border-bottom: 1px dotted;">
                                                <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                                            </td>
                                           
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                    <div class="section">
                        <span class="label" style="width: 120px;">Amount (in numbers) : </span>
                        <asp:Label ID="lblTotalNumber" runat="server" Text="Label"></asp:Label>
                    </div>

                    <div class="section">
                        <asp:Label ID="lblMultipleID" runat="server" Visible="false"></asp:Label>
                        <span class="label" style="width: 120px;">&nbsp;</span>
                        <asp:Button ID="btUpdate" runat="server" Text="Print Order Sale" OnClick="btUpdate_Click" />
                        &nbsp;
                        <asp:Button ID="btCancel" runat="server" Text="Cancel" OnClick="btCancel_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
