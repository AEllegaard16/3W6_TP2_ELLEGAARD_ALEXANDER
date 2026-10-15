using Microsoft.EntityFrameworkCore;

namespace NutriVie.Models.Data
{
    public class NutriVieDbContext : DbContext
    {
        public NutriVieDbContext(DbContextOptions<NutriVieDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Service>().HasData(
                new Service { Id = 1, Nom = "Recettes Saines", Description = "Des recettes équilibrées et faciles à préparer pour toute la famille." },
                new Service { Id = 2, Nom = "Plans Nutritionnels", Description = "Des plans alimentaires personnalisés par nos nutritionnistes." },
                new Service { Id = 3, Nom = "Conseils d'Experts", Description = "Des articles et guides sur la nutrition et le bien-être." }
                );
        }

        public DbSet<Service> Service { get; set; }
    }
}
