<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEjercicio3.aspx.cs" Inherits="trabajo_practico_4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            seleccionar tema:&nbsp;
            <asp:DropDownList ID="DropDownListTemas" runat="server">
                <asp:ListItem>Tema 1</asp:ListItem>
                <asp:ListItem>Tema 2</asp:ListItem>
                <asp:ListItem>Tema 3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:LinkButton ID="LinkButtonVer_Libros" runat="server" OnClick="LinkButtonVer_Libros_Click">Ver Libros</asp:LinkButton>
        </div>
    </form>
</body>
</html>
