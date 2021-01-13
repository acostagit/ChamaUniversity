using Chama.Inscricao.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Data.Repository
{
    public class InscricaoRepository : IInscricaoRepository
    {
        public Task<Models.Inscricao> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Models.Inscricao>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Models.Inscricao inscricao)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Models.Inscricao inscricao)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
