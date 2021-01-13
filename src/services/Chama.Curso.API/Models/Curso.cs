using Chama.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Curso.API.Models
{
    public class Curso: Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public decimal Preco { get; private set; }
        public DateTime DataCadastro { get; set; }
    }
}
