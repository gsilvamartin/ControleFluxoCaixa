using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMSLancamentos.Model.Request;
using APIMSLancamentos.Model.Response;
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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(new APIResponse
                {
                    Data = _lancamentoService.GetLancamento(id),
                    Message = "Lancamento recuperado com sucesso",
                    Success = true
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse
                {
                    Message = ex.Message,
                    Success = false
                });
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] LancamentoInput lancamentoInput)
        {
            try
            {
                return Ok(new APIResponse
                {
                    Data = _lancamentoService.RegistrarLancamento(lancamentoInput),
                    Success = true,
                    Message = "Lançamento cadastrado com sucesso"
                });
            }
            catch(Exception ex)
            {
                return BadRequest(new APIResponse
                {
                    Message = ex.Message,
                    Success = false
                });
            }
        }
    }
}

