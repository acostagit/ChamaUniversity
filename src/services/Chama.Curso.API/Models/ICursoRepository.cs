using Chama.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chama.Curso.API.Models
{
    public interface ICursoRepository : IRepository<Curso>
    {
        Task<IEnumerable<Curso>> ObterTodos();
        Task<Curso> ObterPorId(Guid id);
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
    }
}
