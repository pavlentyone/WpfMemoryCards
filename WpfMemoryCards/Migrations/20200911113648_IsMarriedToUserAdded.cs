using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfMemoryCards.Migrations
{
    public partial class IsMarriedToUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    absorbed = table.Column<DateTime>(type: "DateTime", nullable: true),
                    deleted = table.Column<DateTime>(type: "DateTime", nullable: true),
                    hint1 = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: true),
                    hint2 = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: true),
                    pic1_id = table.Column<uint>(type: "int unsigned", nullable: true),
                    pic2_id = table.Column<uint>(type: "int unsigned", nullable: true),
                    tag_id = table.Column<uint>(type: "int unsigned", nullable: true),
                    text1 = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false),
                    text2 = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cards_Pictures_pic1_id",
                        column: x => x.pic1_id,
                        principalTable: "Pictures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_Pictures_pic2_id",
                        column: x => x.pic2_id,
                        principalTable: "Pictures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_Tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "Tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_pic1_id",
                table: "Cards",
                column: "pic1_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_pic2_id",
                table: "Cards",
                column: "pic2_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_tag_id",
                table: "Cards",
                column: "tag_id");
        }
    }
}
