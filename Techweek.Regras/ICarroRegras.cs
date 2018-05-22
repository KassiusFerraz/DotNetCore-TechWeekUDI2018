using Techweek.Dados.Modelos;

namespace Techweek.Regras
{
    public interface ICarroRegras
    {
        Carro Inserir(CarroModeloVisao carroModeloVisao);
        Carro ObterPorId(int id);
    }
}