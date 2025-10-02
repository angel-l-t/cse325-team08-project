using FlavorSphere.Model;
using Microsoft.EntityFrameworkCore;

namespace FlavorSphere.Data
{
    public class RecipeService
    {
        private readonly RecipeContext _context;

        public RecipeService(RecipeContext context)
        {
            _context = context;
        }

        // Obtain all recipes
        public async Task<List<Recipe>> GetAllRecipesAsync()
        {
            return await _context.Recipes.ToListAsync();
        }

        // Obtain a recipe by its ID
        // This method includes related ingredients
        public async Task<Recipe?> GetRecipeByIdAsync(int id)
        {
            return await _context.Recipes
                .Include(r => r.Ingredients)
                .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}