using System;
using APIMSConsolidado.Model.Request;
using APIMSConsolidado.Model.Response;
using APIMSConsolidado.Repository.Interfaces;
using APIMSConsolidado.Services.Interfaces;

namespace APIMSConsolidado.Services
{
    public class ConsolidadoService : IConsolidadoService
    {
        private readonly IConsolidadoRepository _consolidadoRepository;

        public ConsolidadoService(IConsolidadoRepository consolidadoRepository)
        {
            this._consolidadoRepository = consolidadoRepository;
        }

        public RelatorioConsolidado GetRelatorioConsolidado(DateTime? dataLancamento)
        {
            var lancamentos = _consolidadoRepository.GetLancamentos(dataLancamento);

            return new RelatorioConsolidado
            {
                ConsolidadoDia = lancamentos.GroupBy(x => x.Data).Select(group => new DetalheConsolidadoDia
                {
                    Data = group.Key,
                    Valor = group.Sum(x => x.Valor)
                }).ToList(),
                SaldoAtual = lancamentos.Sum(x => x.Valor)
            };
        }
    }
}

