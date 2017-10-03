using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjetoEF.Web.Models
{
    public class Publicacao
    {
        public int PublicacaoID { get; set; }

        public DateTime DataPost { get; set; }

        public string Conteudo { get; set; }               

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

        public ICollection<Comentario> Comentario { get; set; }
    }
}