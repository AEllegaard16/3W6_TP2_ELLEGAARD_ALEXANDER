using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using NutriVie.Models.Data;

namespace NutriVie.Models
{
    public class Aliment
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }

        public double CaloriesPour100g { get; set; }

        [ValidateNever]
        public virtual List<AlimentRecette> AlimentRecettes { get; set; }
    }
}
