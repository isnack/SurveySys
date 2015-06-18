

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TesteAutomatizado.aspx.cs" Inherits="TesteAutomatizado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblTeste1" runat="server" Text="Teste de login válido"></asp:Label>
    </div>
        <div>
            <asp:Button ID="btnTeste1" runat="server" Text="Testar" OnClick="btnTeste1_Click" /></div>
        <div>
            <asp:Label ID="lblTeste2" runat="server" Text="Informar login inválido"></asp:Label></div>
        <div>
            <asp:Button ID="btnTeste2" runat="server" Text="Testar" OnClick="btnTeste2_Click" />
        </div>
        <div>
            <asp:Label ID="lblTeste3" runat="server" Text="Testa se o cliente já está na base de dados"></asp:Label>
            
        </div>
        <div>
            <asp:Button ID="btnTeste3" runat="server" Text="Testar" OnClick="btnTeste3_Click" />
        </div>

    </form>
</body>
</html>
