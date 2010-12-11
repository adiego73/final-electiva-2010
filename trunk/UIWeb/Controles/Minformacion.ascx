<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Minformacion.ascx.cs"
    Inherits="UIWeb.Controles.Minformacion" %>
<hr />
<asp:Panel ID="Panel1" runat="server" BorderColor="#FF3300" BorderWidth="1px">
    <table align="center" >
        <tr>
            <td>
                <asp:Label ID="lNombreApellido" runat="server" Text="Apellido y Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbApellidoNombre" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lUsuario" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbUsuario" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lProvincia" runat="server" Text="Provincia"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbProvincia" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lTelefono" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbTelefono" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lMail" runat="server" Text="e-mail"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbMail" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lDni" runat="server" Text="DNI"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbDni" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lPuntos" runat="server" Text="Total de Puntos"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbPuntos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lException" runat="server" Font-Italic="True" 
                ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="text-align:center">
                    <asp:Button ID="btModificar" runat="server" 
                Text="Modificar" Font-Bold="True" Font-Names="Arial" ForeColor="#FC713D" 
                    Visible="False" />
                </div>
            </td>
        </tr>
    </table>
</asp:Panel>
<p>
    <br />
</p>
<hr />