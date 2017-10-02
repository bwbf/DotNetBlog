using MeuPrimeiroProjetoEF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuPrimeiroProjetoEF.Web.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var context = new MeuContexto())
            {
                Pessoa p = new Pessoa
                {
                    Usuario = txtUsuario.Text,
                    Senha = txtSenha.Text

                };

                var user = context.Pessoas.FirstOrDefault(u => u.Usuario == p.Usuario && u.Senha == p.Senha);
                if (user != null)
                {
                    Response.Redirect("Index.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }
    }
}