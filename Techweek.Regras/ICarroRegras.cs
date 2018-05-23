using System.Collections.Generic;
using Techweek.Dados.Modelos;

namespace Techweek.Regras
{
    public interface ICarroRegras
    {
        Carro Inserir(CarroModeloVisao carroModeloVisao);
        Carro ObterPorId(int id);
        Carro Editar(Carro carro, CarroModeloVisao carroModeloVisao);
        void Deletar(Carro carro);
        ICollection<Carro> ObterTodos();
    }
}