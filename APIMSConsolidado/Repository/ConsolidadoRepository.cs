using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Repository.Context;
using APIMSConsolidado.Repository.Context.Model;
using APIMSConsolidado.Repository.Interfaces;

namespace APIMSConsolidado.Repository
{
    public class ConsolidadoRepository : IConsolidadoRepository
    {
        private readonly ConsolidadosContext _ConsolidadoContext;

        public ConsolidadoRepository(ConsolidadosContext ConsolidadoContext)
        {
            this._ConsolidadoContext = ConsolidadoContext;
        }

        public Consolidados GetConsolidado(int idConsolidado)
        {
            return _ConsolidadoContext.Consolidados.Where(x => x.Id == idConsolidado).First();
        }
    }
}

