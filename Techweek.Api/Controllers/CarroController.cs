using Microsoft.AspNetCore.Mvc;
using Techweek.Dados.Modelos;
using Techweek.Regras;

namespace Techweek.Api
{
    [Route("api/Carro")]
    public class CarroController : Controller
    {
        public ICarroRegras CarroRegras { get; set; }

        public CarroController(ICarroRegras carroRegras)
        {
            this.CarroRegras = carroRegras;
        }

        
        [HttpPost]
        public IActionResult 
            Post([FromBody] CarroModeloVisao carroModeloVisao)
            {
                try
                {
                    var carro = CarroRegras.Inserir(carroModeloVisao);
                    return Created("api/Carro/" + carro.Id, carro);
                }
                catch (System.Exception)
                {
                    
                    throw;
                }        
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                try
                {
                    var carro = CarroRegras.ObterPorId(id);
                    return Json(carro);
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                try
                {
                    var carro = CarroRegras.ObterPorId(id);
                    if (carro == null)
                    {
                        return NotFound();
                    }
                    CarroRegras.Deletar(carro);
                    return NoContent();
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    var carros = CarroRegras.ObterTodos();
                    return Json(carros);
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }

            [HttpPut("{id}")]
            public ActionResult Put(int id,[FromBody] CarroModeloVisao carroModeloVisao)
            {
                try
                {
                    var carro = CarroRegras.ObterPorId(id);
                    if (carro == null)
                    {
                        return NotFound();
                    }
                    CarroRegras.Editar(carro, carroModeloVisao);
                    return NoContent();
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }

            [HttpPost("AndarParaFrente")]
            public IActionResult AndarParaFrente()
            {
                return Accepted();
            }
    }
}