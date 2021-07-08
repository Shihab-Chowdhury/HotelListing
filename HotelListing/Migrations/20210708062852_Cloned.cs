using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class Cloned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76007f81-ac1f-45a0-ad52-5442f5cc32ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4c25380-b2db-45ed-8f7e-72848283bfd2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2fe0586a-4cac-4cdd-a924-316b194823ea", "aad99c1b-9489-4f76-8f9c-aef3644609a7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59629439-0ca4-46aa-b7a1-5ebe965bc3c4", "910fa75f-f23b-4564-8a54-d5444487db7f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "76007f81-ac1f-45a0-ad52-5442f5cc32ef", "8360929e-0e41-4104-83df-281f0b50aa6a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4c25380-b2db-45ed-8f7e-72848283bfd2", "80159d65-2621-4e48-a65a-73fd63ac4d23", "Administrator", "ADMINISTRATOR" });
        }
    }
}
