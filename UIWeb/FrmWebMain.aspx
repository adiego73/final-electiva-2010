<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmWebMain.aspx.cs" Inherits="UIWeb._Default" %>

<%@ Register src="Controles/FirstLogIn.ascx" tagname="firstLogIn" tagprefix="uc1" %>

<%@ Register src="Controles/Ingreso.ascx" tagname="Ingreso" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    </head>
<body>
    <form id="form1" runat="server" visible="True">
    <asp:Panel ID="menuPNL" runat="server" BackColor="#CEE0FD" 
        BorderColor="#003366" BorderStyle="Solid" BorderWidth="1px" Width="100%">
        <asp:Menu ID="menu" runat="server" BackColor="#CEE0FD" BorderWidth="0px" 
            Font-Bold="True" Font-Names="Arial" 
        Font-Size="Small" ForeColor="#003366" Orientation="Horizontal" 
            onmenuitemclick="menu_MenuItemClick">
            <DynamicHoverStyle BackColor="#97BCFB" />
            <DynamicSelectedStyle BackColor="#F1F7FE" />
            <DynamicMenuItemStyle BackColor="#CEE0FD" BorderColor="#003366" 
            BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" 
            ForeColor="#003366" />
            <Items>
                <asp:MenuItem Text="Log In" Value="baselogin">
                    <asp:MenuItem Text="Log In" Value="logIn"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="ver" Value="ver"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </asp:Panel>
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
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

    </form>
</body>
</html>
