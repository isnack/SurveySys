using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveySysDAO;

public partial class TesteAutomatizado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTeste1_Click(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            string naoDesejado = null;
            Cliente cliente;
            ClienteDAO clienteDAO = new ClienteDAO(ctx);

            string login = "isnack";
            string senha = "123456";

            cliente = clienteDAO.login(login, senha);
            

            if (cliente.nome != naoDesejado)
            {
                btnTeste1.ForeColor = System.Drawing.Color.Green;
                btnTeste1.Text = "Validado";

            }
            else
            {
                btnTeste1.ForeColor = System.Drawing.Color.Red;
                btnTeste1.Text = "Error";
            }

        }
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
    protected void btnTeste2_Click(object sender, EventArgs e)
    {
        using (surveySysEntities ctx = new surveySysEntities())
        {
            Cliente cliente;
            ClienteDAO clienteDAO = new ClienteDAO(ctx);
            Cliente desejado = null;
            string login = "isnack";
            string senha = "1234567";

            cliente = clienteDAO.login(login, senha);

            if (cliente == desejado)
            {
                btnTeste2.ForeColor = System.Drawing.Color.Green;
                btnTeste2.Text = "Validado Barrado o Login";

            }
            else
            {
                btnTeste2.ForeColor = System.Drawing.Color.Red;
                btnTeste2.Text = "Error Login inválido passou!";
                btnTeste2.BackColor = System.Drawing.Color.White;

            }

        }

    }

    
    protected void btnTeste3_Click(object sender, EventArgs e)
    {
        bool desejado = false;
        string email = "isnack_yagami@hotmail.com";
        if (verificaEmail(email)==desejado)
        {
            btnTeste3.ForeColor = System.Drawing.Color.Green;
            btnTeste3.Text = "Cliente Cadastrado na base de dados";
            btnTeste3.BackColor = System.Drawing.Color.White;

        }
        else
        {
            btnTeste3.ForeColor = System.Drawing.Color.Green;
            btnTeste3.Text = "O cliente esta cadastrado mas não está listando!";
            btnTeste3.BackColor = System.Drawing.Color.White;   
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