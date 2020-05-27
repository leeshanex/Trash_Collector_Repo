using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class EmployeeUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Employees",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d58a5151-b337-458a-9692-b222a607aa28", "0b9ce406-e6d2-4d6a-a049-50322e0fff09", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c2a73b2-aa7c-4a5a-8a3d-08acec0ddd4b", "0e8cb9bd-1b4b-46b1-afa3-dd791f934253", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf93218-c2e6-4da2-97ee-68c9ad4d1777", "235e1645-9061-4112-9b09-14797a2271c2", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2a73b2-aa7c-4a5a-8a3d-08acec0ddd4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d58a5151-b337-458a-9692-b222a607aa28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf93218-c2e6-4da2-97ee-68c9ad4d1777");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employees");

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
    }
}
