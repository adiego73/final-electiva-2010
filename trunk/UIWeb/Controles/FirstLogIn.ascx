<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FirstLogIn.ascx.cs" Inherits="UIWeb.Controles.edfirstLogIn" %>
<style type="text/css">

        .style2
        {
    }
    .style3
    {
        width: 154px;
    }
    .style7
    {
    }
    .style8
    {
        width: 150px;
    }
    .style9
    {
        width: 160px;
    }
    </style>
    <div><br />
    <table width="100%"><tr><td align="center"> <asp:Label ID="introLB" runat="server" 
            Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#333333"></asp:Label></td></tr></table>
        <asp:Panel ID="userPNL" runat="server" BorderColor="#FC713D" 
            BorderStyle="Solid" BorderWidth="1px" Width="100%" Font-Bold="False" 
            Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000">
            <img align="right" alt="PASO 1" longdesc="1er paso para generar un usuario" 
                src="../imagenes/Iconos/vwicn151.gif" style="width: 22px; height: 18px" />
               
            <br />
            <table align="left" cellpadding="0" cellspacing="0">
                <tr>
                    <td class="style2">
                        <asp:Label ID="dniLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Small" ForeColor="#333333" Text="Dni:"></asp:Label>
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="dniTX" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Image ID="errDniPB" runat="server" Visible="False" />
                        <asp:Label ID="errDniLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:Label ID="idUsuarioLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Small" ForeColor="#333333" Text="ID Usuario:"></asp:Label>
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="idUsuarioTX" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Image ID="errIdUsuarioPB" runat="server" Visible="False" />
                        <asp:Label ID="errIdUsuarioLB" runat="server" Font-Bold="True" 
                            Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2" align="right" colspan="2">
                        <asp:Button ID="bSiguiente" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Small" ForeColor="#FC713D" onclick="bSiguiente_Click" 
                            Text="Siguiente" />
                    </td>
                    <td align="right">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    
    </div>
            <asp:Label ID="errorGralLB" runat="server" Font-Italic="True" 
                Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
            <asp:Label ID="avisoGralLB" runat="server" Font-Italic="True" 
                Font-Names="Arial" Font-Size="Small" ForeColor="#339933"></asp:Label>
<br /><br />
<asp:Panel ID="pnlCargaUsuario" runat="server" BorderColor="#FC713D" 
    BorderStyle="Solid" BorderWidth="1px" Font-Size="Small" Height="130px" 
    Width="100%">
    <img align="right" alt="PASO 2" longdesc="2do Paso para generar el usuario" 
        src="../imagenes/Iconos/vwicn152.gif" style="width: 22px; height: 18px" /><br />
    <table align="left" float="false" ID="tblCarga" 
        
        style="position: static; right: 145px; table-layout: fixed; border-collapse: separate; border-spacing: inherit; empty-cells: show; margin-right: 0px;">
        <tr>
            <td class="style7">
                <asp:Label ID="usuarioLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="Small" ForeColor="#333333" Text="Usuario:"></asp:Label>
            </td>
            <td class="style8">
                <asp:TextBox ID="usuarioTX" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td align="justify">
                <asp:Image ID="errUsuarioPB" runat="server" Visible="False" />
                <asp:Label ID="errUsuarioLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="contraseniaLB" runat="server" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="Small" ForeColor="#333333" 
                    Text="Contraseña:"></asp:Label>
            </td>
            <td class="style8">
                <asp:TextBox ID="contraseniaTX" runat="server" Width="150px" 
                    TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:Image ID="errContraseniaPB" runat="server" Visible="False" />
                <asp:Label ID="errContraseniaLB" runat="server" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="verificarLB" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="Small" ForeColor="#333333" Text="Repita Contraseña:"></asp:Label>
            </td>
            <td align="left" class="style8">
                <asp:TextBox ID="verificarTX" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:Image ID="errVerificaPB" runat="server" Visible="False" />
                <asp:Label ID="errVerificaLB" runat="server" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7" align="right" colspan="2">
                <asp:Button ID="bRegistrar" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="Small" ForeColor="#FC713D" onclick="bRegistrar_Click" 
                    Text="Registrar" />
                <asp:Button ID="bVolver" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="Small" ForeColor="#FC713D" onclick="bVolver_Click" 
                    Text="Volver" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Panel>
<asp:Label ID="errorGralLB2" runat="server" Font-Italic="True" 
    Font-Names="Arial" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
<asp:Label ID="avisoGralLB2" runat="server" Font-Italic="True" 
    Font-Names="Arial" Font-Size="Small" ForeColor="#339933"></asp:Label>
