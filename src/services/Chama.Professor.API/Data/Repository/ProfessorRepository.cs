using Chama.Professor.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Professor.API.Data.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly ProfessorContext _context;

        public ProfessorRepository(ProfessorContext professorContext)
        {
            _context = professorContext;
        }

        public async Task<Models.Professor> ObterPorId(Guid id)
        {
            return await _context.Professores.FindAsync(id);
        }

        public async Task<IEnumerable<Models.Professor>> ObterTodos()
        {
            return await _context.Professores.AsNoTracking().ToListAsync();
        }

        public void Adicionar(Models.Professor professor)
        {
            _context.Professores.Add(professor);
        }

        public void Atualizar(Models.Professor professor)
        {
            _context.Professores.Update(professor);
        }
      
        public void Deletar(Models.Professor professor)
        {
            _context.Professores.Remove(professor);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
