using System;
namespace OrganicNutritionRecipes.Models
{
    public class Protein : Nutrient
    {

        public Double ProteinGPerMeasure { get; set; }

        public Protein(string measure, string description, double protiengrampermeasure) : base(measure, description)
        {
            ProteinGPerMeasure = protiengrampermeasure;
        }

    }
}
