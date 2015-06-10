using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["tipoUsuario"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            int tipoUsuario = (int)Session["tipoUsuario"];
            if (tipoUsuario != 1)
            {
                Response.Redirect("Default.aspx");
            }
        }

    }
    protected void btnCadCliente_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Cadastros/CadastroCliente.aspx");
    }
    protected void btnCadPergunta_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Cadastros/CadastroPergunta.aspx");
    }
    protected void btnCadQuestionario_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Cadastros/CriarQuestionario.aspx");
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}