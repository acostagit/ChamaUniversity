using Chama.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Aluno.API.Models
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Task<IEnumerable<Aluno>> ObterTodos();
        Task<Aluno> ObterPorId(Guid id);
        void Adicionar(Aluno curso);
        void Atualizar(Aluno curso);
    }
}

