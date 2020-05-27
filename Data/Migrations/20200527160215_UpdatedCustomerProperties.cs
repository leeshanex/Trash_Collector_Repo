using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_Proj.Data.Migrations
{
    public partial class UpdatedCustomerProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "OneTimePickupDay",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuspendPickupDates",
                table: "Customer",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OneTimePickupDay",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspendPickupDates",
                table: "Customer");

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
        }
    }
}
