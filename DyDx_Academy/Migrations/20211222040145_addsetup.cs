using Microsoft.EntityFrameworkCore.Migrations;

namespace DyDx_Academy.Migrations
{
    public partial class addsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Order_AspNetUsers_ApplicationUsersId",
                table: "Account_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Order_Orders_OrderId",
                table: "Account_Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account_Order",
                table: "Account_Order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94fd3612-e750-4d72-ab35-71c4530cf42b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f253c24c-a310-47c9-9122-727f446367ec");

            migrationBuilder.RenameTable(
                name: "Account_Order",
                newName: "Account_Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Account_Order_OrderId",
                table: "Account_Orders",
                newName: "IX_Account_Orders_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_Order_ApplicationUsersId",
                table: "Account_Orders",
                newName: "IX_Account_Orders_ApplicationUsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account_Orders",
                table: "Account_Orders",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec314b0e-cdc9-4da2-8693-63191d3e80aa", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a26dd607-cb23-46fe-bbb0-16ef7ec206d6", null, "Member", "MEMBER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Orders_AspNetUsers_ApplicationUsersId",
                table: "Account_Orders",
                column: "ApplicationUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Orders_Orders_OrderId",
                table: "Account_Orders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Orders_AspNetUsers_ApplicationUsersId",
                table: "Account_Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Orders_Orders_OrderId",
                table: "Account_Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account_Orders",
                table: "Account_Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a26dd607-cb23-46fe-bbb0-16ef7ec206d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec314b0e-cdc9-4da2-8693-63191d3e80aa");

            migrationBuilder.RenameTable(
                name: "Account_Orders",
                newName: "Account_Order");

            migrationBuilder.RenameIndex(
                name: "IX_Account_Orders_OrderId",
                table: "Account_Order",
                newName: "IX_Account_Order_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_Orders_ApplicationUsersId",
                table: "Account_Order",
                newName: "IX_Account_Order_ApplicationUsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account_Order",
                table: "Account_Order",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94fd3612-e750-4d72-ab35-71c4530cf42b", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f253c24c-a310-47c9-9122-727f446367ec", null, "Member", "MEMBER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Order_AspNetUsers_ApplicationUsersId",
                table: "Account_Order",
                column: "ApplicationUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Order_Orders_OrderId",
                table: "Account_Order",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
