using System;
namespace OrganicNutritionRecipes.Models
{
    public class PolyUnsaturatedFat : Nutrient
    {

        public string PolyUnsaturatedFatPerMeasure { get; set; }

        public PolyUnsaturatedFat(string description, string measure, string PolyunsaturatedPerMeasure) : base(measure, description, "PolyUnsaturatedFatPerMeasure")
        {
            PolyUnsaturatedFatPerMeasure = PolyunsaturatedPerMeasure;
        }

        public PolyUnsaturatedFat(string description, string measure) : base(measure, description, "PolyUnsaturatedFatPerMeasure")
        {

        }
    }
}
