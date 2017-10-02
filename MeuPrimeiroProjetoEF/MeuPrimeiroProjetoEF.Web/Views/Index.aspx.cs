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
            var profileData = this.Session["Usuario"] as Pessoa;
            lblNomeUser.Text = "Bem vindo(a), " + profileData.Nome;

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
                if(p.Post != null)
                {
                    p.Post.Add(c);
                    context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }else
                {
                    ICollection<Publicacao> pub = new List<Publicacao>();
                    p.Post = pub;
                    p.Post.Add(c);
                    context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
               
            }
        }
    }
}