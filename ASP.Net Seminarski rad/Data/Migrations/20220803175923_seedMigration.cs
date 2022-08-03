using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class seedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b5b0da-e21e-46ba-b766-e11cc7407744");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "e0a605b1-76f0-46c8-98e7-eaf33a22a095");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55b5b0da-e21e-46ba-b766-e11cc7407744", "af3ea454-04c1-4ecc-8d0f-612ddc65bbc7", "BasicUser", "BASICUSER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22dd4ddd-df0e-4621-af37-c2b36aaa6733",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d39a14f0-c0ab-4e05-9d46-740b9541deab", "AQAAAAEAACcQAAAAEDirE2mLKarB/VmCeLW3Aw49qPfRXzFDEVCN+TqWauCA+UWuTG8cmpd+pqSIYOR6ig==", "40c76e32-b19a-4fab-a519-e7042082a0c2" });
        }
    }
}
