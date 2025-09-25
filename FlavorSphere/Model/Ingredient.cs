using System.Text.Json.Serialization;

namespace FlavorSphere.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // public int RecipeId { get; set; }
        [JsonIgnore]
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}