using System;
namespace OrganicNutritionRecipes.Models
{
    public class Cholesterol : Nutrient
    {
        public Double CaffeinePerMeasure { get; set; }

        public Cholesterol(String description, String measure, Double caffeinePerMeasure) : base(measure, description)
        {
            CaffeinePerMeasure = caffeinePerMeasure;
        }
    }
}
