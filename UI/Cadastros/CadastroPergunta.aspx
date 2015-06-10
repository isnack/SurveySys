<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastroPergunta.aspx.cs" Inherits="Cadastros_CadastroPergunta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/CadastroPergunta.js"></script>
</head>
    <link rel="stylesheet" href="../css/pure-min.css" />
<body>
   
     <form class="pure-form pure-form-aligned" runat="server">
    
        <div class="pure-control-group">
            <asp:Label ID="lblEnunciado" runat="server" Text="Enunciado:"></asp:Label>
            <asp:TextBox ID="txtEnunciado" runat="server" TextMode="MultiLine" onkeypress="limitaTextarea(this.value)"></asp:TextBox>
            <asp:Label ID="lblContador" runat="server" ></asp:Label>
        </div>
         <asp:Panel ID="pnlAlternativas" runat="server" >

         </asp:Panel>
       
          <asp:Button ID="btnAlternativa" runat="server" Text="Adicionar Alternativa" CssClass="pure-button pure-button-primary" OnClick="AddTextBox"  />

        <div class="pure-controls">
           
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="pure-button pure-button-primary" OnClick="btn_click" ValidationGroup="cadPergunta"  />
            <asp:Label ID="lblResposta" runat="server"  Visible="false"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvEnunciado" ControlToValidate="txtEnunciado" runat="server" ErrorMessage="Informe um enunciado" ValidationGroup="cadPergunta" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
         <div>
             <asp:Button ID="btnVoltar" runat="server" Text="Voltar"  OnClick="btnVoltar_Click"/>
         </div>
    
</form>

</body>
</html>
