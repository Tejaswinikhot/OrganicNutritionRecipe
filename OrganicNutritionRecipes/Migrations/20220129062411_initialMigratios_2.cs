using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganicNutritionRecipes.Migrations
{
    public partial class initialMigratios_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CaffeinePerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CarbohydrateGPerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Carbohydrate_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CholesterolPerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cholesterol_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nutrient_type",
                table: "Nutrients",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nutrient_type1",
                table: "Nutrients",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolyUnsaturatedFatPerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Protein_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProteinGPerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaturatedFat_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SaturatedFatPerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalDietaryGPer100G",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalSugar_NutritionFactsId",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SugarGPerMeasure",
                table: "Nutrients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NutritionFacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbohydrateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionFacts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_NutritionFactsId",
                table: "Nutrients",
                column: "NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_Carbohydrate_NutritionFactsId",
                table: "Nutrients",
                column: "Carbohydrate_NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_Cholesterol_NutritionFactsId",
                table: "Nutrients",
                column: "Cholesterol_NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients",
                column: "PolyUnsaturatedFat_NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_Protein_NutritionFactsId",
                table: "Nutrients",
                column: "Protein_NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_SaturatedFat_NutritionFactsId",
                table: "Nutrients",
                column: "SaturatedFat_NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients",
                column: "TotalDietaryFiber_NutritionFactsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_TotalSugar_NutritionFactsId",
                table: "Nutrients",
                column: "TotalSugar_NutritionFactsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_NutritionFactsId",
                table: "Nutrients",
                column: "NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_Carbohydrate_NutritionFactsId",
                table: "Nutrients",
                column: "Carbohydrate_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_Cholesterol_NutritionFactsId",
                table: "Nutrients",
                column: "Cholesterol_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients",
                column: "PolyUnsaturatedFat_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_Protein_NutritionFactsId",
                table: "Nutrients",
                column: "Protein_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_SaturatedFat_NutritionFactsId",
                table: "Nutrients",
                column: "SaturatedFat_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients",
                column: "TotalDietaryFiber_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrients_NutritionFacts_TotalSugar_NutritionFactsId",
                table: "Nutrients",
                column: "TotalSugar_NutritionFactsId",
                principalTable: "NutritionFacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_Carbohydrate_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_Cholesterol_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_Protein_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_SaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_TotalSugar_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropTable(
                name: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_Carbohydrate_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_Cholesterol_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_Protein_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_SaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_TotalSugar_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CaffeinePerMeasure",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CarbohydrateGPerMeasure",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "Carbohydrate_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CholesterolPerMeasure",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "Cholesterol_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "nutrient_type",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "nutrient_type1",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "PolyUnsaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "PolyUnsaturatedFatPerMeasure",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "Protein_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "ProteinGPerMeasure",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "SaturatedFat_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "SaturatedFatPerMeasure",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "TotalDietaryGPer100G",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "TotalSugar_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "SugarGPerMeasure",
                table: "Nutrients");
        }
    }
}
