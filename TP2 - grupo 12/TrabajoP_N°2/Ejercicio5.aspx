<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TrabajoP_N_2.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left: 40px">
&nbsp;<asp:Label ID="lbl1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" Text="Elija su configuración"></asp:Label>
            </p>
            <p style="margin-left: 40px">
                <asp:Label ID="lbl2" runat="server" Text="Seleccione cantidad de memoria:"></asp:Label>
            </p>
            <p style="margin-left: 40px">
                <asp:DropDownList ID="ddlMemoria" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMemoria_SelectedIndexChanged">
                </asp:DropDownList>
            </p>
            <p style="margin-left: 40px">
                <asp:Label ID="lbl3" runat="server" Text="Seleccione cantidad de accesorios:"></asp:Label>
            </p>
            <p style="margin-left: 40px">
                <asp:CheckBoxList ID="cblAccesorios" runat="server" AutoPostBack="True">
                </asp:CheckBoxList>
            </p>
            <p style="margin-left: 40px">
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular Precio" />
            </p>
            <p style="margin-left: 40px">
                <asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
