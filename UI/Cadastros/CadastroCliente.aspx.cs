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
        
            Cliente cliente = new Cliente();
            ClienteDAO clienteDAO = new ClienteDAO();
            cliente.nome = txtNome.Text;
            cliente.email=txtEmail.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.tipousuario_id = 2;
            cliente.usuario = txtUsuario.Text;
            cliente.senha = txtSenha.Text;
            if (verificaEmail(cliente.email))
            {

                clienteDAO.Insert(cliente);
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

    private bool verificaEmail(string email)
    {
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        cliente = clienteDAO.getByEmail(email);
        if (cliente!=null)
        {
            return false;
        }
        else
        {
            return true;
        }        

    }
}