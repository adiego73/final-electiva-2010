﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Canjear.ascx.cs" Inherits="UIWeb.Controles.Canjear" %>
<div>
    Filtro por puntaje&nbsp;&nbsp;<asp:DropDownList ID="cPuntajes" runat="server" Height="20px" 
        Width="118px">
        <asp:ListItem Selected="True">Todos</asp:ListItem>
        <asp:ListItem>100</asp:ListItem>
        <asp:ListItem>300</asp:ListItem>
        <asp:ListItem>500</asp:ListItem>
        <asp:ListItem>1000</asp:ListItem>
        <asp:ListItem>10000</asp:ListItem>
        <asp:ListItem>50000</asp:ListItem>
    </asp:DropDownList>&nbsp;&nbsp;
    <asp:Button ID="cSubmit" runat="server" onclick="Submit_Click" 
        Text="Consultar" />
        
    <hr />
        
</div>
<asp:GridView ID="cCatalogo" runat="server" BorderStyle="Solid" Width="649px" 
    BorderWidth="1px" onselectedindexchanged="Click_Canjear">
    <RowStyle BorderStyle="Solid" BackColor="#CCFFCC" BorderWidth="1px" 
        Height="15px" />
    <SelectedRowStyle BorderStyle="None" />
    <HeaderStyle BorderStyle="Solid" Font-Bold="True" HorizontalAlign="Center" 
        VerticalAlign="Middle" BackColor="#FFFF66" BorderColor="Black" 
        BorderWidth="1px" Height="15px" />
    <EditRowStyle BorderStyle="None" />
    <AlternatingRowStyle BackColor="#FFFFCC" />
</asp:GridView>
<asp:Label ID="lExcepciones" runat="server"></asp:Label>
<hr />


