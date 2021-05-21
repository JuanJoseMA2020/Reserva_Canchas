<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAdmin.aspx.cs" Inherits="Hospital.FrmCita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 588px;
        }
        .auto-style6 {
            width: 382px;
        }
        .auto-style7 {
            height: 24px;
            width: 382px;
        }
        .auto-style8 {
            height: 24px;
            width: 588px;
        }
        .auto-style9 {
            height: 24px;
        }
        .auto-style10 {
            height: 11px;
            width: 382px;
        }
        .auto-style11 {
            height: 11px;
            width: 588px;
        }
        .auto-style12 {
            height: 11px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">CODIGO USUARIO</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TxtCodigo_user" runat="server" Enabled="False"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LblMensaje" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style9">
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblnomuser" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="lblteluser" runat="server"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="lbldireccionuser" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">CODIGO RESERVA</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TxtCodigo" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style12">
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    CODIGO CANCHA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtcod_cancha" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnCancha" runat="server" Text="Consultar cancha" OnClick="BtnCancha_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    LUGAR CANCHA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtLugarCancha" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    MATERIAL CANCHA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtMaterialCancha" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    ESTADO CANCHA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtEstadoCancha" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnActivar" runat="server" OnClick="BtnActivar_Click" Text="Activar Reservación" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    NOMBRE CANCHA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtnom_cancha" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">FECHA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtFecha" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnActivarUser" runat="server" OnClick="BtnActivarUser_Click" Text="Activar consulta de usuario" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">HORA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtHora" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">VALOR RESERVA</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Txtvalor_reserva" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">LUGAR</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Txtlugar_cancha" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    NOMBRE USUARIO</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtnom_usuario" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnUser" runat="server" Text="Consultar Usuario" Enabled="False" OnClick="BtnUser_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    TELEFONO USUARIO</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtel_usuario" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="BtnAnular" runat="server" Text="Anular reserva" OnClick="BtnAnular_Click" Enabled="False" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar reserva" OnClick="BtnGuardar_Click" Enabled="False" />
                </td>
                <td>
                    <asp:Button ID="BtnCancerlar" runat="server" Text="Cancelar" Enabled="False" OnClick="BtnCancerlar_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
