using Chama.Core.DomainObjects;
using System;

namespace Chama.Aluno.API.Models
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        //...

        public Guid AlunoId{get; private set;}

        public Endereco(string logradouro, string numero)
        {
            Logradouro = logradouro;
            Numero = numero;
        }
    }
}
