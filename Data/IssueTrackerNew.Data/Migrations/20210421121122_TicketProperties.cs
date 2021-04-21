using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IssueTrackerNew.Data.Migrations
{
    public partial class TicketProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Categories_CategoryId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Tickets",
                newName: "TicketCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_CategoryId",
                table: "Tickets",
                newName: "IX_Tickets_TicketCategoryId");

            migrationBuilder.CreateTable(
                name: "TicketCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketCategory_IsDeleted",
                table: "TicketCategory",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketCategory_TicketCategoryId",
                table: "Tickets",
                column: "TicketCategoryId",
                principalTable: "TicketCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketCategory_TicketCategoryId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "TicketCategory");

            migrationBuilder.RenameColumn(
                name: "TicketCategoryId",
                table: "Tickets",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TicketCategoryId",
                table: "Tickets",
                newName: "IX_Tickets_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Categories_CategoryId",
                table: "Tickets",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
