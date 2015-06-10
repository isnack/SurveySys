using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class Cadastros_CriarQuestionario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            verificaSession();
            // se a sessão for vazia carrega o gridview
            if (Session["Perguntas"] == null)
            {
                gridPerguntas.DataBind();
            }
            else
            {
                //popula o gridview
                gridPerguntas.DataSource = (List<Pergunta>)Session["Perguntas"];
                gridPerguntas.DataBind();
            }

        }

    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        using(surveySysEntities ctx = new surveySysEntities()){

        Questionario questionario = new Questionario();
        QuestionarioDAO questionarioDAO = new QuestionarioDAO(ctx);
        PerguntaDAO perguntaDAO = new PerguntaDAO(ctx);
        Pergunta pergunta;
        bool gridVazio = true;
        string mensagem = null;
        questionario.descricao = this.txtDescricao.Text;
        questionario.titulo = this.txtTitulo.Text;
        
        //percorre o gridview pegando os ids e grava as perguntas do questionario no banco
        foreach (GridViewRow row in gridPerguntas.Rows)
        {
            pergunta = new Pergunta();
            int perguntaId = int.Parse(gridPerguntas.DataKeys[row.RowIndex]["Id"].ToString());
            if (perguntaId == 0)
            {
                gridVazio = true;
                break;
            }
            else
            {
                pergunta = perguntaDAO.get(perguntaId);
                questionario.PerguntaSet.Add(pergunta);
                pergunta.QuestionarioSet.Add(questionario);
                gridVazio = false;
            }
           

        }

        if (gridVazio)
        {
            mensagem = "Adicione perguntas ao questionário";
            limparCampos(mensagem,gridVazio);
        }
        else
        {
            questionarioDAO.Insert(questionario);
           // ctx.SaveChanges();
            mensagem = "Questionário criado com sucesso!";
            limparCampos(mensagem,gridVazio);
        }

       
        }
    }

    private void limparCampos(string mensagem,bool resultado)
    {
        Session.Abandon();
        this.txtDescricao.Text = "";
        this.txtTitulo.Text = "";
        lblResposta.Text = mensagem;
        if (resultado)
        {
            lblResposta.ForeColor = System.Drawing.Color.Red; 
        }
        else
        {
            lblResposta.ForeColor = System.Drawing.Color.Green;
        }
        lblResposta.Visible = true;
        this.gridPerguntas.DataBind();
    }
    private void verificaSession()
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
                Response.Redirect("localhost/Default.aspx");
            }
        }

    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://localhost:54643/Admin.aspx");
    }
   
}