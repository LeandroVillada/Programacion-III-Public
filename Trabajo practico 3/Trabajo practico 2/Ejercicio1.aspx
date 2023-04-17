<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Trabajo_practico_2.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Localidades</p>
        <p>
            Nombre de la localidad:&nbsp;&nbsp;
            <asp:TextBox ID="txtLocalidad" runat="server" ValidationGroup="Group0"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="fvlocalidad" runat="server" ControlToValidate="txtLocalidad" ErrorMessage="Ingrese Localidad" ValidationGroup="Group0">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLocalidad" runat="server" OnClick="btnLocalidad_Click" Text="Guardar localidad" ValidationGroup="Group0" />
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuarios</p>
        <p>
            Nombre de usuario:&nbsp;&nbsp;
            <asp:TextBox ID="txtUsuario" runat="server" ValidationGroup="Group1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Nombre de usuario vacio" ValidationGroup="Group1">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" ValidationGroup="Group1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvContraseña1" runat="server" ControlToValidate="txtContraseña" ErrorMessage="Contraseña vacio" ValidationGroup="Group1">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Repetir contraseña:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtConstraseñaRepetida" runat="server" TextMode="Password" ValidationGroup="Group1"></asp:TextBox>
        &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvContraseña2" runat="server" ControlToValidate="txtConstraseñaRepetida" ErrorMessage="Repetir contraseña vacio" ValidationGroup="Group1">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvContraseña" runat="server" ControlToCompare="txtContraseña" ControlToValidate="txtConstraseñaRepetida" ErrorMessage="Las contraseñas no son iguales" ValidationGroup="Group1">*</asp:CompareValidator>
        </p>
        <p>
            Correo electrónico:&nbsp;&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" ValidationGroup="Group1"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Correo electrónico vacio" ValidationGroup="Group1">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Correo electrónico incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Group1">*</asp:RegularExpressionValidator>
        </p>
        <p>
            CP:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCP" runat="server" ValidationGroup="Group1"></asp:TextBox>
        &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvCP" runat="server" ControlToValidate="txtCP" ErrorMessage="Codigo postal vacio" ValidationGroup="Group1">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvCP" runat="server" ControlToValidate="txtCP" ErrorMessage="Codigo postal debe ser un numero de 4 digitos" MaximumValue="9999" MinimumValue="1000" Type="Integer" ValidationGroup="Group1">*</asp:RangeValidator>
        </p>
        <p>
            Localidades:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlLocalidades" runat="server" ValidationGroup="Group1">
                <asp:ListItem Selected="True" Value="-Seleccione Localidad-">-Seleccione Localidad-</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvLocalidades" runat="server" ControlToValidate="ddlLocalidades" ErrorMessage="Debe seleccionar una localidad" InitialValue="-Seleccione Localidad-" ValidationGroup="Group1">*</asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUsuario" runat="server" Text="Guardar usuario" OnClick="btnUsuario_Click" ValidationGroup="Group1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblExito" runat="server"></asp:Label>
        </p>
        <p>
&nbsp; &nbsp;</p>
        <asp:ValidationSummary ID="vsMensajes0" runat="server" ValidationGroup="Group0" />
        <asp:ValidationSummary ID="vsMensajes1" runat="server" ValidationGroup="Group1" />
    </form>
</body>
</html>
