using Entidades.Notificacoes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    public class Noticia : Notifica
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Titulo { get; set; }

        [MaxLength(255)]
        public string Informacao { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
