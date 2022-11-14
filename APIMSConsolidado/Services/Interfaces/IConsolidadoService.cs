using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Model.Response;
using APIMSConsolidado.Repository.Context.Model;

namespace APIMSConsolidado.Services.Interfaces
{
	public interface IConsolidadoService
	{
		public bool RegistrarConsolidado(ConsolidadoInput ConsolidadoInput);
		public Consolidados GetConsolidado(int idConsolidado);
	}
}

