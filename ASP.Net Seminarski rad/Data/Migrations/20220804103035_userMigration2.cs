using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class userMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "02d4a3ec-a551-4271-b3d5-89d734b9e1c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28d19372-3d43-43e6-89b6-b7e0c68ed61c", "7db2ebff-ebef-46fd-9059-6c2262b0abc0", "BasicUser", "BASICUSER" },
                    { "a80c34d2-e139-4807-ae7d-e8c1c54b54b4", "2880483b-470b-47e1-a1c0-25d931d26324", "Editor", "EDITOR" },
                    { "e9653493-f3b8-474a-bcfd-65bcfa176517", "f7ada08d-6c77-41e8-8143-80b71a32831b", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcaa08e0-f0f0-4de9-bfa7-3fb9d361be42", "AQAAAAEAACcQAAAAEJoPS9fC/1u7c/F+287t2xIJXqbXTi1o7Wy/Az748bNyClQxvtZ7x3eMATwjKvK/jQ==", "69a6cd26-0624-4563-8a6e-39e3d1bbebdc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28d19372-3d43-43e6-89b6-b7e0c68ed61c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a80c34d2-e139-4807-ae7d-e8c1c54b54b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9653493-f3b8-474a-bcfd-65bcfa176517");

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
    }
}
