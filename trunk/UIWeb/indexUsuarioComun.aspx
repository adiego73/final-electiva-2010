<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUsuarioComun.aspx.cs"
    Inherits="UIWeb.indexUsuarioComun" %>

<%@ Register Src="Controles/CatalogoCompleto.ascx" TagName="CatalogoCompleto" TagPrefix="uc1" %>
<%@ Register Src="Controles/CatalogoUsuario.ascx" TagName="CatalogoUsuario" TagPrefix="uc2" %>
<%@ Register Src="Controles/Canjear.ascx" TagName="Canjear" TagPrefix="uc3" %>
<%@ Register Src="Controles/Minformacion.ascx" TagName="Minformacion" TagPrefix="uc4" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gorilla - Red de Supermercados</title>
    <style type="text/css">
        * 
        {
        	font-family: Tahoma;
        	font-size: 10pt;
        }
        #form1
        {
            width: 800px;
        }
    </style>
</head>
<body>
    <div style="padding-left: 25%">
        <form id="form1" runat="server">
        <div style="width: 800px">
            <table>
                <tr>
                    <td colspan="2">
                        <img alt="logo" src="imagenes/logo.jpg" style="width: 802px; height: 100px" />
                    </td>
                </tr>
                <tr>
                    <td style="float: left; position: relative; top: 0px; width: 145px">
                        <asp:TreeView ID="ArbolOpciones" runat="server" ImageSet="Arrows" OnSelectedNodeChanged="ArbolOpciones_SelectedNodeChanged">
                            <ParentNodeStyle Font-Bold="False" />
                            <HoverNodeStyle Font-Underline="True" ForeColor="#000000" Font-Bold="true" />
                            <SelectedNodeStyle Font-Underline="True" ForeColor="#000000" Font-Bold="true" HorizontalPadding="0px"
                                VerticalPadding="0px" />
                            <Nodes>
                                <asp:TreeNode Text="Catalogo" Value="Catalogo">
                                    <asp:TreeNode Text="Completo" Value="Completo"></asp:TreeNode>
                                    <asp:TreeNode Text="Con Mis Puntos" Value="ConMisPuntos"></asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="Canjear" Value="Canjear"></asp:TreeNode>
                                <asp:TreeNode Text="Mi Informacion" Value="MiInformacion"></asp:TreeNode>
                            </Nodes>
                            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px"
                                NodeSpacing="0px" VerticalPadding="0px" />
                        </asp:TreeView>
                    </td>
                    <td style="float: left; top: 0px;">
                        <uc1:CatalogoCompleto ID="CatalogoCompleto1" runat="server" />
                        <uc2:CatalogoUsuario ID="CatalogoUsuario1" runat="server" />
                        <uc3:Canjear ID="Canjear1" runat="server" />
                        <uc4:Minformacion ID="Minformacion1" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        </form>
    </div>
</body>
</html>
