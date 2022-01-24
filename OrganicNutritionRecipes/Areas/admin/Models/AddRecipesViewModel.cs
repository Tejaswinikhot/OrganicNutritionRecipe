using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace OrganicNutritionRecipes.Areas.admin.Models
{
    public class AddRecipesViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public IFormFile RecipeFile { get; set; }

        //TODO add Tags
    }
}
