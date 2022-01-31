using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganicNutritionRecipes.Migrations
{
    public partial class initialMigratios_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_SaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_SaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "Cholesterol_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "Protein_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "SaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "TotalSugar_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_SaturatedFatId",
                table: "NutritionFacts",
                column: "SaturatedFatId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_SaturatedFatId",
                table: "NutritionFacts",
                column: "SaturatedFatId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_SaturatedFatId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_SaturatedFatId",
                table: "NutritionFacts");

            migrationBuilder.AddColumn<int>(
                name: "NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cholesterol_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Protein_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaturatedFat_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalSugar_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_SaturatedFat_NutritionFactsId",
                table: "Nutrients",
                column: "SaturatedFat_NutritionFactsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_SaturatedFat_NutritionFactsId",
                table: "Nutrients",
                column: "SaturatedFat_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
