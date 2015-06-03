<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastroCliente.aspx.cs" Inherits="Cadastros_CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Clientes</title>
    <link rel="stylesheet" href="../css/pure-min.css">
</head>
<body>
    <form class="pure-form pure-form-aligned" runat="server">
    
        <div class="pure-control-group">
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </div>

        

        <div class="pure-control-group">
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>

         <div class="pure-control-group">
            <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" MaxLength="11"></asp:TextBox>
        </div>

       <div class="pure-control-group">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuário"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </div>
         <div class="pure-control-group">
            <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div class="pure-controls">
           
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="pure-button pure-button-primary" OnClick="btn_click" />
            <asp:Label ID="lblResposta" runat="server"  Visible="false"></asp:Label>
        </div>

    
</form>
</body>
</html>
