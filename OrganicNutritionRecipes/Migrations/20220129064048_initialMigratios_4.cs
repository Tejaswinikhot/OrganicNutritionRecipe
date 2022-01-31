using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganicNutritionRecipes.Migrations
{
    public partial class initialMigratios_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_NutritionFactsId",
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
                name: "FK_Nutrients_NutritionFacts_TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutrients_NutritionFacts_TotalSugar_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_NutritionFactsId",
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
                name: "IX_Nutrients_TotalDietaryFiber_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Nutrients_TotalSugar_NutritionFactsId",
                table: "Nutrients");

            migrationBuilder.AddColumn<int>(
                name: "CarbohydrateId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CholesterolId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PolyUnsaturatedFatId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProteinId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturatedFatId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalDietaryFiberId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalSugarId",
                table: "NutritionFacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_CarbohydrateId",
                table: "NutritionFacts",
                column: "CarbohydrateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_CholesterolId",
                table: "NutritionFacts",
                column: "CholesterolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_PolyUnsaturatedFatId",
                table: "NutritionFacts",
                column: "PolyUnsaturatedFatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_ProteinId",
                table: "NutritionFacts",
                column: "ProteinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_TotalDietaryFiberId",
                table: "NutritionFacts",
                column: "TotalDietaryFiberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_TotalSugarId",
                table: "NutritionFacts",
                column: "TotalSugarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_CarbohydrateId",
                table: "NutritionFacts",
                column: "CarbohydrateId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_CholesterolId",
                table: "NutritionFacts",
                column: "CholesterolId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_PolyUnsaturatedFatId",
                table: "NutritionFacts",
                column: "PolyUnsaturatedFatId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_ProteinId",
                table: "NutritionFacts",
                column: "ProteinId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_TotalDietaryFiberId",
                table: "NutritionFacts",
                column: "TotalDietaryFiberId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionFacts_Nutrients_TotalSugarId",
                table: "NutritionFacts",
                column: "TotalSugarId",
                principalTable: "Nutrients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_CarbohydrateId",
                table: "NutritionFacts");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_CholesterolId",
                table: "NutritionFacts");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_PolyUnsaturatedFatId",
                table: "NutritionFacts");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_ProteinId",
                table: "NutritionFacts");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_TotalDietaryFiberId",
                table: "NutritionFacts");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionFacts_Nutrients_TotalSugarId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_CarbohydrateId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_CholesterolId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_PolyUnsaturatedFatId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_ProteinId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_TotalDietaryFiberId",
                table: "NutritionFacts");

            migrationBuilder.DropIndex(
                name: "IX_NutritionFacts_TotalSugarId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "CarbohydrateId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "CholesterolId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "PolyUnsaturatedFatId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "ProteinId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "SaturatedFatId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "TotalDietaryFiberId",
                table: "NutritionFacts");

            migrationBuilder.DropColumn(
                name: "TotalSugarId",
                table: "NutritionFacts");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_NutritionFactsId",
                table: "Nutrients",
                column: "NutritionFactsId",
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
    }
}
