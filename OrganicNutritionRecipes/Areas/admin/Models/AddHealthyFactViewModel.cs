using System;
using System.ComponentModel.DataAnnotations;

namespace OrganicNutritionRecipes.Areas.admin.Models
{
    public class AddHealthyFactViewModel
    {
        //'{"alltags":"2415f552-5017-45f6-a9be-d6731d6c1e8a","Cholesterol":"33","Carbohydrate":"33","Protein":"44","TotalSugar":"44","SaturatedFat":"44"}'

        [Required]
        public Guid alltags { get; set; }

        [Required]
        public string Cholesterol { get; set; }

        [Required]
        public string Carbohydrate { get; set; }

        [Required]
        public string Protein { get; set; }

        [Required]
        public string TotalSugar { get; set; }

        [Required]
        public string SaturatedFat { get; set; }

        public AddHealthyFactViewModel()
        {
            
        }
    }
}
