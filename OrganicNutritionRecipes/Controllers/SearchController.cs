using System;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Results(string searchTerm)
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
                   .Where(js =>  js.Name.ToLower() == searchTerm.ToLower())
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
