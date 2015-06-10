using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class Cadastros_CadastroPergunta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarAlternativas();
    }


    protected void AddTextBox(object sender, EventArgs e)
    {
        int index = pnlAlternativas.Controls.OfType<TextBox>().ToList().Count + 1;
        this.CreateTextBox("txtAlternativa" + index);
    }

    private void CreateTextBox(string id)
    {
        TextBox txt = new TextBox();
        txt.ID = id;        
        pnlAlternativas.Controls.Add(txt);

        Literal lt = new Literal();
        lt.Text = "<br />";
        pnlAlternativas.Controls.Add(lt);
    }

    private void carregarAlternativas()
    {
        List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtAlternativa")).ToList();
        int i = 1;
        foreach (string key in keys)
        {
            this.CreateTextBox("txtAlternativa" + i);
            i++;
        }
    }
    protected void btn_click(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            Pergunta pergunta = new Pergunta();
            PerguntaDAO perguntaDao = new PerguntaDAO(ctx);

            pergunta.tipopergunta_id = 1;
            pergunta.enunciado = txtEnunciado.Text;
            perguntaDao.Insert(pergunta);

            Alternativa alternativa;
            AlternativaDAO alternativaDao = new AlternativaDAO(ctx);
            bool vazio = false;
            
            foreach (TextBox textBox in pnlAlternativas.Controls.OfType<TextBox>())
            {
                alternativa = new Alternativa();
                if (textBox.Text.Trim() == null || textBox.Text.Trim() == "")
                {
                    vazio = true;
                    break;
                }
                else
                {
                    alternativa.pergunta_id = pergunta.id;
                    alternativa.descricao = textBox.Text;
                    alternativaDao.Insert(alternativa);
                    vazio = false;
                }
            }
            if (vazio)
            {
                lblResposta.Text = "Informe as alternativas!";
                lblResposta.ForeColor = System.Drawing.Color.Red;
                lblResposta.Visible = true;
               
            }
            else
            { 
                ctx.SaveChanges();
                lblResposta.Text = "Cadastrado com sucesso!";
                lblResposta.ForeColor = System.Drawing.Color.Green;
                lblResposta.Visible = true;
            }
            
           

        }
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://localhost:54643/Admin.aspx");
    }
}