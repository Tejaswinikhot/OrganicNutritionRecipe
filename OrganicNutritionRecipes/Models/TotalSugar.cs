using System;
namespace OrganicNutritionRecipes.Models
{
    public class TotalSugar : Nutrient
    {

        public Double SugarGPerMeasure { get; set; }

        public TotalSugar(string measure, string description, double sugargrampermeasure) : base(measure, description)
        {
            SugarGPerMeasure = sugargrampermeasure;
        }

    }
}
