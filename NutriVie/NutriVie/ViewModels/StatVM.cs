using NutriVie.Models;
using NutriVie.Models.Data;

namespace NutriVie.ViewModels
{
    public class StatVM
    {
        public StatVM() { }

        public int RecettesAvec3Aliment { get; set; }
        public Aliment AlimentPlusCalorique { get; set; }
        public List<Recette> QuatreRecettesDureeTotalePlusCourte { get; set; }
        public int NbCaloriesRecetteFrancaiseMoinsCalorique { get; set; }
    }
}
