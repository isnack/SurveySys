<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Survey Sys</title>
     <link rel="stylesheet" href="../css/pure-min.css">
</head>
<body>
    <form id="form1" runat="server" class="pure-form pure-form-stacked">
    <fieldset>
        <legend>Login</legend>
        <asp:TextBox ID="txtLogin" runat="server" placeholder="Usuário"/>
        <asp:RequiredFieldValidator ID="rfvTxtLogin" runat="server" ErrorMessage="Informe o seu usuário" ControlToValidate="txtLogin" ValidationGroup="login" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" TextMode="Password" />
        <asp:RequiredFieldValidator ID="rfvTxtSenha" runat="server" ErrorMessage="Informe uma senha" ControlToValidate="txtSenha" ValidationGroup="login" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:Button ID="btnLogin" runat="server" Text="Enviar" CssClass="pure-button pure-button-primary" OnClick="btnLogin_Click" ValidationGroup="login" />
        <asp:Label ID="lblResposta" runat="server" Text="" Visible="false"></asp:Label>
        </fieldset>
    </form>
</body>
</html>
