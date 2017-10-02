namespace MeuPrimeiroProjetoEF.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MeuContexto : DbContext
    {

        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }

        public virtual DbSet<Publicacao> Publicacoes { get; set; }


        public MeuContexto()
            : base("name=MeuContexto")
        {
        }
        
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}