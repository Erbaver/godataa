using Microsoft.EntityFrameworkCore.Migrations;

namespace GoData.Data.Migrations
{
    public partial class addednewdbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitMember_Units_UnitId",
                table: "UnitMember");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMember_Users_UserId",
                table: "UnitMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitMember",
                table: "UnitMember");

            migrationBuilder.RenameTable(
                name: "UnitMember",
                newName: "UnitMembers");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMember_UserId",
                table: "UnitMembers",
                newName: "IX_UnitMembers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMember_UnitId",
                table: "UnitMembers",
                newName: "IX_UnitMembers_UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitMembers",
                table: "UnitMembers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMembers_Units_UnitId",
                table: "UnitMembers",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMembers_Users_UserId",
                table: "UnitMembers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitMembers_Units_UnitId",
                table: "UnitMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMembers_Users_UserId",
                table: "UnitMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitMembers",
                table: "UnitMembers");

            migrationBuilder.RenameTable(
                name: "UnitMembers",
                newName: "UnitMember");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMembers_UserId",
                table: "UnitMember",
                newName: "IX_UnitMember_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMembers_UnitId",
                table: "UnitMember",
                newName: "IX_UnitMember_UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitMember",
                table: "UnitMember",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMember_Units_UnitId",
                table: "UnitMember",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMember_Users_UserId",
                table: "UnitMember",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
