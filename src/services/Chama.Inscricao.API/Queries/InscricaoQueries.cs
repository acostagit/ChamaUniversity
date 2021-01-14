using Chama.Inscricao.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Queries
{
    public interface IInscricaoQueries
    {
        //TODO
        public IEnumerable<Models.Inscricao> ObterInscricoes();
  
        public Models.Inscricao ObterListaPorAluno(int id);
    }
}
