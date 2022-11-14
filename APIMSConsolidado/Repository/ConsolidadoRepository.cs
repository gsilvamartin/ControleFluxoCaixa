using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Repository.Context;
using APIMSConsolidado.Repository.Interfaces;
using APIMSLancamentos.Repository.Context.Model;

namespace APIMSConsolidado.Repository
{
    public class ConsolidadoRepository : IConsolidadoRepository
    {
        private readonly LancamentosContext _lancamentosContext;

        public ConsolidadoRepository(LancamentosContext lancamentosContext)
        {
            this._lancamentosContext = lancamentosContext;
        }

        public List<Lancamentos> GetLancamentos(DateTime? dataLancamento)
        {
            if (dataLancamento is null)
            {
                return _lancamentosContext.Lancamentos.ToList();
            }

            return _lancamentosContext.Lancamentos
                .Where(x => x.Data.Date == DateTime.SpecifyKind(dataLancamento.Value, DateTimeKind.Utc).Date)
                .ToList();
        }
    }
}

