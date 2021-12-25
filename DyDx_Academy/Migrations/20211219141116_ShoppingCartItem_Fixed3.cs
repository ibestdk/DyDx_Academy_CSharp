using Microsoft.EntityFrameworkCore.Migrations;

namespace DyDx_Academy.Migrations
{
    public partial class ShoppingCartItem_Fixed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Courses_CoursesId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07e6a74b-499b-494d-b3df-4c3d98889839");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "679b3f55-10dc-4fcb-94b1-5c360f1919b8");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCartCourses");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_CoursesId",
                table: "ShoppingCartCourses",
                newName: "IX_ShoppingCartCourses_CoursesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartCourses",
                table: "ShoppingCartCourses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3c9b1e1-7342-40e5-a32b-36bd35609403", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc1c3f6b-8e4f-458a-b133-e0f3a59cb782", null, "Member", "MEMBER" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartCourses_Courses_CoursesId",
                table: "ShoppingCartCourses",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartCourses_Courses_CoursesId",
                table: "ShoppingCartCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartCourses",
                table: "ShoppingCartCourses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1c3f6b-8e4f-458a-b133-e0f3a59cb782");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3c9b1e1-7342-40e5-a32b-36bd35609403");

            migrationBuilder.RenameTable(
                name: "ShoppingCartCourses",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartCourses_CoursesId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_CoursesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "679b3f55-10dc-4fcb-94b1-5c360f1919b8", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07e6a74b-499b-494d-b3df-4c3d98889839", null, "Member", "MEMBER" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Courses_CoursesId",
                table: "ShoppingCartItems",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
