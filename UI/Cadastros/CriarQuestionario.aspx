<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CriarQuestionario.aspx.cs" Inherits="Cadastros_CriarQuestionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
     <link rel="stylesheet" href="../css/pure-min.css" />
<body >
    <form id="form1" runat="server" class="pure-form pure-form-aligned">
     <div class="pure-control-group">
            <asp:Label ID="lblTitulo" runat="server" Text="Título"></asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvTxtTitulo" runat="server" ErrorMessage="Insira um título" ControlToValidate="txtTitulo" ValidationGroup="questionario" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        

        <div class="pure-control-group">
            <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTxtDescricao" runat="server" ErrorMessage="Insira uma descrição" ValidationGroup="questionario" ControlToValidate="txtDescricao" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:LinkButton ID="lknAddPergunta" runat="server" OnClientClick="window.open('/Lista/ListaPerguntas.aspx');return false;">Adicionar Pergunta</asp:LinkButton>
        </div>
        <asp:GridView ID="gridPerguntas" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="pure-table-horizontal">
            <Columns>
                <asp:BoundField DataField="enunciado" HeaderText="Perguntas" />
            </Columns>
        </asp:GridView>

        <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="btnSalvar_Click" ValidationGroup="questionario" />
    </form>
</body>
</html>
