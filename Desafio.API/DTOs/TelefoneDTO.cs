using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API.DTOs
{
    public class TelefoneDTO
    {
        public int TelefoneId { get; set; }
        public long Numero { get; set; }
        public string Tipo { get; set; }
        public int UsuarioId { get; set; }
    }
}
