using System.ComponentModel.DataAnnotations;

namespace CalculoIMC.Models
{
    public class IMC
    {
        [Required]
        public double Peso { get; set; }

        [Required]
        public double Altura { get; set; }

        public double Resultado { get; set; }
    }
}