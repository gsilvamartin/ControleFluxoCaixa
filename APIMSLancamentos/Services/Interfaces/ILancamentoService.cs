using System;
using APIMSLancamentos.Model.Response;

namespace APIMSLancamentos.Services.Interfaces
{
	public interface ILancamentoService
	{
		public bool RegistrarLancamento();
		public LancamentoResponse GetLancamento(int idLancamento);
	}
}

