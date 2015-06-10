<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarQuestionarios.aspx.cs" Inherits="Lista_ListarQuestionarios"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
     <link rel="stylesheet" href="../css/pure-min.css">
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gdvQuestionarios" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnRowCommand="gdvQuestionarios_RowCommand">
            <Columns>
                
                <asp:BoundField DataField="titulo" HeaderText="Título"  />
                <asp:BoundField DataField="descricao" HeaderText="Descrição" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnResponder" CssClass="pure-button pure-button-primary" CommandName="responder" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"  runat="server" Text="Button" />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            

        </asp:GridView>
    </div>
    </form>
</body>
</html>
