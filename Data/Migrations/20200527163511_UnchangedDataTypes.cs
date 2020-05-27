using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class UnchangedDataTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16c2fab3-ef43-4c03-b69d-085bdee5c7de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb074ac-a15f-4732-9010-daf07ecdd7f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d873b60e-21a3-4034-ab4a-e4fa485dcab5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfa7215d-422a-4a51-86fc-bbb5fced0b87", "987e44ee-7049-4d2a-9d02-9ddd62e2a066", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "377fcdaa-0841-4eb9-a059-71b15f071aed", "3e8f6917-0fc0-4187-91c8-2f8c97661195", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae233924-834b-4706-9db3-d49782d59923", "fe5426ca-77ef-49ee-9307-3f5588aa3666", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "377fcdaa-0841-4eb9-a059-71b15f071aed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae233924-834b-4706-9db3-d49782d59923");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfa7215d-422a-4a51-86fc-bbb5fced0b87");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16c2fab3-ef43-4c03-b69d-085bdee5c7de", "0f8c7d91-8841-426b-8758-abe35a57435c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d873b60e-21a3-4034-ab4a-e4fa485dcab5", "9b5a3065-a058-4686-86b1-149394882d9f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbb074ac-a15f-4732-9010-daf07ecdd7f8", "f4e5a226-9c52-427a-a8a8-8346e605f3ed", "Employee", "EMPLOYEE" });
        }
    }
}
