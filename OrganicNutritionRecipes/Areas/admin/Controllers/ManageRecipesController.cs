using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganicNutritionRecipes.Areas.admin.Models;
using OrganicNutritionRecipes.Data;

namespace OrganicNutritionRecipes.Areas.admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("admin")]
    public class ManageRecipesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ManageRecipesController(ApplicationDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        [HttpGet]
        [Route("admin/recipes")]
        public async Task<IActionResult> Index()
        {
            //return View(await dbContext.Recipes.ToListAsync());
            return View(await dbContext.Recipes.OrderBy(d => d.CreatedDate ).ToListAsync());
        }

        [HttpGet]
        [Route("admin/recipes/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("admin/recipes/add")]
        public async Task<IActionResult> Add(AddRecipesViewModel addRecipesViewModel)
        {
            if (ModelState.IsValid)
            {

                if (dbContext.Recipes.Any(d => d.RecipeName == addRecipesViewModel.Name))
                {
                    ModelState.AddModelError("Name", "A recipe already exists by that name, please choose a new name and try again.");
                }
                else
                {
                    var textStream = new MemoryStream();
                    await addRecipesViewModel.RecipeFile.CopyToAsync(textStream);


                    var recipe = new Recipe();
                    recipe.Id = Guid.NewGuid();
                    recipe.RecipeName = addRecipesViewModel.Name;
                    recipe.RecipeType = addRecipesViewModel.RecipeType;
                    recipe.RecipeText = Encoding.Default.GetString(textStream.ToArray());
                    recipe.CreatedBy = recipe.UpdatedBy = User.Identity.Name;
                    recipe.CreatedDate = recipe.UpdatedDate = DateTime.Now;
                    recipe.Version = Convert.ToBase64String(textStream.ToArray());

                    dbContext.Add(recipe);
                    await dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                    //return RedirectToAction(nameof(Update), new { id = recipe.Id });
                }
            }
            return View(addRecipesViewModel);
        }

        [Route("admin/recipes/{id}")]
        public async Task<IActionResult> Update(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reciep = await dbContext.Recipes.Include(d => d.RecipeTags).ThenInclude(e => e.Tag)
                // .ThenInclude(u => u.Recipe)
                .FirstOrDefaultAsync(d => d.Id == id);


            if (reciep == null)
            {
                return NotFound();
            }

            var tags = (await dbContext.Tags.Select(u => new { Value = u.Id.ToString("D"), Name = u.Name }).ToListAsync()).
                Select(u => new SelectListItem(u.Name, u.Value));

            ViewBag.AllTags = tags;

            //var recipeTags = (reciep.RecipeTags.Select(u => new { Value = u.Tag.Id.ToString("D"), Name = u.Tag.Name })).ToList()
            //    .Select(u => new SelectListItem(u.Name, u.Value));
            //ViewBag.RecipeTags = recipeTags;
            return View(reciep);
        }

        [HttpPost("admin/recipes/{id}/tags/add")]
        public async Task<IActionResult> AddTag(Guid? id, [FromBody] string TagName)
        {
            if (id == null)
                return NotFound();

            var recipe = await dbContext.Recipes.Include(d => d.RecipeTags).ThenInclude(e => e.Tag).FirstOrDefaultAsync(d => d.Id == id);
            if (recipe == null)
                return NotFound();

            //Check if Tag is already added to Recipe
            if (recipe.RecipeTags.Any(d => d.Tag.Name == TagName))
            {
                return Json(new { success = false, tagName = TagName, message = "Tag already exists for this Recipe - " + recipe.RecipeName });
            }


            var tag = await dbContext.Tags.FirstOrDefaultAsync(m => m.Name == TagName);//.FindAsync(tagId);
            if (tag == null)
            {
                // TODO CREATE NEW TAG
                Tag newTag = new Tag(TagName);
                dbContext.Tags.Add(newTag);
                await dbContext.SaveChangesAsync();
                tag = await dbContext.Tags.FirstOrDefaultAsync(m => m.Name == TagName);//.FindAsync(tagId);
            }
            
            recipe.RecipeTags.Add(new RecipeTag
            {
                RecipeId = recipe.Id,
                TagId = tag.Id
            });

            await dbContext.SaveChangesAsync();
            return Json(new { success = true, tagName = tag.Name, id = tag.Id.ToString("D"), message = "Added Tag " + tag.Name + " to reciep " + recipe.RecipeName });
        }

        [HttpPost("admin/recipes/{id}/tags/remove")]
        public async Task<IActionResult> RemoveTag(Guid? id, [FromBody] Guid TagId)
        {
            if (id == null)
                return NotFound();

            var recipe = await dbContext.Recipes
                .Include(d => d.RecipeTags)
                .FirstOrDefaultAsync(d => d.Id == id.Value);
            if (recipe == null)
                return NotFound();

            var Tag = recipe.RecipeTags.FirstOrDefault(d => d.TagId == TagId);
            if (Tag != null)
            {
                recipe.RecipeTags.Remove(Tag);
                await dbContext.SaveChangesAsync();
                return Json(new { success = true, message = "Removed Tag from Recipe - "+recipe.RecipeName });
            }
            else
                return Json(new { success = false, message = "Tag is not associated with this Recipe - " + recipe.RecipeName });
        }

        [Route("admin/recipes/{id}/remove")]
        [HttpGet]
        public async Task<IActionResult> Remove(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultDocument = await dbContext.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resultDocument == null)
            {
                return NotFound();
            }

            return View(resultDocument);
        }

        [HttpPost("/admin/recipes/{id}/remove")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var resultDocument = await dbContext.Recipes.FindAsync(id);
            dbContext.Recipes.Remove(resultDocument);
            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
