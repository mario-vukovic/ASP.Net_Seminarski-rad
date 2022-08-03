using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class idkWhatImDoingMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductCategory");
        }
    }
}
