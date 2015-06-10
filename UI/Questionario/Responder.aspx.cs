using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class Questionario_Responder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            int questionarioId = int.Parse(Request.QueryString["questionarioId"]);

            PerguntaDAO perguntaDAO = new PerguntaDAO(ctx);
            Questionario questionario = new Questionario();
           
        }
    }
}