using Chama.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Professor.API.Models
{
   public interface IProfessorRepository: IRepository<Professor>
    {
        Task<IEnumerable<Professor>> ObterTodos();
        Task<Professor> ObterPorId(Guid id);
        void Adicionar(Professor professor);
        void Atualizar(Professor professor);
        void Deletar(Professor professor);

    }
}
