using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganicNutritionRecipes.Data;
using OrganicNutritionRecipes.Models;

namespace OrganicNutritionRecipes.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext context;

        public SearchController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult searchbyrecipe(string searchType, string searchTerm, List<string> SelectedRecipeTypes)
        {
            List<Recipe> recipes;
            if (!string.IsNullOrEmpty(searchType) && searchType.Equals("Recipe Type") )
            {
                recipes = new List<Recipe>();
                if (SelectedRecipeTypes != null && SelectedRecipeTypes.Any())
                {
                    foreach (var recType in SelectedRecipeTypes)
                    {
                        recipes.AddRange( context.Recipes.Where(u => u.RecipeType == recType)
                       .Include(j => j.RecipeTags)
                       .ThenInclude(u => u.Tag)
                       .ToList());
                    }
                }
                ViewBag.seachedRecipes = recipes;
            }
            else if (!string.IsNullOrEmpty(searchType) && searchType.Equals("Ingredient"))
            {
            }

            return View("Index");
        }

        [HttpPost("search/viewNutritionFact/")]
        public IActionResult ViewNutritionFact([FromBody] string TagName)
        {
            if (TagName == null)
                return NotFound();

            return Json(new { success = true, calories = "24g"});
        }

        public IActionResult SearchProduce(string searchType, string searchTerm)
        {
            List<Produce> produces;
            List<ProduceViewModel> displayProduce = new List<ProduceViewModel>();

            if (string.IsNullOrEmpty(searchTerm))
            {
                produces = context.Produces
                   .Include(j => j.ProduceNutrients)
                   .ToList();

                foreach (var produce in produces)
                {
                    List<ProduceNutrients> produceNutrients = context.ProduceNutrients
                        .Where(js => js.ProduceId == produce.Id)
                        .Include(js => js.Nutrient)
                        .ToList();

                    ProduceViewModel newDisplayJob = new ProduceViewModel(produce, produceNutrients);
                    displayProduce.Add(newDisplayJob);
                }
            }
            else
            {
                produces = context.Produces
                   .Where(js => js.Name.ToLower() == searchTerm.ToLower())
                   .Include(j => j.ProduceNutrients)
                   .ToList();

                foreach (var produce in produces)
                {
                    List<ProduceNutrients> produceNutrients = context.ProduceNutrients
                        .Where(js => js.ProduceId == produce.Id && js.produce.Name.ToLower() == searchTerm.ToLower())
                        .Include(js => js.Nutrient)
                        .ToList();

                    ProduceViewModel newDisplayJob = new ProduceViewModel(produce, produceNutrients);
                    displayProduce.Add(newDisplayJob);
                }
            }

            ViewBag.title = "Search Recipes with Organic Products";
            ViewBag.produces = displayProduce;

            return View("Index");
        }
    }

}
