﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TrabajoP_N_2.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lbRojo" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Font-Underline="True" OnClick="lbRojo_Click">Rojo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lbAzul" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Font-Underline="True" OnClick="lbAzul_Click">Azul</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lbVerde" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Font-Underline="True" OnClick="lbVerde_Click">Verde</asp:LinkButton>
            <br />
            <br />
            <br />
            <asp:Label ID="lblColorear" runat="server" Text="Texto coloreado"></asp:Label>
        </div>
    </form>
</body>
</html>
