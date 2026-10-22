using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models.Data
{
    public class AlimentRecette
    {
        public int RecetteId { get; set; }
        public virtual Recette Recette { get; set; }

        public int AlimentId { get; set; }
        public virtual Aliment Aliment { get; set; }

        [Range(0.1, 10000)]
        public double Poids { get; set; }
    }
}
