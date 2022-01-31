using System;
namespace OrganicNutritionRecipes.Models
{
    public class SaturatedFat : Nutrient
    {
        public Double SaturatedFatPerMeasure { get; set; }

        public SaturatedFat(String description, String measure, Double saturatedFatPerMeasure) : base(measure, description, "SaturatedFat")
        {
            SaturatedFatPerMeasure = saturatedFatPerMeasure;
        }
    }
}
