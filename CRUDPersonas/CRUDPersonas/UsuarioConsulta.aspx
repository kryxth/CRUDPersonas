<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioConsulta.aspx.cs" Inherits="CRUDPersonas.UsuarioConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
    <link rel="stylesheet" href="/resources/demos/style.css"/>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <script type="text/javascript">

    </script>

</head>
<body>
    <form runat="server" id="form1">
        <asp:HiddenField ID="hdfId" runat="server" />

        <asp:GridView ID="grvPersonas" runat="server" DataKeyNames="IdPersona" OnRowCommand="grvPersonas_RowCommand" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de nacimiento" />
                <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                <asp:ButtonField CommandName="Editar" HeaderText="Editar" text="Editar"/>
                <asp:ButtonField CommandName="Eliminar" HeaderText="Eliminar" text="Eliminar"/>
            </Columns>
        </asp:GridView>
        <br />
        <asp:LinkButton ID="lnkNuevo" Text="Nuevo" OnClick="lnkNuevo_Click" runat="server"></asp:LinkButton>


        <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    </form>

</body>
</html>
