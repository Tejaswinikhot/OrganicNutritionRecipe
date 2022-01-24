using System;
namespace OrganicNutritionRecipes.Models
{
    public class Caffeine : Nutrient
    {
        public Double CaffeinePerMeasure { get; set; }

        public Caffeine(String description, string measure, double caffeinePerMeasure) :base(measure, description)
        {
            CaffeinePerMeasure = caffeinePerMeasure;
        }
    }
}
