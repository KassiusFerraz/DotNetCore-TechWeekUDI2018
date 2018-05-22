using Techweek.Dados.Modelos;
using Techweek.Dados.Repositorios;

namespace Techweek.Regras
{
    public class CarroRegras : ICarroRegras
    {

        public ICarroRepositorio 
                CarroRepositorio { get; set; }

        public CarroRegras
            (ICarroRepositorio carroRepositorio)
        {
            this.CarroRepositorio = carroRepositorio;
        }
                
        public Carro 
        Inserir(CarroModeloVisao carroModeloVisao)
        {
            var carro = new Carro();
            carro.Motor = carroModeloVisao.Motor;
            carro.Cor = carroModeloVisao.Cor;
            carro.Consumo = carroModeloVisao.Consumo;

            if (carro.Consumo > 10)
            {
                carro.Classificacao = "Economico";
            } else if(carro.Consumo > 5)
            {
                carro.Classificacao = "Mediano";
            } else {
                carro.Classificacao = "Alto consumo";
            }

            carro = CarroRepositorio.Adicionar(carro);
            return carro;
        }

        public Carro ObterPorId(int id)
        {
            return CarroRepositorio.ObterPorId(id);
        }
    }
}