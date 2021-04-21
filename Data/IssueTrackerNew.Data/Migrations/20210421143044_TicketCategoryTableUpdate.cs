using Microsoft.EntityFrameworkCore.Migrations;

namespace IssueTrackerNew.Data.Migrations
{
    public partial class TicketCategoryTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_ArticleCategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketCategory_TicketCategoryId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketCategory",
                table: "TicketCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "TicketCategory",
                newName: "TicketCategories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "ArticleCategories");

            migrationBuilder.RenameIndex(
                name: "IX_TicketCategory_IsDeleted",
                table: "TicketCategories",
                newName: "IX_TicketCategories_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IsDeleted",
                table: "ArticleCategories",
                newName: "IX_ArticleCategories_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketCategories",
                table: "TicketCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleCategories",
                table: "ArticleCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketCategories_TicketCategoryId",
                table: "Tickets",
                column: "TicketCategoryId",
                principalTable: "TicketCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketCategories_TicketCategoryId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketCategories",
                table: "TicketCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleCategories",
                table: "ArticleCategories");

            migrationBuilder.RenameTable(
                name: "TicketCategories",
                newName: "TicketCategory");

            migrationBuilder.RenameTable(
                name: "ArticleCategories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_TicketCategories_IsDeleted",
                table: "TicketCategory",
                newName: "IX_TicketCategory_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleCategories_IsDeleted",
                table: "Categories",
                newName: "IX_Categories_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketCategory",
                table: "TicketCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketCategory_TicketCategoryId",
                table: "Tickets",
                column: "TicketCategoryId",
                principalTable: "TicketCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
