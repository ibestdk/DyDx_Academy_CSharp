using Microsoft.EntityFrameworkCore.Migrations;

namespace DyDx_Academy.Migrations
{
    public partial class AddKeyCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59247322-fe7c-4bc4-a7ec-26793ee005b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7bbcc2d-2b37-439c-b7b2-58f78b0c219c");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Courses",
                newName: "CourseCategory");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "631a35e0-bfcb-46fa-8f1b-5638afc04003", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5609f20b-e19b-4df7-a1d4-a372f74d3efb", null, "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5609f20b-e19b-4df7-a1d4-a372f74d3efb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "631a35e0-bfcb-46fa-8f1b-5638afc04003");

            migrationBuilder.RenameColumn(
                name: "CourseCategory",
                table: "Courses",
                newName: "MovieCategory");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59247322-fe7c-4bc4-a7ec-26793ee005b5", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7bbcc2d-2b37-439c-b7b2-58f78b0c219c", null, "Member", "MEMBER" });
        }
    }
}
