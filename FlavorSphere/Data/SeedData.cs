using FlavorSphere.Model;

namespace FlavorSphere.Data
{
    public static class SeedData
    {
        public static void Initialize(RecipeContext db)
        {
            var recipes = new Recipe[]
            {
                new Recipe
                {
                    Name = "Tacos al Pastor",
                    Description = "Classic Mexican tacos with marinated pork, pineapple, and cilantro.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Pork" },
                        new Ingredient { Name = "Pineapple" },
                        new Ingredient { Name = "Corn Tortillas" },
                        new Ingredient { Name = "Onion" },
                        new Ingredient { Name = "Cilantro" },
                        new Ingredient { Name = "Adobo Marinade" }
                    },
                    Instructions = "Marinate pork in adobo. Grill and slice thin. Serve on tortillas with pineapple, onion, and cilantro.",
                    PreparationTime = 20,
                    CookingTime = 15,
                    Servings = 4,
                    CuisineType = "Mexican",
                    MealType = "Lunch",
                    DietaryRestrictions = "None",
                    ImageUrl = "https://example.com/tacos_al_pastor.jpg"
                },
                new Recipe
                {
                    Name = "Arepas Rellenas",
                    Description = "Cornmeal patties stuffed with cheese, meat, or beans.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Cornmeal" },
                        new Ingredient { Name = "Cheese" },
                        new Ingredient { Name = "Water" },
                        new Ingredient { Name = "Salt" },
                        new Ingredient { Name = "Beef or Chicken" }
                    },
                    Instructions = "Mix cornmeal with water and salt. Form patties and cook on a griddle. Slice and stuff with cheese or meat.",
                    PreparationTime = 15,
                    CookingTime = 20,
                    Servings = 4,
                    CuisineType = "Venezuelan",
                    MealType = "Breakfast",
                    DietaryRestrictions = "Gluten-Free",
                    ImageUrl = "https://example.com/arepas_rellenas.jpg"
                },
                new Recipe
                {
                    Name = "Ceviche Peruano",
                    Description = "Fresh fish marinated in lime juice with onions and cilantro.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Fresh Fish" },
                        new Ingredient { Name = "Lime Juice" },
                        new Ingredient { Name = "Red Onion" },
                        new Ingredient { Name = "Cilantro" },
                        new Ingredient { Name = "Salt" },
                        new Ingredient { Name = "Chili Pepper" }
                    },
                    Instructions = "Dice fish and marinate in lime juice for 15 minutes. Add onions, cilantro, salt, and chili.",
                    PreparationTime = 15,
                    CookingTime = 0,
                    Servings = 2,
                    CuisineType = "Peruvian",
                    MealType = "Lunch",
                    DietaryRestrictions = "Pescatarian",
                    ImageUrl = "https://example.com/ceviche_peruano.jpg"
                },
                new Recipe
                {
                    Name = "Feijoada",
                    Description = "Brazilian black bean stew with pork and beef.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Black Beans" },
                        new Ingredient { Name = "Pork" },
                        new Ingredient { Name = "Beef" },
                        new Ingredient { Name = "Garlic" },
                        new Ingredient { Name = "Onion" },
                        new Ingredient { Name = "Bay Leaves" }
                    },
                    Instructions = "Cook beans with pork and beef. Add sautéed garlic, onion, and bay leaves. Simmer until tender.",
                    PreparationTime = 20,
                    CookingTime = 120,
                    Servings = 6,
                    CuisineType = "Brazilian",
                    MealType = "Dinner",
                    DietaryRestrictions = "None",
                    ImageUrl = "https://example.com/feijoada.jpg"
                },
                new Recipe
                {
                    Name = "Empanadas Argentinas",
                    Description = "Pastry filled with beef, onions, and spices.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Flour" },
                        new Ingredient { Name = "Beef" },
                        new Ingredient { Name = "Onion" },
                        new Ingredient { Name = "Egg" },
                        new Ingredient { Name = "Olive Oil" },
                        new Ingredient { Name = "Spices" }
                    },
                    Instructions = "Prepare dough. Cook beef with onions and spices. Fill dough, seal, and bake until golden.",
                    PreparationTime = 30,
                    CookingTime = 25,
                    Servings = 8,
                    CuisineType = "Argentinian",
                    MealType = "Snack",
                    DietaryRestrictions = "None",
                    ImageUrl = "https://example.com/empanadas_argentinas.jpg"
                },
                new Recipe
                {
                    Name = "Pupusas",
                    Description = "Salvadoran stuffed corn tortillas with cheese and beans.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Cornmeal" },
                        new Ingredient { Name = "Cheese" },
                        new Ingredient { Name = "Refried Beans" },
                        new Ingredient { Name = "Water" },
                        new Ingredient { Name = "Salt" }
                    },
                    Instructions = "Mix cornmeal and water. Form patties, fill with cheese and beans. Cook on griddle until golden.",
                    PreparationTime = 15,
                    CookingTime = 20,
                    Servings = 4,
                    CuisineType = "Salvadoran",
                    MealType = "Breakfast",
                    DietaryRestrictions = "Vegetarian",
                    ImageUrl = "https://example.com/pupusas.jpg"
                },
                new Recipe
                {
                    Name = "Arroz con Pollo",
                    Description = "Chicken and rice dish cooked with vegetables and saffron.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Rice" },
                        new Ingredient { Name = "Chicken" },
                        new Ingredient { Name = "Bell Pepper" },
                        new Ingredient { Name = "Onion" },
                        new Ingredient { Name = "Garlic" },
                        new Ingredient { Name = "Saffron" }
                    },
                    Instructions = "Cook chicken. Add vegetables, rice, and saffron. Simmer until rice is done.",
                    PreparationTime = 15,
                    CookingTime = 45,
                    Servings = 4,
                    CuisineType = "Latin American",
                    MealType = "Dinner",
                    DietaryRestrictions = "None",
                    ImageUrl = "https://example.com/arroz_con_pollo.jpg"
                },
                new Recipe
                {
                    Name = "Tamales",
                    Description = "Corn dough filled with meat and wrapped in corn husks, then steamed.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Corn Masa" },
                        new Ingredient { Name = "Pork or Chicken" },
                        new Ingredient { Name = "Corn Husks" },
                        new Ingredient { Name = "Spices" },
                        new Ingredient { Name = "Broth" }
                    },
                    Instructions = "Prepare masa and filling. Wrap in husks and steam until cooked.",
                    PreparationTime = 60,
                    CookingTime = 60,
                    Servings = 6,
                    CuisineType = "Mexican",
                    MealType = "Dinner",
                    DietaryRestrictions = "None",
                    ImageUrl = "https://example.com/tamales.jpg"
                },
                new Recipe
                {
                    Name = "Cachapas",
                    Description = "Venezuelan sweet corn pancakes usually served with cheese.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Corn" },
                        new Ingredient { Name = "Sugar" },
                        new Ingredient { Name = "Milk" },
                        new Ingredient { Name = "Cheese" },
                        new Ingredient { Name = "Salt" }
                    },
                    Instructions = "Mix corn, sugar, and milk. Cook on griddle. Serve with cheese.",
                    PreparationTime = 10,
                    CookingTime = 10,
                    Servings = 4,
                    CuisineType = "Venezuelan",
                    MealType = "Breakfast",
                    DietaryRestrictions = "Vegetarian",
                    ImageUrl = "https://example.com/cachapas.jpg"
                },
                new Recipe
                {
                    Name = "Moqueca",
                    Description = "Brazilian seafood stew with coconut milk and palm oil.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Fish" },
                        new Ingredient { Name = "Shrimp" },
                        new Ingredient { Name = "Coconut Milk" },
                        new Ingredient { Name = "Dendê Oil" },
                        new Ingredient { Name = "Onion" },
                        new Ingredient { Name = "Tomatoes" },
                        new Ingredient { Name = "Cilantro" }
                    },
                    Instructions = "Cook fish and shrimp in coconut milk and dendê oil with vegetables and cilantro.",
                    PreparationTime = 20,
                    CookingTime = 40,
                    Servings = 4,
                    CuisineType = "Brazilian",
                    MealType = "Dinner",
                    DietaryRestrictions = "Pescatarian",
                    ImageUrl = "https://example.com/moqueca.jpg"
                },
                new Recipe
                {
                    Name = "Chiles Rellenos",
                    Description = "Poblano peppers stuffed with cheese or meat, battered and fried.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Poblano Peppers" },
                        new Ingredient { Name = "Cheese or Beef" },
                        new Ingredient { Name = "Eggs" },
                        new Ingredient { Name = "Flour" },
                        new Ingredient { Name = "Oil" }
                    },
                    Instructions = "Stuff peppers with filling. Dip in egg batter and fry until golden.",
                    PreparationTime = 20,
                    CookingTime = 15,
                    Servings = 4,
                    CuisineType = "Mexican",
                    MealType = "Dinner",
                    DietaryRestrictions = "Vegetarian option",
                    ImageUrl = "https://example.com/chiles_rellenos.jpg"
                },
                new Recipe
                {
                    Name = "Sancocho",
                    Description = "Traditional Latin American stew with meat, plantains, and root vegetables.",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Beef or Chicken" },
                        new Ingredient { Name = "Plantains" },
                        new Ingredient { Name = "Yuca" },
                        new Ingredient { Name = "Corn" },
                        new Ingredient { Name = "Cilantro" }
                    },
                    Instructions = "Cook meat and vegetables in broth until tender. Season with cilantro.",
                    PreparationTime = 20,
                    CookingTime = 90,
                    Servings = 6,
                    CuisineType = "Latin American",
                    MealType = "Dinner",
                    DietaryRestrictions = "None",
                    ImageUrl = "https://example.com/sancocho.jpg"
                }
                        };

            db.Recipes.AddRange(recipes);
            db.SaveChanges();
        }
    }
}
