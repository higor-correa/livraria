using Livraria.Bll.Exceptions;
using Livraria.Bll.Interfaces;
using Livraria.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroBll _livroBll;

        public LivroController(ILivroBll livroBll)
        {
            _livroBll = livroBll;
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]LivroRequestDto request)
        {
            var id = _livroBll.Inserir(request);
            return CreatedAtAction(nameof(Inserir), new { id });
        }

        [HttpPut("{id:int?}")]
        public IActionResult Alterar([FromRoute]int? id, [FromBody]LivroRequestDto request)
        {
            try
            {
                _livroBll.Alterar(id.GetValueOrDefault(), request);
                return NoContent();
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_livroBll.Listar());
        }

        [HttpGet("{id:int?}")]
        public IActionResult Obter([FromRoute]int? id)
        {
            try
            {
                var response = _livroBll.Obter(id.GetValueOrDefault());
                return Ok(response);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id:int?}")]
        public IActionResult Remover([FromRoute]int? id)
        {
            try
            {
                _livroBll.Remover(id.GetValueOrDefault());
                return NoContent();
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
