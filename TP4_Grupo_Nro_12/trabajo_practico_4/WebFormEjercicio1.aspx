<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEjercicio1.aspx.cs" Inherits="trabajo_practico_4.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            background-color: #FFFFFF;
        }
        .auto-style3 {
            margin-left: 40px;
        }
        .auto-style5 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style3">
        <div class="auto-style1">
        <ins style="text-align: center">
            <span class="auto-style2">DESTINO INICIO</span>
         </ins>
        </div>
        <p class="auto-style3">
            <b>PROVINCIA:</b>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProvinciaInicio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged">
            </asp:DropDownList>
            <br class="auto-style3" />
            <b>LOCALIDAD:</b>&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlLocalidadInicio" runat="server">
            </asp:DropDownList>
            </p>
        <div class="auto-style5">
            <p>
        DESTINO FINAL
         </p>
        </div>
        <p class="auto-style3">
            <b>PROVINCIA:</b>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProvinciaFinal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged">
            </asp:DropDownList>
            <br class="auto-style3" />
            <b>LOCALIDAD:</b>&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlLocalidadFinal" runat="server">
            </asp:DropDownList>
            </p>
    </div>
    </form>
</body>
</html>
