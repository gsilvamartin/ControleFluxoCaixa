using System;
using APIMSLancamentos.Model.Request;
using APIMSLancamentos.Model.Response;
using APIMSLancamentos.Repository.Context.Model;

namespace APIMSLancamentos.Services.Interfaces
{
	public interface ILancamentoService
	{
		public bool RegistrarLancamento(LancamentoInput lancamentoInput);
		public Lancamentos GetLancamento(int idLancamento);
	}
}

