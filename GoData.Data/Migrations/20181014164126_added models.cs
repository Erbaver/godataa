using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoData.Data.Migrations
{
    public partial class addedmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationMembers");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Units");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "FormTemplates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "FormTemplates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "DataForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "DataForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrganizationMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Modified = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<DateTime>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationMember_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationMember_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Modified = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<DateTime>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationUnit_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationUnit_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Modified = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitMember_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitMember_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormTemplates_OrganizationId",
                table: "FormTemplates",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTemplates_UnitId",
                table: "FormTemplates",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_DataForms_OrganizationId",
                table: "DataForms",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DataForms_UnitId",
                table: "DataForms",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMember_OrganizationId",
                table: "OrganizationMember",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMember_UserId",
                table: "OrganizationMember",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUnit_OrganizationId",
                table: "OrganizationUnit",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUnit_UnitId",
                table: "OrganizationUnit",
                column: "UnitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnitMember_UnitId",
                table: "UnitMember",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMember_UserId",
                table: "UnitMember",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataForms_Organizations_OrganizationId",
                table: "DataForms",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataForms_Units_UnitId",
                table: "DataForms",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormTemplates_Organizations_OrganizationId",
                table: "FormTemplates",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormTemplates_Units_UnitId",
                table: "FormTemplates",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataForms_Organizations_OrganizationId",
                table: "DataForms");

            migrationBuilder.DropForeignKey(
                name: "FK_DataForms_Units_UnitId",
                table: "DataForms");

            migrationBuilder.DropForeignKey(
                name: "FK_FormTemplates_Organizations_OrganizationId",
                table: "FormTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_FormTemplates_Units_UnitId",
                table: "FormTemplates");

            migrationBuilder.DropTable(
                name: "OrganizationMember");

            migrationBuilder.DropTable(
                name: "OrganizationUnit");

            migrationBuilder.DropTable(
                name: "UnitMember");

            migrationBuilder.DropIndex(
                name: "IX_FormTemplates_OrganizationId",
                table: "FormTemplates");

            migrationBuilder.DropIndex(
                name: "IX_FormTemplates_UnitId",
                table: "FormTemplates");

            migrationBuilder.DropIndex(
                name: "IX_DataForms_OrganizationId",
                table: "DataForms");

            migrationBuilder.DropIndex(
                name: "IX_DataForms_UnitId",
                table: "DataForms");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "FormTemplates");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "FormTemplates");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "DataForms");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "DataForms");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Units",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrganizationMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<DateTime>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationMembers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMembers_OrganizationId",
                table: "OrganizationMembers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMembers_UserId",
                table: "OrganizationMembers",
                column: "UserId");
        }
    }
}
