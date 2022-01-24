using System;
namespace OrganicNutritionRecipes.Models
{
    public class ProduceNutrients
    {
        public int ProduceId { get; set; }
        public Produce produce { get; set; }

        public int NutrientId { get; set; }
        public Nutrient Nutrient { get; set; }

        public ProduceNutrients()
        {
        }
    }
}
