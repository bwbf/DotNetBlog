using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuPrimeiroProjetoEF.Web.Models
{
    [Serializable]
    public class Pessoa
    {


        public int PessoaID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public ICollection<Publicacao> Post { get; set; }
    }
}