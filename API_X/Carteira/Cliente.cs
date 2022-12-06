using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_X.Carteira
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }
    }
}
