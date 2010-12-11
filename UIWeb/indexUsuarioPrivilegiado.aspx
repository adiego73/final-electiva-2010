<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUsuarioPrivilegiado.aspx.cs" Inherits="UIWeb.indexUsuarioPrivilegiado" %>

<%@ Register src="Controles/SolicitudPremios.ascx" tagname="SolicitudPremios" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
        <style type="text/css">
        .style1
        {
            float: left;
            top: 0px;
            width: 664px;
        }
        * 
        {
        	font-family: Tahoma;
        	font-size: 10pt;
        }
        </style>
</head>
<body>
    <div align="center">
        <form id="form1" runat="server" visible="True">
        <table style="width: 800px; height: 207px;" align="center">
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
                        &nbsp;&nbsp;&nbsp;
                        <asp:TreeView ID="ArbolOpciones" runat="server" ImageSet="Arrows" 
                            OnSelectedNodeChanged="ArbolOpciones_SelectedNodeChanged">
                            <ParentNodeStyle Font-Bold="False" />
                            <HoverNodeStyle Font-Bold="true" Font-Underline="True" ForeColor="Black" />
                            <SelectedNodeStyle Font-Bold="true" Font-Underline="True" ForeColor="Black" 
                                HorizontalPadding="0px" VerticalPadding="0px" />
                            <Nodes>
                                <asp:TreeNode Text="Solicitud de Premios" Value="Solicitud"></asp:TreeNode>
                                <asp:TreeNode Text="Stock de Premios" Value="Stock"></asp:TreeNode>
                                <asp:TreeNode Text="Rango de Puntajes" Value="Rango"></asp:TreeNode>
                            </Nodes>
                            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
                                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                        </asp:TreeView>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="style1">
                        <uc1:SolicitudPremios ID="SolicitudPremios1" runat="server" />
                    </td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
