using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aee35e8c-4594-40a2-a0f6-e5c219312b2c", "d9b1acdb-6dac-47db-8c0b-ec60cdd67c57", "Manager", "MANAGER" },
                    { "0dcb2f84-1177-487d-b8ea-f075f0f1821e", "2b35b368-373f-4682-b86a-46e60e7694c0", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dcb2f84-1177-487d-b8ea-f075f0f1821e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aee35e8c-4594-40a2-a0f6-e5c219312b2c");
        }
    }
}
