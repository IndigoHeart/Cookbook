using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.Migrations
{
    public partial class ModelUpdatev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_MealType_MealTypeId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealType",
                table: "MealType");

            migrationBuilder.RenameTable(
                name: "MealType",
                newName: "MealTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTypes",
                table: "MealTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_MealTypes_MealTypeId",
                table: "Recipes",
                column: "MealTypeId",
                principalTable: "MealTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_MealTypes_MealTypeId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTypes",
                table: "MealTypes");

            migrationBuilder.RenameTable(
                name: "MealTypes",
                newName: "MealType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealType",
                table: "MealType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_MealType_MealTypeId",
                table: "Recipes",
                column: "MealTypeId",
                principalTable: "MealType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
