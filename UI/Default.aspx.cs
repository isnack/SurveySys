using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        



    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            Cliente cliente;
            ClienteDAO clienteDAO = new ClienteDAO(ctx);

            string login = this.txtLogin.Text.Trim();
            string senha = this.txtSenha.Text.Trim();

            cliente = clienteDAO.login(login, senha);

            if (cliente!=null)
            {
                if (cliente.tipousuario_id == 1)
                {
                    Session["tipoUsuario"] = cliente.tipousuario_id;
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Session["tipoUsuario"] = cliente.tipousuario_id;
                    Response.Redirect("/Questionario/responder.aspx");

                }

            }
            else
            {
                lblResposta.Text = "Login e/ou senha inválidos";
                lblResposta.ForeColor = System.Drawing.Color.Red;
                lblResposta.Visible = true;
                limpaCampos();
            }
           
        }
    }

    private void limpaCampos()
    {
        this.txtLogin.Text = "";
        this.txtSenha.Text = "";
    }
}