using System;
namespace OrganicNutritionRecipes.Models
{
    public class Carbohydrate : Nutrient
    {
        public Double CarbohydrateGPerMeasure { get; set; }

        public Carbohydrate(String description, String measure, Double carbohydrateGPerMeasure) : base(measure, description)
        {
            CarbohydrateGPerMeasure = carbohydrateGPerMeasure;
        }
    }
}
