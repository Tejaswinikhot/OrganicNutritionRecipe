namespace OrganicNutritionRecipes.Models
{
    public class Nutrient
    {
        public int Id { get; set; }

        public string Measure { get; set; }
        public string Description { get; set; }


        public Nutrient(string measure, string description)
        {
            Measure = measure;
            Description = description;
        }
    }
}