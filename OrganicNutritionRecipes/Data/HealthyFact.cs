using System;
namespace OrganicNutritionRecipes.Data
{
    public class HealthyFact
    {
        public int Id { get; set; }

        public string Cholesterol { get; set; }
       

        public string Carbohydrate { get; set; }
      

        public string Protein { get; set; }


        public string TotalSugar { get; set; }
        

        public string SaturatedFat { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }

        public HealthyFact()
        {
            
        }
    }
}
