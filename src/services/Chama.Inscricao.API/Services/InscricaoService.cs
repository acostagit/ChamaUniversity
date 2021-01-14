using Chama.Inscricao.API.Data.Repository;
using Chama.Inscricao.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Services
{
    public class InscricaoService: IInscricaoRepository
    {
        private readonly InscricaoRepository _repository;
        public InscricaoService(InscricaoRepository repository)
        {
            _repository = repository;
        }

        public Task<Models.Inscricao> ObterPorId(Guid id)
        {
            return _repository.ObterPorId(id);
        }
        public Task<IEnumerable<Models.Inscricao>> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Adicionar(Models.Inscricao inscricao)
        {
            _repository.Adicionar(inscricao);
        }

        public void Atualizar(Models.Inscricao inscricao)
        {
            _repository.Atualizar(inscricao);
        }

        public void Deletar(Models.Inscricao inscricao)
        {
            _repository.Deletar(inscricao);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
    }
}
