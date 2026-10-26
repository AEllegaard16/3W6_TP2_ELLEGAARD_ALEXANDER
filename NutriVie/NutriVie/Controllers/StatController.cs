using Microsoft.AspNetCore.Mvc;
using NutriVie.Models.Data;
using NutriVie.ViewModels;

namespace NutriVie.Controllers
{
    public class StatController : Controller
    {
        private readonly NutriVieDbContext _context;

        public StatController(NutriVieDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(
                new StatVM()
                {
                    RecettesAvec3Aliment = _context.Recette.Count(r => r.AlimentRecettes.Count() == 3),
                    AlimentPlusCalorique = _context.Aliment.OrderByDescending(a => a.CaloriesPour100g).First(),
                    QuatreRecettesDureeTotalePlusCourte = _context.Recette.OrderBy(r => r.TempsCuisson + r.TempsPreparation).Take(4).ToList(),
                    NbCaloriesRecetteFrancaiseMoinsCalorique = _context.Recette.Where(r => r.CategorieId == 1).Min(r => r.AlimentRecettes.Sum(ra => ra.Aliment.CaloriesPour100g * ra.Poids))
                }
            );
        }
    }
}
