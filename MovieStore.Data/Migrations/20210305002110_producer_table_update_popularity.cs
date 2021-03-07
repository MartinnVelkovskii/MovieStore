using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Data.Migrations
{
    public partial class producer_table_update_popularity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Popularity",
                table: "Producers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Producers");
        }
    }
}
