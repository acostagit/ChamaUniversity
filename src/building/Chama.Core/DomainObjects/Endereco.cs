using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.DomainObjects
{
    public class Endereco: Entity
    {
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }  
        public string Bairro { get; set; }

    }
}
