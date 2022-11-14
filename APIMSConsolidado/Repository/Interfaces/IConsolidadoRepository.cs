using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Model.Response;
using APIMSLancamentos.Repository.Context.Model;

namespace APIMSConsolidado.Repository.Interfaces
{
    public interface IConsolidadoRepository
    {
        public List<Lancamentos> GetLancamentos(DateTime? dataLancamento);
    }
}

