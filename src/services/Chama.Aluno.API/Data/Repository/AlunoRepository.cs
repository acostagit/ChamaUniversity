using Chama.Aluno.API.Models;
using Chama.Core.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Models.Aluno> ObterPorId(Guid id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task<IEnumerable<Models.Aluno>> ObterTodos()
        {
            var alunos = _context.Alunos.AsNoTracking().ToListAsync();

            return await alunos;
        }

        public void Adicionar(Models.Aluno aluno)
        {
            _context.Alunos.Add(aluno);
        }

        public void Atualizar(Models.Aluno aluno)
        {
            _context.Alunos.Update(aluno);
        }

        public void Deletar(Models.Aluno aluno)
        {
            _context.Alunos.Remove(aluno);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
