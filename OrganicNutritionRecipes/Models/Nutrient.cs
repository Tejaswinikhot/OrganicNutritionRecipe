namespace OrganicNutritionRecipes.Models
{
    public class Nutrient
    {
        public int Id { get; set; }

        public string Measure { get; set; }
        public string Description { get; set; }

        public string NutrientType { get; set; }

        public NutritionFacts NutritionFacts { get; set; }

        public Nutrient(string measure, string description, string nutrientType)
        {
            Measure = measure;
            Description = description;
            NutrientType = nutrientType;
        }
    }
}