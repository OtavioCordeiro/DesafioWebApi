using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Desafio.Repositorio.Abstrato.Entidades
{
    [Table("Telefone")]
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public long Numero { get; set; }
        public string Tipo { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
