using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Model.Response;

namespace APIMSConsolidado.Services.Interfaces
{
	public interface IConsolidadoService
	{
        public RelatorioConsolidado GetRelatorioConsolidado(DateTime? dataLancamento);
    }
}

