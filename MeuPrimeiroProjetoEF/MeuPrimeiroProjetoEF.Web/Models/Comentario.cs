﻿using System;

namespace MeuPrimeiroProjetoEF.Web.Models
{
    public class Comentario
    {
        public int ComentarioID { get; set; }

        public DateTime DatacComentario { get; set; }

        public string ConteudoComentario { get; set; }

        public Publicacao Publicacao { get; set; }

        public int PublicacaoID { get; set; }
    }
}