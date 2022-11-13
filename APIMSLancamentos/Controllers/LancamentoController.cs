using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMSLancamentos.Model.Request;
using APIMSLancamentos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIMSLancamentos.Controllers
{
    [Route("api/[controller]")]
    public class LancamentoController : Controller
    {
        private readonly ILancamentoService _lancamentoService;

        public LancamentoController(ILancamentoService lancamentoService)
        {
            this._lancamentoService = lancamentoService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post(LancamentoInput lancamentoInput)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}

