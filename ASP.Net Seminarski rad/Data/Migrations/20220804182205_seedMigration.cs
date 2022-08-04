using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_Seminarski_rad.Data.Migrations
{
    public partial class seedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ae3cd568-6242-4891-8d78-78065a39acf8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "eaeca1cf-599d-4aa1-afd1-d8fb542e3754");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d6d4d551-1575-4864-a8e4-4cd6e4b01ba3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "3a40e8db-d1ff-4a56-8ea1-50b215510066");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2329dfcf-fac4-46c8-a92d-cad42ebc10e3", "AQAAAAEAACcQAAAAEAcTzSRm+rzdmEj8cHCYH3f4BXSLxIH4WvAk4i3VsoaJTFj4BR+DxfKcm2tgbeT/Fg==", "96cb4354-a04b-4494-876e-1a6fed31dcc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e18395ca-0083-425d-a228-b6807d271a23", "AQAAAAEAACcQAAAAEJiFn5sTF/PROr0Yw1+MkwKi7q6n40vmwlLD+0NQAusEBZboVF6cEpWoTT3boH9xDA==", "394f623e-9712-4f6b-9820-949b839806fe" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImgUrl",
                value: "https://lh4.googleusercontent.com/uKiSMORQwKFcFD6mmxTLQKOJYzDnfa1SI-t4kUkZU0ctklvkYovubYe8YlXhmBLCYwHaM0VBvTuD2j68ODBCanhIY_nJteVdkPl6CtfVV2QQUvTf3wa4nukJsuB0NHrQWezwFjRI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0f48d6ff-ea0f-4b6d-8b28-f90b1ba51216");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9e7bf177-e5a8-481c-948e-8cb6b8709540");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "00d7caca-2ccf-4839-908b-37be11cb1c1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d887ce33-ce55-4f1a-a01e-67646b670c86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c344bf1-375b-4406-9270-2ee8d4cc902d", "AQAAAAEAACcQAAAAENncbUh2GPx2M0BXQXmF2u0vRl1ivsWb7y1JFiMlCDaO5zazi/B5mxZ/fObN8cE/yg==", "ac4812f0-5e67-4f29-a889-622aff41b97c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d56a686c-6951-4ee5-a6b6-ef6616c11941", "AQAAAAEAACcQAAAAEN4RijFhWlOMD4Z9wXIf1MlaBTtoqK5pYeJZDbKghqbH7dIgWZZElWrdME+i+viGww==", "e633f04a-4d1b-4c15-baaf-970b01134a77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImgUrl",
                value: "https://www.scarpebarefoot.com/wp-content/uploads/2020/04/Eastern_Traveler_stivale_furoshiki_Vibram_barefoot_BLACK-SUEDE_HERO-300x200.jpg");
        }
    }
}
