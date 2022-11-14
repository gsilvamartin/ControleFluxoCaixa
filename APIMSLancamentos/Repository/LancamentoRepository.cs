using System;
using APIMSLancamentos.Model.Request;
using APIMSLancamentos.Repository.Context;
using APIMSLancamentos.Repository.Context.Model;
using APIMSLancamentos.Repository.Interfaces;

namespace APIMSLancamentos.Repository
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private readonly LancamentosContext _lancamentoContext;

        public LancamentoRepository(LancamentosContext lancamentoContext)
        {
            this._lancamentoContext = lancamentoContext;
        }

        public Lancamentos GetLancamento(int idLancamento)
        {
            return _lancamentoContext.Lancamentos.Where(x => x.Id == idLancamento).First();
        }

        public bool RegistrarLancamento(LancamentoInput lancamentoInput)
        {
            var lancamento = _lancamentoContext.Add(new Lancamentos
            {
                Valor = lancamentoInput.Valor,
                Descricao = lancamentoInput.Descricao,
                Data = DateTime.UtcNow
            });

            return _lancamentoContext.SaveChanges() > 0;
        }
    }
}

