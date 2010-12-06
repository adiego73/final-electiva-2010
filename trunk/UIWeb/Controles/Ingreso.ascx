<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.ascx.cs" Inherits="UIWeb.Controles.LogIn" %>
<asp:Panel ID="pnlLogIn" runat="server" BorderColor="#003366" 
    BorderStyle="Solid" BorderWidth="1px" Width="100%" Height="87px">
    <table align="left" cellspacing="1" class="style1">
        <tr>
            <td class="style3">
                <asp:Label ID="usuarioLB" runat="server" Font-Bold="True" Font-Italic="False" 
                    Font-Names="Arial" Font-Size="Small" ForeColor="#003366" Text="Usuario:"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="usuarioTX" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:Image ID="errUsuarioPB" runat="server" Visible="False" />
                <asp:Label ID="errUsuarioLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="contraseniaLB" runat="server" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="Small" ForeColor="#003366" Text="Contraseña:"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="ContraseniaTX" runat="server" Width="150px" 
                    TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:Image ID="errContraseniaPB" runat="server" Visible="False" />
                <asp:Label ID="errContraseniaLB" runat="server" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Button ID="bObtener" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#003366" Text="Obtener/Recuperar Usuario" 
                    onclick="bObtener_Click" />
                <asp:Button ID="bIngresar" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#003366" onclick="bIngresar_Click" Text="Ingresar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Panel>
<asp:Label ID="errorGralLB" runat="server" Font-Italic="True" 
    Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
<asp:Label ID="avisoGralLB" runat="server" Font-Bold="False" Font-Italic="True" 
    Font-Names="Arial" Font-Size="Small" ForeColor="#339933" Visible="False"></asp:Label>