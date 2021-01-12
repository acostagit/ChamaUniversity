using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Models
{
    public class Inscricao
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataInscricao { get; set; }
        public int Quantidade { get; set; }


        public Inscricao(Guid id, int numero, DateTime dataInscricao, int quantidade)
        {
            Id = id;
            Numero = numero;
            DataInscricao = dataInscricao;
            Quantidade = quantidade;
        }

        private Inscricao RetornaMinimoAlunos(List<Inscricao> inscricaos)
        {
            var minimo = inscricaos.Min<Inscricao>();

            return minimo;
        }

        private Inscricao RetornaMaximoAlunos(List<Inscricao> inscricaos)
        {
            var max = inscricaos.Max<Inscricao>();

            return max;
        }

        private double RetornaMediaAlunos(List<Inscricao> inscricaos)
        {
            var media = inscricaos.Average(f => f.Numero);

            return media;
        }
    }
}
