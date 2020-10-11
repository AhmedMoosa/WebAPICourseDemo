using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIApp.Migrations
{
    public partial class AddCategoryToSubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategories");
        }
    }
}
