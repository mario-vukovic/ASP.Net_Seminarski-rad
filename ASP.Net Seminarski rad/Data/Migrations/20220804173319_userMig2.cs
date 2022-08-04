using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class userMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77b5b0da-e61e-46ba-b766-e1acc7401355",
                column: "ConcurrencyStamp",
                value: "d0ce3a8d-bcf7-487c-b0fe-2f188964e310");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d0bfd28-d4e5-4fcf-af1f-a278580264bc", "18856335-9018-4b97-8e49-017a013d06c5", "BasicUser", "BASICUSER" },
                    { "3b0fb086-2768-4935-b2e8-4525f6d9319b", "bb0460a8-b7af-440e-9363-39e9ddb407b7", "Editor", "EDITOR" },
                    { "3ceba21b-fc6a-42fc-bfd0-c154a4981e7d", "7451ce95-7931-4e0d-b93a-96a7b56840d7", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41c238c2-9116-4bb6-a194-074ff866c98a", "AQAAAAEAACcQAAAAEKoEEC7hS3AewsleQ0w8PMwtJG8KyBJAr2qgbgCkaN27ANAwk5uBPlMvlTTm/01fhA==", "a1fd5714-66f1-4c24-a66b-2f7321082b52" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d0bfd28-d4e5-4fcf-af1f-a278580264bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b0fb086-2768-4935-b2e8-4525f6d9319b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ceba21b-fc6a-42fc-bfd0-c154a4981e7d");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

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
    }
}
