using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API.DTOs
{
    public class UsuarioDTO
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public long CPF { get; set; }

        public long RG { get; set; }

        public EnderecoDTO Endereco { get; set; }

        public IList<TelefoneDTO> Telefones { get; set; }
    }
}
