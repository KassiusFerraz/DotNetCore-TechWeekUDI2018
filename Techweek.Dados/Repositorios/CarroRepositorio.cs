using System.Collections.Generic;
using System.Linq;
using Techweek.Dados.Modelos;

namespace Techweek.Dados.Repositorios
{
    public class CarroRepositorio : ICarroRepositorio
    {
        private Contexto _contexto { get ;set; }

        public CarroRepositorio(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public Carro Adicionar(Carro carro)
        {
            _contexto.Carros.Add(carro);
            _contexto.SaveChanges();
            return carro;
        }

        public Carro Editar(Carro carro)
        {
            _contexto.Carros.Update(carro);
            _contexto.SaveChanges();
            return carro;
        }

        public void Excluir(Carro carro)
        {
            _contexto.Carros.Remove(carro);
            _contexto.SaveChanges();
        }

        public Carro ObterPorId(int id)
        {
            //using System.Linq; Adicionar nos using
            return _contexto.Carros.Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public ICollection<Carro> ObterTodos()
        {
            return _contexto.Carros.ToList();
        }
    }
}