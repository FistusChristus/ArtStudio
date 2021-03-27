using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtStudio.Migrations
{
    public partial class Update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResourceFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceFiles_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceFiles_ResourceId",
                table: "ResourceFiles",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResourceFiles");
        }
    }
}
