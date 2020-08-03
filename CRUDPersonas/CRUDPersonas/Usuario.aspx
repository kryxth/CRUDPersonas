<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="CRUDPersonas.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hdfId" runat="server" />
        <div id="divEditar" title="Editar">
            <table>
                <tr>
                    <td>Nombre:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Fecha de nacimiento:
                    </td>
                    <td>
                        <asp:Calendar runat="server" ID="cldFechaNacimiento"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>Sexo:
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlSexo"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar"/>
                    </td>
                </tr>
            </table>
        </div>
        <br /><br />
        <a onclick="window.location = 'UsuarioConsulta.aspx'" target="_new" href="patrocinador.html">Listar</a>
    </form>
    
</body>
</html>
