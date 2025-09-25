using Microsoft.EntityFrameworkCore;
using FlavorSphere.Model;

namespace FlavorSphere.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        // Configuración de relaciones entre Recipe e Ingredient
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Ingredients)
                .WithMany(i => i.Recipes)
                .UsingEntity(j => j.ToTable("RecipeIngredients"));
        }
    }
}
