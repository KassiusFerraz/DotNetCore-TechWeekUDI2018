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

    }
}