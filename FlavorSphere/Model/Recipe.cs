namespace FlavorSphere.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        // Lista de ingredientes
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public string? Instructions { get; set; }
        public int PreparationTime { get; set; } // in minutes
        public int CookingTime { get; set; }     // in minutes
        public int Servings { get; set; }
        public string? CuisineType { get; set; }
        public string? MealType { get; set; }      // e.g., Breakfast, Lunch, Dinner
        public string? DietaryRestrictions { get; set; } // e.g., Vegan, Gluten-Free
        public string? ImageUrl { get; set; }

        //foreign key to Ingredient

    }
}