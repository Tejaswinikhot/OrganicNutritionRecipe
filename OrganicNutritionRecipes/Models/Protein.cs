using System;
namespace OrganicNutritionRecipes.Models
{
    public class Protein : Nutrient
    {

        public double ProteinGPerMeasure { get; set; }

        public Protein(string measure, string description, double Protiengrampermeasure) : base(measure, description, "Protein")
        {
            ProteinGPerMeasure = Protiengrampermeasure;
        }

        public Protein(string description, string measure) : base(measure, description, "Protein")
        {

        }
    }
}
