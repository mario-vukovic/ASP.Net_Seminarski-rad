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
                value: "135b105d-c4e5-49cd-959d-82c7851efd8b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2c0efa1-d505-4e69-bf00-3dc3e8c2a541", "5dd8c24d-0fc2-4474-8f26-e6c5085b5446", "Editor", "EDITOR" },
                    { "ef1b1e3f-f000-43d0-ab62-de8a7d8c0209", "2f3e021b-4add-47e4-89d9-f868983f9129", "BasicUser", "BASICUSER" },
                    { "fe2a53f6-0f47-453a-8b43-3fc80c219ca2", "4cda2494-ac6c-4413-8236-d2dd66ca5956", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b33fe2-d7b3-4f4d-a2d1-92e03cda6ef2", "AQAAAAEAACcQAAAAEFa6ABXsl97gf6maYdkL9EyjDsb+AyThOK4UxIN0bg9IJMuZ2Cg922TfBIJDm2/Q6Q==", "e2d6df93-050c-4ba3-9f11-e69ce1d2fce8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2c0efa1-d505-4e69-bf00-3dc3e8c2a541");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef1b1e3f-f000-43d0-ab62-de8a7d8c0209");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe2a53f6-0f47-453a-8b43-3fc80c219ca2");

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
    }
}
