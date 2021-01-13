using Chama.Aluno.API.Models;
using Chama.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Aluno.API.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AlunosContext _context;

        public AlunoRepository(AlunosContext  context)
        {
            _context = context;
        }

        //public IUnitOfWork UnitOfWwork => _context;

        public Task<Models.Aluno> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Models.Aluno>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Models.Aluno curso)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Models.Aluno curso)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
