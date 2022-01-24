using System;
namespace OrganicNutritionRecipes.Data
{
    public class RecipeTag
    {
       // public Guid Id { get; set; } = Guid.NewGuid();

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public RecipeTag()
        {
        }
    }
}
