using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;
using System.Data;

public partial class Lista_ListaPerguntas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            PerguntaDAO perguntaDAO = new PerguntaDAO(ctx);
            int id = 1;

            this.GridPergunta.DataSource = perguntaDAO.Lista(id);
            this.GridPergunta.DataBind();
        }
    }
   
    
    
    protected void GridPergunta_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        using(surveySysEntities ctx = new surveySysEntities()){
        AlternativaDAO alt = new AlternativaDAO(ctx);
        
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // pegando id da pergunta via datakey
            int lsDataKeyValue =int.Parse( GridPergunta.DataKeys[e.Row.RowIndex].Values[0].ToString());
            //Find the DropDownList in the Row
           // setando dropdownlist
            DropDownList ddlAlternativa = (DropDownList)e.Row.FindControl("ddlAlternativa");
            
            ddlAlternativa.DataSource = alt.getAlternativas(lsDataKeyValue);
            ddlAlternativa.DataTextField = "descricao";
            ddlAlternativa.DataValueField = "id";
            ddlAlternativa.DataBind();                
            
            
            }
        }
    }
    protected void GridPergunta_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            PerguntaDAO perguntaDAO = new PerguntaDAO(ctx);
            if (e.CommandName == "Select")
            {
                int index = int.Parse((string)e.CommandArgument);
                int idPergunta = int.Parse(GridPergunta.DataKeys[index]["Id"].ToString());

                if (Session["Perguntas"] == null)
                {
                    List<Pergunta> perguntas = new List<Pergunta>();

                    perguntas.Add(perguntaDAO.get(idPergunta));
                    Session["Perguntas"] = perguntas;
                    ClientScript.RegisterStartupScript(GetType(), "tst", "<script>window.close();</script>");

                }
                else
                {
                    List<Pergunta> perguntas = (List<Pergunta>)Session["Perguntas"];
                    perguntas.Add(perguntaDAO.get(idPergunta));
                    Session["Perguntas"] = perguntas;
                    ClientScript.RegisterStartupScript(GetType(), "tst", "<script>window.close();</script>");
                }




            }
        }

    }
}