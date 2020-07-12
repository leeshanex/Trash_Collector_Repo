using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class rolesList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "71d44a04-debb-4428-9b47-a82aebf341e1", "18193eb1-d249-4826-8714-ee45e6a47b52", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c97bcfe8-c29c-43a0-8817-ed0da3a78b9f", "92b1cf09-b93d-48dc-8064-cae491ec3471", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97e4b442-d510-40d3-b708-71714eba6bb2", "0140b39f-ac8d-4cc0-9b27-d4296cbe4794", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d44a04-debb-4428-9b47-a82aebf341e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97e4b442-d510-40d3-b708-71714eba6bb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c97bcfe8-c29c-43a0-8817-ed0da3a78b9f");

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
    }
}
