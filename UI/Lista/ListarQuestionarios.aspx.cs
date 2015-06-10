using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class Lista_ListarQuestionarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            QuestionarioDAO q = new QuestionarioDAO(ctx);
            List<Questionario> questionariosDisponíveis = q.getQuestionarioNaoRespondidos(2);
            if (!IsPostBack)
            {
                gdvQuestionarios.DataSource = questionariosDisponíveis;
                gdvQuestionarios.DataBind();
            }

        }
    }
    protected void gdvQuestionarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "responder")
        {
            int index = int.Parse((string)e.CommandArgument);
            int questionarioId = int.Parse(gdvQuestionarios.DataKeys[index]["id"].ToString());

            Response.Redirect("/Questionario/Responder.aspx?questionarioId=" + questionarioId + "");
            
        }
    }
}