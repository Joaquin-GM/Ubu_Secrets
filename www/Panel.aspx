<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="www.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            height: 23px;
            width: 20%;
        }
        .auto-style3 {
            text-align: right;
            height: 23px;
            width: 20%;
        }
        .auto-style4 {
            text-align: center;
            height: 23px;
            width: 60%;
        }
        .panel-container {
            display: flex;
            align-items: self-start;
            justify-content: center;
            height: 80vh;
            padding: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel-container">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style4">
                        <asp:Label ID="lblTitulo" runat="server" Font-Bold="True">Panel</asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="btnSalir" runat="server" OnClick="btnSalir_Click" Text="Cerrar Sesión" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
