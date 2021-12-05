<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="www.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .col {
            width: 100px;
        }
        
        .padding-col {
            width: 16px;
        }

        .padding-row {
            height: 16px;
        }

         .margin-row {
            height: 8px;
        }

        .margin-col2 {
            width: 24px;
        }

        .text-centered {
            text-align: center; 
        }
        .flex-centered {
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 16px;
            height: 8px;
        }
        .auto-style3 {
            width: 100px;
            height: 8px;
        }
        .auto-style4 {
            width: 24px;
            height: 8px;
        }
        .auto-style5 {
        }
        .auto-style6 {
            width: 100px;
            height: 23px;
        }
        .auto-style7 {
            width: 24px;
            height: 23px;
        }
        .auto-style8 {
            margin-left: 0px;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            width: 100px;
            text-align: center;
        }
        .auto-style13 {
            text-align: center;
            height: 8px;
        }
        .auto-style14 {
            width: 100px;
            height: 23px;
            text-align: right;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="flex-centered">
            <table style="width: 100%; margin-bottom: 151px;max-width: 600px">
                <tr class="padding-row">
                    <td colspan="6" dir="ltr" class="">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6" dir="ltr" class="auto-style1">&nbsp;</t>
                        <asp:Label ID="lblTitulo" runat="server" Font-Bold="True" Text="Inicio de Sesión"></asp:Label>
                    </td>
                </tr>
                <tr class="margin-row">
                    <td colspan="6" dir="ltr" class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style7">&nbsp;</t>
                    <td class="auto-style7"></td>
                    <td class="auto-style14" dir="rtl">              
                        <asp:Label ID="lblErrorEmail" runat="server" Text="Error Email" Font-Bold="True" ForeColor="#CC0000"
                            style="width: 100%" Width="100%"></asp:Label>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr class="margin-row">
                   <td class="auto-style2"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">&nbsp;</t>
                    <td class="auto-style4"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                   <td class="padding-col">&nbsp;</td>
                    <td class="auto-style9" colspan="4">
                        <asp:TextBox ID="tbxEmail" runat="server" CssClass="auto-style8" Width="100%"></asp:TextBox>
                    </td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
                <tr class="margin-row">
                   <td class="auto-style2"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style4"><td class="auto-style4"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                   <td class="padding-col">&nbsp;</td>
                    <td class="col">
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="margin-col2">&nbsp;<td class="margin-col2">&nbsp;</td>
                    <td class="col" dir="rtl">              
                        <asp:Label ID="lblErrorPassword" runat="server" Text="Error Password" Font-Bold="True" ForeColor="#CC0000" Width="100%"></asp:Label>
                    </td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
                <tr class="margin-row">
                   <td class="auto-style2"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style4"><td class="auto-style4"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                   <td class="padding-col">&nbsp;</td>
                    <td colspan="4">
                        <asp:TextBox ID="tbxPassword" runat="server" CssClass="auto-style8" Width="100%" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
                <tr>
                   <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"><td class="auto-style7"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                   <td class="auto-style5"></td>
                    <td class="auto-style10" colspan="4">              
                        <asp:Label ID="lblErrorVentana" runat="server" Text="Error" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                   <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"><td class="auto-style7"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                   <td class="padding-col">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Button ID="btnRegistro" runat="server" Text="Registrarme" Width="126px" OnClick="btnRegistro_Click" />
                    </td>
                    <td class="margin-col2">&nbsp;<td class="margin-col2">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="126px" OnClick="btnAceptar_Click" />
                    </td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
                <tr>
                   <td class="padding-col">&nbsp;</td>
                    <td class="col">&nbsp;</td>
                    <td class="margin-col2">&nbsp;<td class="margin-col2">&nbsp;</td>
                    <td class="col">&nbsp;</td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
                <tr>
                   <td class="padding-col">&nbsp;</td>
                    <td class="col">&nbsp;</td>
                    <td class="margin-col2">&nbsp;<td class="margin-col2">&nbsp;</td>
                    <td class="col">&nbsp;</td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
                <tr class="padding-row">
                   <td class="padding-col">&nbsp;</td>
                    <td class="col">&nbsp;</td>
                    <td class="margin-col2">&nbsp;<td class="margin-col2">&nbsp;</td>
                    <td class="col">&nbsp;</td>
                    <td class="padding-col">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
