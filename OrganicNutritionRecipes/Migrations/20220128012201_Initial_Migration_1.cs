using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganicNutritionRecipes.Migrations
{
    public partial class Initial_Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipeType",
                table: "Recipes",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeType",
                table: "Recipes");
        }
    }
}
