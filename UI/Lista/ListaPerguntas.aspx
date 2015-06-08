<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListaPerguntas.aspx.cs" Inherits="Lista_ListaPerguntas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body onunload="window.opener.location=window.opener.location;">
     <form id="form1" runat="server" class="pure-form pure-form-aligned">
     

        

         <asp:GridView ID="GridPergunta" runat="server" OnRowDataBound="GridPergunta_RowDataBound" DataKeyNames="Id" AutoGenerateColumns="False" OnRowCommand="GridPergunta_RowCommand">
            <Columns>
                <asp:BoundField DataField="enunciado" HeaderText="Enunciado" />
                <asp:TemplateField HeaderText="Alternativas">
                    <ItemTemplate>
                    <asp:DropDownList runat="server" ID="ddlAlternativa"></asp:DropDownList>
                        </ItemTemplate>
                </asp:TemplateField>

                <asp:ButtonField CommandName="Select"  HeaderText="Adicionar" ShowHeader="True" Text="Adicionar" />

            </Columns>

         </asp:GridView>


       
       
    </form>
</body>
</html>
