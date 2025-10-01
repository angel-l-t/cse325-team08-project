using Microsoft.EntityFrameworkCore;
using FlavorSphere.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FlavorSphere.Data
{
    public class RecipeContext : IdentityDbContext
    {
        public RecipeContext(DbContextOptions options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        // Configuración de relaciones entre Recipe e Ingredient
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This line is to run the Identity configurations first (authentication and authorization)
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Ingredients)
                .WithMany(i => i.Recipes)
                .UsingEntity(j => j.ToTable("RecipeIngredients"));
        }
    }
}
