using Chama.Core.Data;
using Chama.Curso.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Curso.API.Data.Repository
{
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoContext _context;

        public CursoRepository(CursoContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWwork => _context;

        public async Task<Models.Curso> ObterPorId(Guid id)
        {
            return await _context.Cursos.FindAsync(id);
        }

        public async Task<IEnumerable<Models.Curso>> ObterTodos()
        {
            var cursos = _context.Cursos.AsNoTracking().ToListAsync();

            return await cursos;
        }

        public  void Adicionar(Models.Curso curso)
        {
             _context.Cursos.Add(curso);
        }

        public void Atualizar(Models.Curso curso)
        {
            _context.Cursos.Update(curso);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
