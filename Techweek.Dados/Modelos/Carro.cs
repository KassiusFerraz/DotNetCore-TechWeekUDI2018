using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techweek.Dados.Modelos
{
    public class Carro
    {
        [Key]
        [DatabaseGenerated
        (DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Cor { get; set; }
        public double Motor { get; set; }
        public double Consumo { get; set; }
        public string Classificacao { get ; set; }
    }
}