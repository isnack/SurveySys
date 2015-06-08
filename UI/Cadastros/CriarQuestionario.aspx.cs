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
        Questionario questionario = new Questionario();
        QuestionarioDAO questionarioDAO = new QuestionarioDAO();
       


        questionario.descricao = this.txtDescricao.Text;
        questionario.titulo = this.txtTitulo.Text;
        questionarioDAO.Insert(questionario);


        //percorre o gridview pegando os ids e grava as perguntas do questionario no banco
        foreach (GridViewRow row in gridPerguntas.Rows)
        {


            int perguntaId = int.Parse(gridPerguntas.DataKeys[row.RowIndex]["Id"].ToString());


        }
        
        limparCampos();
        
    }

    private void limparCampos()
    {
        Session.Abandon();
        this.txtDescricao.Text = "";
        this.txtTitulo.Text = "";
        this.gridPerguntas.DataBind();
    }
}