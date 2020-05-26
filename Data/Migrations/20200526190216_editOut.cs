using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class editOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "222193be-d6fd-4571-b753-bcfbfacf6913");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "681cc105-b53d-404f-b0d6-2d4718cb7e98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7deeef49-1893-4b3f-aa78-18b2e76804b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "436b2079-457c-43d6-a1ca-5aaece32e2e7", "9878464a-4756-4241-80bd-e0a54970114c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4653e7d9-ee36-4435-98b8-3d2ee3fec366", "4cbf72c9-d68c-4106-88d1-9695ff9a90f3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f80f8cca-e94b-4cc5-b1aa-1f1c6b7fceb7", "c44a4445-97f3-43d5-97d8-a16e46164848", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "436b2079-457c-43d6-a1ca-5aaece32e2e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4653e7d9-ee36-4435-98b8-3d2ee3fec366");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f80f8cca-e94b-4cc5-b1aa-1f1c6b7fceb7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7deeef49-1893-4b3f-aa78-18b2e76804b5", "8c927bf1-298d-439d-af49-89c062f884cd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "681cc105-b53d-404f-b0d6-2d4718cb7e98", "563d87a7-5162-4f4e-a93f-e6557f6d30e9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "222193be-d6fd-4571-b753-bcfbfacf6913", "605d5315-58ff-409a-857f-41ea34f1ab03", "Employee", "EMPLOYEE" });
        }
    }
}
