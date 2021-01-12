using Chama.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Aluno.API.Models
{
    public class Aluno: Entity, IAggregateRoot
    {
        public string  Nome { get; set; }
        public Email Email { get; private set; }

        public Cpf Cpf { get; private set; }
    
        public bool Excluido { get; set; }
        public Endereco Endereco { get; private set; }

        // EF Relation
        protected Aluno()
        {

        }

        public Aluno(Guid id, string nome, string email, string cpf)
        {
            Id = id;
            Nome = nome;
            Email = new Email(email);
            Cpf = new Cpf(cpf);
            Excluido = false;
        }
    }
}
