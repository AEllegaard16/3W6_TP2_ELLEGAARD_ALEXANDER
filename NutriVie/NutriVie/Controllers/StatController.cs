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

            new StatVM()
            {
                RecettesAvec3Aliment = _context.Recette.Count(r => r.AlimentRecettes.Count() == 3)
            };

            return View();
        }
    }
}
