using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Model.Response;
using APIMSConsolidado.Repository.Context.Model;
using APIMSConsolidado.Repository.Interfaces;
using APIMSConsolidado.Services.Interfaces;

namespace APIMSConsolidado.Services
{
    public class ConsolidadoService : IConsolidadoService
    {
        private readonly IConsolidadoRepository _ConsolidadoRepository;

        public ConsolidadoService(IConsolidadoRepository ConsolidadoRepository)
        {
            this._ConsolidadoRepository = ConsolidadoRepository;
        }

        public Consolidados GetConsolidado(int idConsolidado)
        {
            return _ConsolidadoRepository.GetConsolidado(idConsolidado);
        }

        public bool RegistrarConsolidado(ConsolidadoInput ConsolidadoInput)
        {
            return _ConsolidadoRepository.RegistrarConsolidado(ConsolidadoInput);
        }
    }
}

