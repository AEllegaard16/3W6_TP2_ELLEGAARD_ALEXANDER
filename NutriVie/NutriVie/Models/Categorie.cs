using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }

        [ValidateNever]
        public virtual IList<Recette> Recettes { get; set; }
    }
}
