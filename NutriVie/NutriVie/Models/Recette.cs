using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriVie.Models
{
    public class Recette
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        [DisplayName("Durée (min)")]
        public int TempsPreparation { get; set; }

        [DisplayName("Cuisson (min)")]
        public int TempsCuisson { get; set; }
        public string? Image { get; set; }
        public int CategorieId { get; set; }

        [ValidateNever]
        public virtual Categorie Categorie { get; set; }
    }
}
