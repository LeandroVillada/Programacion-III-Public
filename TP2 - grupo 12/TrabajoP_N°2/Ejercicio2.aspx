<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TrabajoP_N_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;Nombre:<asp:TextBox ID="txtNombre" runat="server" Width="217px"></asp:TextBox>
            <br />
            <br />
&nbsp;Apellido:<asp:TextBox ID="txtApellido" runat="server" Width="217px"></asp:TextBox>
            <br />
            <br />
&nbsp;Ciudad:<asp:DropDownList ID="ddlCiudad" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
&nbsp;Temas:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="cblTemas" runat="server" AutoPostBack="True" Height="21px" Width="121px">
            </asp:CheckBoxList>
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnVerResumen" runat="server" Height="22px" OnClick="Button1_Click" Text="Ver Resumen" Width="185px" />
            <br />
        </div>
    </form>
</body>
</html>
