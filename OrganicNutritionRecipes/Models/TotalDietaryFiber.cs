using System;
namespace OrganicNutritionRecipes.Models
{
    public class TotalDietaryFiber : Nutrient
    {

        public Double TotalDietaryGPer100G { get; set; }

        public TotalDietaryFiber(string measure, string description, double totalDietaryGPer100G) : base(measure, description)
        {
            TotalDietaryGPer100G = totalDietaryGPer100G;
        }

    }
}
