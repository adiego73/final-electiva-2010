<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmWebMain.aspx.cs" Inherits="UIWeb._Default" %>

<%@ Register Src="Controles/FirstLogIn.ascx" TagName="firstLogIn" TagPrefix="uc1" %>
<%@ Register Src="Controles/Ingreso.ascx" TagName="Ingreso" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gorilla - Red de Supermercados</title>
    <style type="text/css">
        #form1
        {
            height: 453px;
            width: 800px;
        }
        </style>
</head>
<body>
    <div align="center">
        <form id="form1" runat="server" visible="True">
        <table style="width: 800px" align="center">
            <tr>
                <td>
                    <img alt="logo" src="imagenes/logo.jpg" style="width: 802px; height: 100px" />
                </td>
            </tr>
            <tr>
            <td colspan="2" align="right" style="border: solid 1px #333333; background-color:#FC713D; height:16px">
                    <div style="float:left; font-family:Arial; font-size:small; font-weight:bold; padding-left:5px; color:#333333">
                        <asp:Panel ID="menuPNL" runat="server" BackColor="#FC713D" BorderColor="#333333"
                        BorderStyle="Solid" BorderWidth="0px" Width="100%">
                        <asp:Menu ID="menu" runat="server" BackColor="#FC713D" BorderWidth="0px" Font-Bold="True"
                            Font-Names="Arial" Font-Size="Small" ForeColor="#333333" Orientation="Horizontal"
                            OnMenuItemClick="menu_MenuItemClick">
                            <DynamicHoverStyle BackColor="#97BCFB" />
                            <DynamicSelectedStyle BackColor="#F1F7FE" />
                            <DynamicMenuItemStyle BackColor="#CEE0FD" BorderColor="#003366" BorderStyle="Solid"
                                BorderWidth="1px" Font-Bold="True" Font-Names="Arial" ForeColor="#003366" />
                            <Items>
                                <asp:MenuItem Text="Log In" Value="logIn"></asp:MenuItem>
                            </Items>
                        </asp:Menu>
                    </asp:Panel>
                    </div>
                </td>
                </tr>
                <tr>
                <td style="width: 800px; text-align: left" align="center">
                    <br />
                    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 98%">
                        <tr>
                            <td align="center">
                                <asp:Label ID="introLB" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"
                                    ForeColor="#333333"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc3:Ingreso ID="Ingreso1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:firstLogIn ID="firstLogIn" runat="server" Visible="False" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
</html>
