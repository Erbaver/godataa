using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoData.Data.Migrations
{
    public partial class modifiedmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationMembers_Organizations_OrganizationId",
                table: "OrganizationMembers");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationMembers_OrganizationId",
                table: "OrganizationMembers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OrganizationMembers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "FormTemplates");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "DataForms");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "OrganizationMembers",
                newName: "UnitId");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Modified = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<DateTime>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_OrganizationMembers_UserId",
                        column: x => x.UserId,
                        principalTable: "OrganizationMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "OrganizationMembers",
                newName: "Role");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Organizations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OrganizationMembers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "FormTemplates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "DataForms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMembers_OrganizationId",
                table: "OrganizationMembers",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationMembers_Organizations_OrganizationId",
                table: "OrganizationMembers",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
