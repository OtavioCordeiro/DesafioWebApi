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
        public string Nome { get; set; }
        public long CPF { get; set; }
        public long RG { get; set; }
        public Endereco Endereco { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
