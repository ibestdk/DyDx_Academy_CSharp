using Microsoft.EntityFrameworkCore.Migrations;

namespace DyDx_Academy.Migrations
{
    public partial class ShoppingCartItem_Fixed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b1b4ed4-93b6-44c3-a92a-2257a17aa2e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98c6bd6d-293a-41ae-9e46-528dedfe3e6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "679b3f55-10dc-4fcb-94b1-5c360f1919b8", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07e6a74b-499b-494d-b3df-4c3d98889839", null, "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07e6a74b-499b-494d-b3df-4c3d98889839");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "679b3f55-10dc-4fcb-94b1-5c360f1919b8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98c6bd6d-293a-41ae-9e46-528dedfe3e6f", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b1b4ed4-93b6-44c3-a92a-2257a17aa2e2", null, "Member", "MEMBER" });
        }
    }
}
