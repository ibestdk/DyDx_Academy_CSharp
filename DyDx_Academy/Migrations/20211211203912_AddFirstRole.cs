using Microsoft.EntityFrameworkCore.Migrations;

namespace DyDx_Academy.Migrations
{
    public partial class AddFirstRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fb0f397-b8b1-4616-a7ec-3133fbfce636", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0467bff-c660-4b18-985f-09aeeb0ccb23", null, "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fb0f397-b8b1-4616-a7ec-3133fbfce636");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0467bff-c660-4b18-985f-09aeeb0ccb23");
        }
    }
}
