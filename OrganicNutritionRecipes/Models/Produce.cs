using System;
using System.Collections.Generic;

namespace OrganicNutritionRecipes.Models
{
    public class Produce
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public List<ProduceNutrients> ProduceNutrients { get; set; }

        public Produce(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
