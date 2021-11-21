using Metro.TelemetriaLinhas.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro.TelemetriaLinhas.API.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class TelemetriaLinhasController : ControllerBase
    {
     
        [HttpGet]
        [Route(template: "telemetriaLinhas/situacaolinhas")]
        public  IActionResult GetAsync(
                  [FromServices] ITelemetriaService telemetriaService)
        {
            var situacoesLinhas =  telemetriaService.ObterSituacaoLinhas();

            return Ok(situacoesLinhas);
        }

    }
}
