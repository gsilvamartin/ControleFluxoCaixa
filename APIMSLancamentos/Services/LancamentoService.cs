using System;
using APIMSLancamentos.Model.Request;
using APIMSLancamentos.Model.Response;
using APIMSLancamentos.Repository.Context.Model;
using APIMSLancamentos.Repository.Interfaces;
using APIMSLancamentos.Services.Interfaces;

namespace APIMSLancamentos.Services
{
    public class LancamentoService : ILancamentoService
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public LancamentoService(ILancamentoRepository lancamentoRepository)
        {
            this._lancamentoRepository = lancamentoRepository;
        }

        public Lancamentos GetLancamento(int idLancamento)
        {
            return _lancamentoRepository.GetLancamento(idLancamento);
        }

        public bool RegistrarLancamento(LancamentoInput lancamentoInput)
        {
            return _lancamentoRepository.RegistrarLancamento(lancamentoInput);
        }
    }
}

