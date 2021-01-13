using Chama.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Models
{
    public interface IInscricaoRepository : IRepository<Inscricao>
    {
        Task<IEnumerable<Inscricao>> ObterTodos();
        Task<Inscricao> ObterPorId(Guid id);
        void Adicionar(Inscricao inscricao);
        void Atualizar(Inscricao inscricao);
    }
}
