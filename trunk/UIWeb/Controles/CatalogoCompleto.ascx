<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CatalogoCompleto.ascx.cs" Inherits="UIWeb.Controles.CatalogoCompleto" %>
<div>
    Filtro por puntaje&nbsp;&nbsp;<asp:DropDownList ID="Puntajes" runat="server" Height="20px" 
        Width="118px">
        <asp:ListItem Selected="True">Todos</asp:ListItem>
        <asp:ListItem>100</asp:ListItem>
        <asp:ListItem>300</asp:ListItem>
        <asp:ListItem>500</asp:ListItem>
        <asp:ListItem>1000</asp:ListItem>
        <asp:ListItem>10000</asp:ListItem>
        <asp:ListItem>50000</asp:ListItem>
    </asp:DropDownList>&nbsp;&nbsp;
    <asp:Button ID="Submit" runat="server" onclick="Submit_Click" 
        Text="Consultar" />
        
    <hr />
        
</div>
<asp:GridView ID="GridView1" runat="server" BorderStyle="Solid" Width="649px" 
    BorderWidth="1px">
    <RowStyle BorderStyle="Solid" BackColor="#CCFFCC" BorderWidth="1px" 
        Height="15px" />
    <SelectedRowStyle BorderStyle="None" />
    <HeaderStyle BorderStyle="Solid" Font-Bold="True" HorizontalAlign="Center" 
        VerticalAlign="Middle" BackColor="#FFFF66" BorderColor="Black" 
        BorderWidth="1px" Height="15px" />
    <EditRowStyle BorderStyle="None" />
    <AlternatingRowStyle BackColor="#FFFFCC" />
</asp:GridView>
<hr />

