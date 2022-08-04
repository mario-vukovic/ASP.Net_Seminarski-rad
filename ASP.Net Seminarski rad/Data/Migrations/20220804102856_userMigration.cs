using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class userMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31094c99-6b34-4597-a4b7-97c919c60554");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b625e7f-6d1f-4a09-8496-196d3c454810");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "919a2fae-c238-4e92-beda-891a24179c0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77b5b0da-e61e-46ba-b766-e1acc7401355",
                column: "ConcurrencyStamp",
                value: "5fe65589-9c69-47e1-9813-9261588e2d5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "368513eb-2ecd-4f88-8955-ef2df730c531", "961ca0c2-3ed6-4da7-8e73-212db88992b6", "Editor", "EDITOR" },
                    { "866702ee-7042-49a1-af11-c4ffae46b609", "dfb6c6db-b60c-4f26-805e-c355f3061c11", "Employee", "EMPLOYEE" },
                    { "b1e52873-466c-48bc-93ff-969220eceba8", "1a21a5fd-e4a2-4b16-b5fc-08bebf53daf6", "BasicUser", "BASICUSER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395c3929-2b5d-4ce8-933e-74ca9eb3cbd4", "AQAAAAEAACcQAAAAEF+yFZD0D8HOihk85lOK54zgZxObX9cdxTYgMTUqtW2EAJ12NqiGQKKbt7R16K8lBg==", "2bd2c58f-fb8f-4677-a70b-37ec4f1a4d47" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368513eb-2ecd-4f88-8955-ef2df730c531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866702ee-7042-49a1-af11-c4ffae46b609");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e52873-466c-48bc-93ff-969220eceba8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77b5b0da-e61e-46ba-b766-e1acc7401355",
                column: "ConcurrencyStamp",
                value: "e51cf17a-204b-41b2-90af-af8331a8d32a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31094c99-6b34-4597-a4b7-97c919c60554", "1b9f4357-70ef-4346-bfae-00cb52b30416", "BasicUser", "BASICUSER" },
                    { "5b625e7f-6d1f-4a09-8496-196d3c454810", "d0c85573-7620-490d-9456-64d2573eb047", "Editor", "EDITOR" },
                    { "919a2fae-c238-4e92-beda-891a24179c0a", "ba28ee98-b5b5-4635-8c6e-7e6e2eb7523b", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e738cbcc-4c84-4fe2-81e3-1876e40be8a5", "AQAAAAEAACcQAAAAEMUS+1qBFO2ikQhc4YcQ4E2bAqJkM64vJwLzfgqWaounZmQpbZMN3Fy4Gf5PHIjY5g==", "fe532851-5018-4fbc-a6df-658d4a2e5b4d" });
        }
    }
}
