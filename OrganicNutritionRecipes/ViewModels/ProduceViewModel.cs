using System.Collections.Generic;
using OrganicNutritionRecipes.Models;

namespace OrganicNutritionRecipes.Controllers
{
    public class ProduceViewModel
    {
        public Produce produce;
        public List<ProduceNutrients> produceNutrients;

        public ProduceViewModel(Produce produce, List<ProduceNutrients> produceNutrients)
        {
            this.produce = produce;
            this.produceNutrients = produceNutrients;
        }
    }
}