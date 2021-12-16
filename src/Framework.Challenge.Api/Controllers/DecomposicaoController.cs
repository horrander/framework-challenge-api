using System;
using Framework.Challenge.Service.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Framework.Challenge.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DecomposicaoController : ControllerBase
    {
        private readonly IDecomposicaoService _decomposicaoService;

        public DecomposicaoController(IDecomposicaoService decomposicaoService)
        {
            _decomposicaoService = decomposicaoService;
        }


        [HttpGet("{numero:int}")]
        public IActionResult DecomporNumero(int numero)
        {
            try
            {
                var decomposicao = _decomposicaoService.DecomporNumero(numero);

                return Ok(decomposicao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}