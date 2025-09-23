using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlavorSphere.Data;
using FlavorSphere.Model;

namespace FlavorSphere.Controllers;

[Route("recipes")]
[ApiController]
public class RecipesController : ControllerBase
{
    private readonly RecipeContext _db;

    public RecipesController(RecipeContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Recipe>>> GetRecipes()
    {
        return (await _db.Recipes.Include(r => r.Ingredients).ToListAsync());
    }

    // [HttpPost]
    // public async Task<ActionResult<Recipe>> AddRecipe(Recipe recipe)
    // {
    //     _db.Recipes.Add(recipe);
    //     await _db.SaveChangesAsync();
    //     return recipe;
    // }
}
