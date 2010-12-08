<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUsuarioComun.aspx.cs" Inherits="UIWeb.indexUsuarioComun" %>

<%@ Register src="Controles/CatalogoCompleto.ascx" tagname="CatalogoCompleto" tagprefix="uc1" %>
<%@ Register src="Controles/CatalogoUsuario.ascx" tagname="CatalogoUsuario" tagprefix="uc2" %>
<%@ Register src="Controles/Canjear.ascx" tagname="Canjear" tagprefix="uc3" %>
<%@ Register src="Controles/Minformacion.ascx" tagname="Minformacion" tagprefix="uc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Gorilla - Red de Supermercados</title>
       <style type="text/css">
        #form1
        {
            width: 800px;
        }
        </style>
</head>
<body>
<div style="padding-left:25%">
    <form id="form1" runat="server">
    <div style="width:800px">
        <table>
            <tr>
                <td colspan="2">
                    
                    <img alt="logo" src="imagenes/logo.jpg" style="width: 802px; height: 100px" /></td>
            </tr>
            <tr>
                <td style="width:50px; float:left; position:relative; top:0px;">
                <asp:TreeView ID="ArbolOpciones" runat="server" ImageSet="Arrows" 
                        onselectednodechanged="ArbolOpciones_SelectedNodeChanged">
                        <ParentNodeStyle Font-Bold="False" />
                        <HoverNodeStyle Font-Underline="True" ForeColor="#000000" Font-Bold="true" />
                        <SelectedNodeStyle Font-Underline="True" ForeColor="#000000"  Font-Bold="true" 
                            HorizontalPadding="0px" VerticalPadding="0px" />
                        <Nodes>
                            <asp:TreeNode Text="Catalogo" Value="Catalogo">
                                <asp:TreeNode Text="Completo" Value="Completo"></asp:TreeNode>
                                <asp:TreeNode Text="Con Mis Puntos" Value="ConMisPuntos"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Canjear" Value="Canjear"></asp:TreeNode>
                            <asp:TreeNode Text="Mi Informacion" Value="MiInformacion"></asp:TreeNode>
                        </Nodes>
                        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
                            HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    </asp:TreeView>
                </td>
                <td>
                &nbsp;<uc1:CatalogoCompleto ID="CatalogoCompleto1" runat="server" /><uc2:CatalogoUsuario ID="CatalogoUsuario1" runat="server" /><uc3:Canjear ID="Canjear1" runat="server" /><uc4:Minformacion ID="Minformacion1" runat="server" /></td>
            </tr>
        </table>
    </div>
    </form>
</div>
</body>
</html>
