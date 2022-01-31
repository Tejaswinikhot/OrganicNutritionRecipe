using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganicNutritionRecipes.Migrations
{
    public partial class initialMigratios_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_Carbohydrate_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_Carbohydrate_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CarbohydrateId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "Carbohydrate_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.AddColumn<int>(
                name: "CaffeineId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_CaffeineId",
                table: "NutritionFacts",
                column: "CaffeineId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_CaffeineId",
                table: "NutritionFacts",
                column: "CaffeineId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_CaffeineId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_CaffeineId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "CaffeineId",
                table: "NutritionFacts");

            migrationBuilder.AddColumn<int>(
                name: "CarbohydrateId",
                table: "NutritionFacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Carbohydrate_NutritionFactsId",
                table: "Nutrients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_Carbohydrate_NutritionFactsId",
                table: "Nutrients",
                column: "Carbohydrate_NutritionFactsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_Carbohydrate_NutritionFactsId",
                table: "Nutrients",
                column: "Carbohydrate_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
