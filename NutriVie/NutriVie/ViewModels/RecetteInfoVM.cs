namespace NutriVie.ViewModels
{
    public class RecetteInfoVM
    {
        public RecetteInfoVM() { }

        public string NomRecette { get; set; }
        public int NbIngredients { get; set; }
        public int TempsTotal { get; set; }
        public string Statut { get; set; }
    }
}
