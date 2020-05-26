using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class ReaddedOriginalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68c66a7d-5166-4c56-914e-8837d1586b54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e109e11-cb6e-4c5b-aaa3-24b4b70fa859");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da8b65fb-6e41-414d-8f0e-5f9403a829ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e8b188a-b069-49cd-bc06-84a8b78c1df4", "2bd3777b-7025-42d8-b8b6-e580ec19b596", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af644c20-2b8a-4603-b980-ba2a42bbfe2d", "a83e9764-d6aa-441d-ab41-ec68e3937309", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4396b40f-b7e0-4cfd-8364-c5e0bc211e24", "e4a7f8d0-091e-4dc5-abf6-7fdbced0ee84", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4396b40f-b7e0-4cfd-8364-c5e0bc211e24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e8b188a-b069-49cd-bc06-84a8b78c1df4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af644c20-2b8a-4603-b980-ba2a42bbfe2d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e109e11-cb6e-4c5b-aaa3-24b4b70fa859", "f8f26e29-4cdf-4667-8c36-4f0fab56fbf1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da8b65fb-6e41-414d-8f0e-5f9403a829ff", "7fa56115-4d02-4438-b017-7da9f7af91a1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68c66a7d-5166-4c56-914e-8837d1586b54", "f78e3590-7d96-4776-bc57-e3166205b326", "Employee", "EMPLOYEE" });
        }
    }
}
