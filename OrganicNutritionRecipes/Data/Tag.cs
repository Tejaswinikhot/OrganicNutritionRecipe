using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrganicNutritionRecipes.Data
{
    public class Tag
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Display(Name = "Tag Recipes")]
        public ICollection<RecipeTag> RecipeTags { get; set; } = new List<RecipeTag>();

        [Required]
        public String Name { get; set; }

        public Tag(string name)
        {
            Name = name;
        }

        public Tag ()
        {

        }
    }
}
