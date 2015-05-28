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
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        cliente.nome = "Isnack";
        cliente.telefone="3598348755";
        cliente.email = "isnack_yagami@hotmail.com";
        cliente.usuario = "isnack";
        cliente.senha = "123456";
        cliente.tipousuario_id = 1;

        clienteDAO.Insert(cliente);



    }
}