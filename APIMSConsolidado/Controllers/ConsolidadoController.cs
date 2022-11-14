using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMSConsolidado.Model.Response;
using APIMSConsolidado.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIMSConsolidado.Controllers
{
    [Route("api/[controller]")]
    public class ConsolidadoController : Controller
    {
        private readonly IConsolidadoService _consolidadoService;

        public ConsolidadoController(IConsolidadoService consolidadoService)
        {
            this._consolidadoService = consolidadoService;
        }

        [HttpGet]
        public IActionResult Get(DateTime? data)
        {
            try
            {
                return Ok(new APIResponse
                {
                    Data = _consolidadoService.GetRelatorioConsolidado(data),
                    Message = "Relatório gerado com sucesso",
                    Success = true
                });
            }
            catch (Exception ex)
            {
                return Ok(new APIResponse
                {
                    Message = ex.Message,
                    Success = false
                });
            }
        }
    }
}

