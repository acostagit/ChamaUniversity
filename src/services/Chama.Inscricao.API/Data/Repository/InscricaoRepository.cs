using Chama.Inscricao.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Data.Repository
{
    public class InscricaoRepository : IInscricaoRepository
    {
        private readonly InscricaoContext _context;

        public InscricaoRepository(InscricaoContext context)
        {
            _context = context;
        }


        public async Task<Models.Inscricao> ObterPorId(Guid id)
        {
            return await _context.Inscricoes.FindAsync(id);
        }

        public async Task<IEnumerable<Models.Inscricao>> ObterTodos()
        {

            var inscricoes = _context.Inscricoes.AsNoTracking().ToListAsync();

            return await inscricoes;
        }

        public void Adicionar(Models.Inscricao inscricao)
        {
            _context.Inscricoes.Add(inscricao);
        }

        public void Atualizar(Models.Inscricao inscricao)
        {
            _context.Inscricoes.Update(inscricao);
        }
        public void Deletar(Models.Inscricao inscricao)
        {
            _context.Inscricoes.Remove(inscricao);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
