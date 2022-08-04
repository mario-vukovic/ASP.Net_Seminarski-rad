using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class user2MIg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "f956638d-1f41-4915-871f-e20eb3a8d3f4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11994e4c-cfc6-49fe-a9fb-51665e680246", "c80dc3af-99fc-4dd8-8ad2-0a88e187960c", "Editor", "EDITOR" },
                    { "3f3d5cd3-e84c-4933-acea-74408eae7ff0", "90983a12-f7aa-403d-b5e9-48d2703e2752", "Employee", "EMPLOYEE" },
                    { "ad858106-c60a-494e-a29a-e7d98acfc4a3", "6ebbff1d-9f03-4405-aa9b-ffd4f812c895", "BasicUser", "BASICUSER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f88d673-3447-4255-ad82-7d5dc3633484", "AQAAAAEAACcQAAAAEOMu+Qgc9OlStHunmdKyBsvv8DpGd0fJv+qZLOuBEEi3n60yLQkRJNtiaYjF2Sqygg==", "9545d240-0150-407a-92df-59ae48a8f513" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11994e4c-cfc6-49fe-a9fb-51665e680246");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f3d5cd3-e84c-4933-acea-74408eae7ff0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad858106-c60a-494e-a29a-e7d98acfc4a3");

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
    }
}
