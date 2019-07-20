using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Desafio.Repositorio.Abstrato.Entidades
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(11)]
        public long CPF { get; set; }

        [MaxLength(9)]
        public long RG { get; set; }

        public Endereco Endereco { get; set; }

        public List<Telefone> Telefones { get; set; }
    }
}
