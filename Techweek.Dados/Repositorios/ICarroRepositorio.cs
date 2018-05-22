using System.Collections.Generic;
using Techweek.Dados.Modelos;

namespace Techweek.Dados.Repositorios
{
    public interface ICarroRepositorio
    {
        Carro Adicionar(Carro carro);
        Carro Editar(Carro carro);
        void Excluir(Carro carro);
        Carro ObterPorId(int id);
        ICollection<Carro> ObterTodos();
    }
}