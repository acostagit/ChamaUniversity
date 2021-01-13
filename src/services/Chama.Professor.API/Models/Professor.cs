using Chama.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Professor.API.Models
{
    public class Professor:Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string  Sobrenome { get; set; }
        public DateTime DataCadastro { get; set; }
        //public virtual Endereco Endereco { get; set; }
    }
}
