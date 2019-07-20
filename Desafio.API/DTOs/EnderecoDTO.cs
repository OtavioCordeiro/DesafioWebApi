using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API.DTOs
{
    public class EnderecoDTO
    {
        public int EnderecoId { get; set; }
        public int CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public int UsuarioId { get; set; }
    }
}
