using System;
namespace OrganicNutritionRecipes.Models
{
    public class PolyUnsaturatedFat : Nutrient
    {
        public Double CaffeinePerMeasure { get; set; }

        public string FattyAcids { get; set; }

        public PolyUnsaturatedFat(String description, string measure, String fattyAcids, double polyunsaturatedPerMeasure) : base(measure, description)
        {
            FattyAcids = fattyAcids;
            CaffeinePerMeasure = polyunsaturatedPerMeasure;
        }
    }
}
