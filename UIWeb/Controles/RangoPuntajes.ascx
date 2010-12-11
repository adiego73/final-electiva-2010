<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RangoPuntajes.ascx.cs" Inherits="UIWeb.Controles.RangoPuntajes" %>
<hr style="margin-left: 15px" />
<asp:GridView ID="gvRangoPuntajes" runat="server" BorderStyle="Solid" Width="613px" 
    BorderWidth="1px" style="margin-left: 17px">
    <RowStyle BorderStyle="Solid" BorderWidth="1px" 
        Height="15px" />
    <SelectedRowStyle BorderStyle="None" />
    <HeaderStyle BorderStyle="Solid" Font-Bold="True" HorizontalAlign="Center" 
        VerticalAlign="Middle" BackColor="#FC713D" BorderColor="Black" 
        BorderWidth="1px" Height="15px" />
    <EditRowStyle BorderStyle="None" />
    <AlternatingRowStyle BackColor="#FFCC66" />
</asp:GridView>
<hr style="margin-left: 14px" />