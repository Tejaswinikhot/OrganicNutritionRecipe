using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrganicNutritionRecipes.Data
{
    public class Recipe
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Display(Name = "Recipe Tags")]
        public ICollection<RecipeTag> RecipeTags { get; set; } = new List<RecipeTag>();

        [Display(Name = "Version")]
        [Required]
        public string Version { get; set; }

        [Display(Name = "Recipe Name")]
        [Required]
        public string RecipeName { get; set; }

        [Display(Name = "Recipe Text")]
        [Required]
        public string RecipeText { get; set; }

        [Display(Name = "Recipe Type")]
        [Required]
        public string RecipeType { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Created By")]
        [Required]
        public string CreatedBy { get; set; }

        [Display(Name = "Updated Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Updated By")]
        [Required]
        public string UpdatedBy { get; set; }

        
    }
}
