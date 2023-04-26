<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEjercicio3_B.aspx.cs" Inherits="trabajo_practico_4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listado de libros:<br />
            <br />
        </div>
        <br />
         <asp:GridView ID="gridWiewListado_Libros" runat="server" AutoGenerateColumns="False">
            <Columns>
               <asp:BoundField DataField="IdLibro" HeaderText="IdLibro" />
               <asp:BoundField DataField="IdTema" HeaderText="IdTema" />
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:BoundField DataField="Autor" HeaderText="Autor" />
            </Columns>
        </asp:GridView>
        <br />
        <a href="WebFormEjercicio3.aspx"
            <asp:LinkButton ID="LinkButtonConsultar_otro_Tema" runat="server">consultar otro tema</asp:LinkButton>
        </a>
    </form>
</body>
</html>
