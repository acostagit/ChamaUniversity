using Chama.Professor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Professor.API.Data.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly ProfessorContext _professorContext;

        public ProfessorRepository(ProfessorContext professorContext)
        {
            _professorContext = professorContext;
        }
        public void Adicionar(Models.Professor curso)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Models.Professor curso)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Models.Professor> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Models.Professor>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
