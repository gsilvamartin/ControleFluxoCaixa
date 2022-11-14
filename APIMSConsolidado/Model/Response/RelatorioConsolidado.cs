using System;
namespace APIMSConsolidado.Model.Response
{
    public class RelatorioConsolidado
    {
        public List<DetalheConsolidadoDia> ConsolidadoDia { get; set; }
        public double SaldoAtual { get; set; }
    }
}

