using Metro.Atendimento.Portal.Services.Interface;
using Metro.Atendimento.Portal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Metro.Atendimento.Portal.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class AtendimentosController : ControllerBase
    {


        [HttpGet]
        [Route(template: "atendimentos")]
        public async Task<IActionResult> GetAsync(
            [FromServices] IAtendimentoService atendimentoService)
        {
            var atendimentos =  await atendimentoService.ListarTodos();

            return Ok(atendimentos);
        }

        [HttpGet]
        [Route(template: "atendimentos/{id}")]
        public async Task<IActionResult> GetByIdAsync(
          [FromServices] IAtendimentoService atendimentoService,
         [FromRoute] int id)
        {
            var atendimento = await atendimentoService.ObterPorId(id);

            return (atendimento == null)
                ? NotFound()
                : Ok(atendimento);
        }

        [HttpPost]
        [Route(template: "atendimentos")]
        public async Task<IActionResult> PostAsync(
         [FromServices] IAtendimentoService atendimentoService,
         [FromBody] CreateAtendimentoViewModel model)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var atendimento = new Models.Atendimento()
                {
                    Assunto = model.Assunto,
                    Mensagem = model.Mensagem
                };

                atendimento = await atendimentoService.Salvar(atendimento);

                return Created($"atendimentos/{atendimento.Id}", atendimento);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
