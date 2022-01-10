<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonaAgregar.aspx.cs" Inherits="IUWebTH.PersonaAgregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingreso de personas.</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingreso de personas</div>
        <table class="auto-style1">
            <tr>
                <td>Ingrese la cedula:</td>
                <td>
                    <asp:TextBox ID="txtCedula" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ingrese los apellidos:</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server" MaxLength="30"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ingrese los nombre:</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" MaxLength="30"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ingrese la fecha de nacimiento:</td>
                <td>
                    <asp:TextBox ID="txtFechaNac" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ingrese el peso:</td>
                <td>
                    <asp:TextBox ID="txtPeso" runat="server" MaxLength="7"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Lime"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                    <asp:LinkButton ID="LinkPersonas" runat="server" PostBackUrl="~/frmPersonas.aspx">Ver personas listadas</asp:LinkButton>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
