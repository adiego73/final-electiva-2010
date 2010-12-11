<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUsuarioComun.aspx.cs"
    Inherits="UIWeb.indexUsuarioComun" %>

<%@ Register Src="Controles/CatalogoCompleto.ascx" TagName="CatalogoCompleto" TagPrefix="uc1" %>
<%@ Register Src="Controles/CatalogoUsuario.ascx" TagName="CatalogoUsuario" TagPrefix="uc2" %>
<%@ Register Src="Controles/Canjear.ascx" TagName="Canjear" TagPrefix="uc3" %>
<%@ Register Src="Controles/Minformacion.ascx" TagName="Minformacion" TagPrefix="uc4" %>
<%@ Register src="Controles/MisPremios.ascx" tagname="MisPremios" tagprefix="uc5" %>
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
    <div align="center">
        <form id="form1" runat="server" visible="True">
        <table style="width: 800px" align="center">
                <tr>
                    <td colspan="2">
                        <img alt="logo" src="imagenes/logo.jpg" style="width: 802px; height: 100px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right">
                    <asp:Panel ID="menuPNL" runat="server" BackColor="#FC713D" BorderColor="#333333"
                        BorderStyle="Solid" BorderWidth="1px" Width="100%">
                        <asp:Menu ID="menu" runat="server" BackColor="#FC713D" BorderWidth="0px" Font-Bold="True"
                            Font-Names="Arial" Font-Size="Small" ForeColor="#333333" Orientation="Horizontal"
                            OnMenuItemClick="menu_MenuItemClick">
                            <DynamicHoverStyle BackColor="#97BCFB" />
                            <DynamicSelectedStyle BackColor="#F1F7FE" />
                            <DynamicMenuItemStyle BackColor="#CEE0FD" BorderColor="#003366" BorderStyle="Solid"
                                BorderWidth="1px" Font-Bold="True" Font-Names="Arial" ForeColor="#003366" />
                            <Items>
                                <asp:MenuItem Text="Log Out" Value="logOut"></asp:MenuItem>
                            </Items>
                        </asp:Menu>
                    </asp:Panel>

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
                                <asp:TreeNode Text="Catalogo" Value="Catalogo" SelectAction="Expand">
                                    <asp:TreeNode Text="Completo" Value="Completo"></asp:TreeNode>
                                    <asp:TreeNode Text="Con Mis Puntos" Value="ConMisPuntos"></asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="Canjear" Value="Canjear"></asp:TreeNode>
                                <asp:TreeNode Text="Mis Premios" Value="MisPremios"></asp:TreeNode>
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
                        <uc5:MisPremios ID="MisPremios1" runat="server" />
                    </td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
