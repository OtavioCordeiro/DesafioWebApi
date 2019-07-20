using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Desafio.Repositorio.Abstrato.Entidades
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        [Range(1, 99999999, ErrorMessage = "O CEP deve ter até 8 digitos")]
        public int CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
