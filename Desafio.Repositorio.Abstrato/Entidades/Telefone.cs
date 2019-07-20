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
        [Key]
        public int TelefoneId { get; set; }
        [Range(1, 99999999999, ErrorMessage = "O telefone deve ter até 12 digitos")]
        [Required]
        public long Numero { get; set; }
        public string Tipo { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
