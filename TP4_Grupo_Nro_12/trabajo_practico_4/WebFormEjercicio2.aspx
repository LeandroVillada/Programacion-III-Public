<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEjercicio2.aspx.cs" Inherits="trabajo_practico_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp; id productos:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListProducto" runat="server">
            <asp:ListItem Value="igual a">igual a: </asp:ListItem>
            <asp:ListItem Value="mayor a">mayor a:</asp:ListItem>
            <asp:ListItem Value="menor a">menor a: </asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:TextBox ID="TextBoxProducto" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;id categorias:&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListCategoria" runat="server">
            <asp:ListItem Value="igual a">igual a:</asp:ListItem>
            <asp:ListItem Value="mayor a">mayor a:</asp:ListItem>
            <asp:ListItem Value="menor a">menor a:</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxCategoria" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonFiltrar" runat="server" OnClick="ButtonFiltrar_Click" Text="filtrar" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonQuitar_filtro" runat="server" Text="quitar filtro" OnClick="ButtonQuitar_filtro_Click" />
        </div>
        <br />
        <asp:GridView ID="gridWiewProductos_Categorias" runat="server" AutoGenerateColumns="False">
            <Columns>
               <asp:BoundField DataField="IdProducto" HeaderText="IdProducto" />
               <asp:BoundField DataField="NombreProducto" HeaderText="NombreProducto" />
                <asp:BoundField DataField="IdCategoría" HeaderText="IdCategoría" />
                <asp:BoundField DataField="CantidadPorUnidad" HeaderText="CantidadPorUnidad" />
                <asp:BoundField DataField="PrecioUnidad" HeaderText="PrecioUnidad" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
