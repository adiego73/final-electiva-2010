<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SolicitudPremios.ascx.cs" Inherits="UIWeb.Controles.SolicitudPremios" %>
<hr style="margin-left: 15px" />
<asp:GridView ID="gvSolicitudPremios" runat="server" BorderStyle="Solid" Width="613px" 
    BorderWidth="1px" style="margin-left: 17px">
    <RowStyle BorderStyle="Solid" BackColor="#CCFFCC" BorderWidth="1px" 
        Height="15px" />
    <SelectedRowStyle BorderStyle="None" />
    <HeaderStyle BorderStyle="Solid" Font-Bold="True" HorizontalAlign="Center" 
        VerticalAlign="Middle" BackColor="#FFFF66" BorderColor="Black" 
        BorderWidth="1px" Height="15px" />
    <EditRowStyle BorderStyle="None" />
    <AlternatingRowStyle BackColor="#FFFFCC" />
</asp:GridView>
<hr style="margin-left: 14px" />