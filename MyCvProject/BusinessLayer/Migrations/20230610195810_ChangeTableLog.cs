using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class ChangeTableLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsletterPersons_Users_CreatePersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsletterPersons_Users_DeletePersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsletterPersons_Users_LastModifyPersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropIndex(
                name: "IX_NewsletterPersons_CreatePersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropIndex(
                name: "IX_NewsletterPersons_DeletePersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropIndex(
                name: "IX_NewsletterPersons_LastModifyPersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropColumn(
                name: "CreatePersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropColumn(
                name: "DeletePersonId",
                table: "NewsletterPersons");

            migrationBuilder.DropColumn(
                name: "LastModifyPersonId",
                table: "NewsletterPersons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatePersonId",
                table: "NewsletterPersons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletePersonId",
                table: "NewsletterPersons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifyPersonId",
                table: "NewsletterPersons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterPersons_CreatePersonId",
                table: "NewsletterPersons",
                column: "CreatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterPersons_DeletePersonId",
                table: "NewsletterPersons",
                column: "DeletePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterPersons_LastModifyPersonId",
                table: "NewsletterPersons",
                column: "LastModifyPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsletterPersons_Users_CreatePersonId",
                table: "NewsletterPersons",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsletterPersons_Users_DeletePersonId",
                table: "NewsletterPersons",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsletterPersons_Users_LastModifyPersonId",
                table: "NewsletterPersons",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
