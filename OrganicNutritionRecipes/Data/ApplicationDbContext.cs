using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrganicNutritionRecipes.Models;

namespace OrganicNutritionRecipes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<RecipeTag> RecipeTags { get; set; }

        public DbSet<Nutrient> Nutrients { get; set; }

        public DbSet<Produce> Produces { get; set; }

        public DbSet<ProduceNutrients> ProduceNutrients { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProduceNutrients>()
                .HasKey(j => new { j.ProduceId, j.NutrientId });

            modelBuilder.Entity<RecipeTag>()
                .HasKey(j => new { j.RecipeId, j.TagId });

            //modelBuilder.Entity<RecipeTags>()//.HasKey(j => new { j.RecipeId, j.TagId });
            //    .HasOne(d => d.Recipe)
            //    .WithMany(u => u.RecipeTags)
            //    .HasForeignKey(d => d.RecipeId);

            //modelBuilder.Entity<RecipeTags>()//.HasKey(j => new { j.RecipeId, j.TagId });
            //   .HasOne(d => d.Tag)
            //   .WithMany(u => u.RecipeTags)
            //   .HasForeignKey(d => d.TagId);

        }
    }
}
