using System;
namespace OrganicNutritionRecipes.Models
{
    public class NutritionFacts
    {
        public int Id { get; set; }

        public int CaffeineId { get; set; }
        public Caffeine Caffeine { get; set; }

        public int CholesterolId { get; set; }
        public Cholesterol Cholesterol { get; set; }

        public int CarbohydrateId { get; set; }
        public Carbohydrate Carbohydrate { get; set; }

        public int PolyUnsaturatedFatId { get; set; }
        public PolyUnsaturatedFat PolyUnsaturatedFat { get; set; }

        public int ProteinId { get; set; }
        public Protein Protein { get; set; }

        public int TotalDietaryFiberId { get; set; }
        public TotalDietaryFiber TotalDietaryFiber { get; set; }

        public int TotalSugarId { get; set; }
        public TotalSugar TotalSugar { get; set; }

        public int SaturatedFatId { get; set; }
        public SaturatedFat SaturatedFat { get; set; }

        public NutritionFacts()
        {
            
        }
    }
}
