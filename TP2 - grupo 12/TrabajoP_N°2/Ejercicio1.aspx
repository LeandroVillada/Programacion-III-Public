<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TrabajoP_N_2.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;Ingrese nombre del producto:
            <asp:TextBox ID="txtProducto1" runat="server" Width="217px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad:<asp:TextBox ID="txtCantidad1" runat="server" Width="217px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;Ingrese nombre del producto:
            <asp:TextBox ID="txtProducto2" runat="server" Width="217px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad:<asp:TextBox ID="txtCantidad2" runat="server" Width="217px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnTabla" runat="server" OnClick="btnTabla_Click" Text="Generar Tabla" Width="217px" />
            <br />
            <br />
            <asp:Label ID="lblTablaGenerada" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
