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

        public DbSet<HealthyFact> HealthyFacts { get; set; }

        public DbSet<RecipeTag> RecipeTags { get; set; }

        public DbSet<NutritionFacts> NutritionFacts { get; set; }

        public DbSet<Nutrient> Nutrients { get; set; }

        public DbSet<Caffeine> Caffines { get; set; }
        public DbSet<Carbohydrate> Carbohydrates { get; set; }
        public DbSet<Cholesterol> Cholesterols { get; set; }
       
        public DbSet<TotalDietaryFiber> TotalDietaryFibers { get; set; }
        public DbSet<TotalSugar> TotalSugars { get; set; }

        public DbSet<SaturatedFat> SaturatedFats { get; set; }
        public DbSet<PolyUnsaturatedFat> PolyUnsaturatedFats { get; set; }
        public DbSet<Protein> Proteins { get; set; }

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

            modelBuilder.Entity<Nutrient>()
                .HasDiscriminator<string>("nutrient_type1")
                //.HasValue<Nutrient>("nutrient_base")
                .HasValue<Caffeine>("caffeine")
                .HasValue<Carbohydrate>("carbohydrate")
                .HasValue<Cholesterol>("cholesterol")
                .HasValue<PolyUnsaturatedFat>("polyunsaturatedfat")
                .HasValue<Protein>("protein")
                .HasValue<SaturatedFat>("saturatedfat")
                .HasValue<TotalDietaryFiber>("totaldietaryfiber")
                .HasValue<TotalSugar>("totalsugar");

            modelBuilder.Entity<Tag>()
               .HasOne(d => d.HealthyFact)
               .WithOne(i => i.Tag)
               .HasForeignKey<HealthyFact>(b => b.TagId);

            modelBuilder.Entity<Nutrient>()
                .Property(e => e.NutrientType)
                .HasMaxLength(200)
                .HasColumnName("nutrient_type");

            modelBuilder.Entity<Caffeine>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.Caffeine)
                .HasForeignKey<NutritionFacts>(b => b.CaffeineId);

            modelBuilder.Entity<Carbohydrate>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.Carbohydrate)
                .HasForeignKey<NutritionFacts>(b => b.CarbohydrateId);

            modelBuilder.Entity<Cholesterol>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.Cholesterol)
                .HasForeignKey<NutritionFacts>(b => b.CholesterolId);

            modelBuilder.Entity<PolyUnsaturatedFat>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.PolyUnsaturatedFat)
                .HasForeignKey<NutritionFacts>(b => b.PolyUnsaturatedFatId);

            modelBuilder.Entity<Protein>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.Protein)
                .HasForeignKey<NutritionFacts>(b => b.ProteinId);

            modelBuilder.Entity<TotalDietaryFiber>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.TotalDietaryFiber)
                .HasForeignKey<NutritionFacts>(b => b.TotalDietaryFiberId);

            modelBuilder.Entity<TotalSugar>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.TotalSugar)
                .HasForeignKey<NutritionFacts>(b => b.TotalSugarId);

            modelBuilder.Entity<SaturatedFat>()
                .HasOne(d => d.NutritionFacts)
                .WithOne(i => i.SaturatedFat)
                .HasForeignKey<NutritionFacts>(b => b.SaturatedFatId);

            //modelBuilder.Entity<Nutrient>()
            //    .Property(e => e.NutrientType)
            //    .HasMaxLength(200)
            //    .HasColumnName("nutrient_type");

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
