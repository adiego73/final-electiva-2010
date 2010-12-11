<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Canjear.ascx.cs" Inherits="UIWeb.Controles.Canjear" %>
<div>
    Puntaje Total:&nbsp;&nbsp;<asp:Label ID="Puntaje" runat="server"></asp:Label>
    <hr />
        
</div>
<asp:GridView ID="cCatalogo" runat="server" BorderStyle="Solid" Width="649px" 
    BorderWidth="1px" onselectedindexchanged="Click_Canjear" 
    BorderColor="#333333">
    <RowStyle BorderStyle="Solid" BorderWidth="1px" 
        Height="15px" />
    <SelectedRowStyle BorderStyle="None" />
    <HeaderStyle BorderStyle="Solid" Font-Bold="True" HorizontalAlign="Center" 
        VerticalAlign="Middle" BackColor="#FC713D" BorderColor="Black" 
        BorderWidth="1px" Height="15px" />
    <EditRowStyle BorderStyle="None" />
    <AlternatingRowStyle BackColor="#FFCC66" />
</asp:GridView>
<asp:Label ID="lExcepciones" runat="server"></asp:Label>
<hr />



