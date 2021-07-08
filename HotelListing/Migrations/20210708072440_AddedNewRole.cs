using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedNewRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fe0586a-4cac-4cdd-a924-316b194823ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59629439-0ca4-46aa-b7a1-5ebe965bc3c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "848d0467-fdf5-4c8f-9bfb-90a52c8f0912", "8e075782-ffb5-4065-a18a-cf32c22841ea", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51313fd7-2a6a-4370-9b33-dacd2e0fa6b7", "987e2d72-e25c-4a6c-8dca-ff0bcc548d5e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ab2f034-3f6d-41e3-8b74-7b7162295853", "6d430909-3247-4b09-a70f-a99d1f5bb4a0", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51313fd7-2a6a-4370-9b33-dacd2e0fa6b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848d0467-fdf5-4c8f-9bfb-90a52c8f0912");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ab2f034-3f6d-41e3-8b74-7b7162295853");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2fe0586a-4cac-4cdd-a924-316b194823ea", "aad99c1b-9489-4f76-8f9c-aef3644609a7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59629439-0ca4-46aa-b7a1-5ebe965bc3c4", "910fa75f-f23b-4564-8a54-d5444487db7f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
