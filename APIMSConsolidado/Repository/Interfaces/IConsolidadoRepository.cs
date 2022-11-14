using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Model.Response;
using APIMSConsolidado.Repository.Context.Model;

namespace APIMSConsolidado.Repository.Interfaces
{
	public interface IConsolidadoRepository
	{
        public bool RegistrarConsolidado(ConsolidadoInput ConsolidadoInput);
        public Consolidados GetConsolidado(int idConsolidado);
    }
}

