using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Aluno.API.Application.Commands
{
    public class RegistrarAlunoCommand
    {
        //Dados a serem levados para o banco

        public Guid Id { get; private set; }
        public string Nome { get; set; }

        //TODO...
    }
}
