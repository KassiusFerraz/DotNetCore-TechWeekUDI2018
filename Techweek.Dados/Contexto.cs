using Microsoft.EntityFrameworkCore;
using Techweek.Dados.Modelos;

namespace Techweek.Dados
{
    public class Contexto : DbContext
    {
        public DbSet<Carro> Carros { get; set; }

        public Contexto(DbContextOptions options)
         : base(options) {}
    }
}