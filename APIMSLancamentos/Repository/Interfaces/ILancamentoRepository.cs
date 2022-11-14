using System;
using APIMSLancamentos.Model.Request;
using APIMSLancamentos.Model.Response;
using APIMSLancamentos.Repository.Context.Model;

namespace APIMSLancamentos.Repository.Interfaces
{
	public interface ILancamentoRepository
	{
        public bool RegistrarLancamento(LancamentoInput lancamentoInput);
        public Lancamentos GetLancamento(int idLancamento);
    }
}

