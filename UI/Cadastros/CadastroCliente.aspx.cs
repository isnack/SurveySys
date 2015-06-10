using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class Cadastros_CadastroCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_click(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            Cliente cliente = new Cliente();
            ClienteDAO clienteDAO = new ClienteDAO(ctx);
            cliente.nome = txtNome.Text.Trim();
            cliente.email = txtEmail.Text.Trim();
            cliente.telefone = txtTelefone.Text.Trim();
            cliente.tipousuario_id = 2;
            cliente.usuario = txtUsuario.Text.Trim();
            cliente.senha = txtSenha.Text.Trim();
            if (verificaEmail(cliente.email))
            {

                clienteDAO.Insert(cliente);
                ctx.SaveChanges();
                if (cliente.id != 0)
                {
                    lblResposta.ForeColor = System.Drawing.Color.Green;
                    lblResposta.Text = "Cadastro Realizado com sucesso!";
                    lblResposta.Visible = true;
                }
                else
                {
                    lblResposta.ForeColor = System.Drawing.Color.Red;
                    lblResposta.Text = "Não foi possível realizar seu cadastro!";
                    lblResposta.Visible = true;
                }
            }
            else
            {
                lblResposta.ForeColor = System.Drawing.Color.Red;
                lblResposta.Text = "Email já cadastrado!";
                lblResposta.Visible = true;

            }


        }

    }

    private bool verificaEmail(string email)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            Cliente cliente = new Cliente();
            ClienteDAO clienteDAO = new ClienteDAO(ctx);
            cliente = clienteDAO.getByEmail(email);
            if (cliente != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}