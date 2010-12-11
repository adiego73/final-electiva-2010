<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUsuarioPrivilegiado.aspx.cs" Inherits="UIWeb.indexUsuarioPrivilegiado" %>

<%@ Register src="Controles/SolicitudPremios.ascx" tagname="SolicitudPremios" tagprefix="uc1" %>

<%@ Register src="Controles/StockPremios.ascx" tagname="StockPremios" tagprefix="uc2" %>

<%@ Register src="Controles/RangoPuntajes.ascx" tagname="RangoPuntajes" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
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
        .style1
        {
            height: 20px;
        }
        .style2
        {
            height: 15px;
        }
    </style>
</head>
<body>
    <div align="center">
        <form id="form1" runat="server" visible="True">
        <table style="width: 800px align="center">
                <tr>
                    <td colspan="2">
                        <img alt="logo" src="imagenes/logo.jpg" style="width: 802px; height: 100px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right" style="border: solid 1px #333333; background-color:#FC713D; height:16px">
                    <div style="float:left; font-family:Arial; font-size:small; font-weight:bold; padding-left:5px; color:#333333">
                        <asp:Label ID="lNombre" runat="server"></asp:Label>
                    </div>
                    <div style="float:right">
                        <asp:Panel ID="menuPNL" runat="server" BackColor="#FC713D" BorderColor="#333333"
                            BorderStyle="Solid" BorderWidth="0px" Width="100%">
                            <asp:Menu ID="menu" runat="server" BackColor="#FC713D" BorderWidth="0px" Font-Bold="True"
                                Font-Names="Arial" Font-Size="Small" ForeColor="#333333" Orientation="Horizontal"
                                OnMenuItemClick="menu_MenuItemClick" BorderStyle="None">
                                <DynamicHoverStyle BackColor="#97BCFB" />
                                <DynamicSelectedStyle BackColor="#F1F7FE" />
                                <DynamicMenuItemStyle BackColor="#CEE0FD" BorderColor="#003366" BorderStyle="Solid"
                                    BorderWidth="1px" Font-Bold="True" Font-Names="Arial" ForeColor="#003366" />
                                <Items>
                                    <asp:MenuItem Text="Log Out" Value="logOut"></asp:MenuItem>
                                </Items>
                            </asp:Menu>
                        </asp:Panel>
                    </div>
                </td>
                </tr>
                <tr>
                    <td style="float: left; position: relative; top: 0px; width: 145px">
                        &nbsp;&nbsp;&nbsp;
                        <asp:TreeView ID="ArbolOpciones" runat="server" ImageSet="Arrows" 
                            OnSelectedNodeChanged="ArbolOpciones_SelectedNodeChanged" Font-Bold="True" ForeColor="#CC3300">
                            <ParentNodeStyle Font-Bold="False" />
                            <HoverNodeStyle Font-Bold="true" Font-Underline="True" ForeColor="Black" />
                            <SelectedNodeStyle Font-Bold="true" Font-Underline="True" ForeColor="Black" 
                                HorizontalPadding="0px" VerticalPadding="0px" />
                            <Nodes>
                                <asp:TreeNode Text="Solicitud de Premios" Value="Solicitud"></asp:TreeNode>
                                <asp:TreeNode Text="Stock de Premios" Value="Stock"></asp:TreeNode>
                                <asp:TreeNode Text="Rango de Puntajes" Value="Rango"></asp:TreeNode>
                            </Nodes>
                        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="#FF3300" HorizontalPadding="5px"
                            NodeSpacing="0px" VerticalPadding="0px" />
                        </asp:TreeView>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="style1">
                        <uc1:SolicitudPremios ID="SolicitudPremios1" runat="server" />
                        <uc2:StockPremios ID="StockPremios1" runat="server" />
                        <uc3:RangoPuntajes ID="RangoPuntajes1" runat="server" />
                    </td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
