using MeuPrimeiroProjetoEF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuPrimeiroProjetoEF.Web.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new MeuContexto();
            var profileData = this.Session["Usuario"] as Pessoa;
            var p = context.Pessoas.Where(s => s.PessoaID == profileData.PessoaID).FirstOrDefault<Pessoa>();
            lblNomeUser.Text = "Bem vindo(a), " + profileData.Nome;
            ListView1.DataSource = p.Publicacao;
            ListView1.DataBind();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            var profileData = this.Session["Usuario"] as Pessoa;
            using (var context = new MeuContexto())
            {
                

                Publicacao c = new Publicacao
                {
                    Conteudo = txtPost.Text,
                    DataPost = DateTime.Now

                };
                var p = context.Pessoas.Where(s => s.PessoaID == profileData.PessoaID).FirstOrDefault<Pessoa>();
                if(p.Publicacao != null)
                {
                    p.Publicacao.Add(c);
                    context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }else
                {
                    p.Publicacao = new List<Publicacao>();
                    p.Publicacao.Add(c);
                    context.SaveChanges();
                    txtPost.Text = "";
                    ListView1.DataSource = p.Publicacao;
                    ListView1.DataBind();
                    this.Session["Usuario"] = p;
                }
               
            }
        }
        
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var profileData = this.Session["Usuario"] as Pessoa;
            ((Label)e.Item.FindControl("lblNome")).Text = profileData.Nome;

        }

        protected List<Publicacao> getMockPub()
        {
            List<Publicacao> p = new List<Publicacao>();
            for (int i = 0; i < 10; i++)
            {
                Publicacao mock = new Publicacao();
                mock.Conteudo = "teste " + i;
                mock.DataPost = DateTime.Now;

                p.Add(mock);
            }

            return p;
        }

        protected void ComentarBT_Click(object sender, EventArgs e)
        {

        }
    }
}