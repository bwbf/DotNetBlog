using MeuPrimeiroProjetoEF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuPrimeiroProjetoEF.Web.Views
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSenha.TextMode = TextBoxMode.Password;
            txtConfirmaSenha.TextMode = TextBoxMode.Password;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == txtConfirmaSenha.Text)
            {
                using (var context = new MeuContexto())
                {
                    Pessoa pessoa = new Pessoa
                    {
                        Nome = txtNome.Text,
                        Email = txtEmai.Text,
                        Usuario = txtUsusario.Text,
                        Senha = txtSenha.Text
                        

                    };
                    context.Pessoas.Add(pessoa);
                    context.SaveChanges();
                    Response.Redirect("Login.aspx");
                }
            }else
            {

            }
        }
    }
}