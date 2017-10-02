using System;
using System.Collections.Generic;

namespace MeuPrimeiroProjetoEF.Web.Models
{
    public class Publicacao
    {
        public int PublicacaoID { get; set; }

        public DateTime DataPost { get; set; }

        public string Conteudo { get; set; }

        public ICollection<Comentario> ComentarioPost { get; set; }
    }
}