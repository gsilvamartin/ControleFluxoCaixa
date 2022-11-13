using System;
using APIMSLancamentos.Model.Response;
using APIMSLancamentos.Repository.Interfaces;
using APIMSLancamentos.Services.Interfaces;

namespace APIMSLancamentos.Services
{
	public class LancamentoService: ILancamentoService
	{
        private readonly ILancamentoRepository _lancamentoRepository;

		public LancamentoService(ILancamentoRepository lancamentoRepository)
		{
            this._lancamentoRepository = lancamentoRepository;
		}

        public LancamentoResponse GetLancamento(int idLancamento)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarLancamento()
        {
            throw new NotImplementedException();
        }
    }
}

