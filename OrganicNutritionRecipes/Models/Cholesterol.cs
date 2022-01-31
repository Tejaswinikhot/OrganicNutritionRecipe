using System;
namespace OrganicNutritionRecipes.Models
{
    public class Cholesterol : Nutrient
    {
        public Double CholesterolPerMeasure { get; set; }

        public Cholesterol(String description, String measure, Double cholesterolPerMeasure) : base(measure, description, "Cholesterol")
        {
            CholesterolPerMeasure = cholesterolPerMeasure;
        }
    }
}
