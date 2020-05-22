using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class NewRolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb25db8a-2050-4cc7-9a30-2496aa0e3e72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd78d88d-7c5b-45a8-afbf-67e7ec13c120", "9a9a628f-ab0d-4305-bc12-50412bcdb8b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3dd4b733-94bf-487e-87e9-68d1c5504ac9", "0094d18a-605f-4455-b100-867b06217ea4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eb44bb73-7031-4895-a5c4-cdde7f36c4cd", "59c8dbab-8706-4f5f-801e-afcebe012032", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd4b733-94bf-487e-87e9-68d1c5504ac9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd78d88d-7c5b-45a8-afbf-67e7ec13c120");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb44bb73-7031-4895-a5c4-cdde7f36c4cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb25db8a-2050-4cc7-9a30-2496aa0e3e72", "5e63104d-2bbc-45f9-9442-ca42f6afbbfa", "Admin", "ADMIN" });
        }
    }
}
