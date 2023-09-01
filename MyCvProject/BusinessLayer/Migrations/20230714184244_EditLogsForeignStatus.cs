using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class EditLogsForeignStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_CreatedUserId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_DeletedUserId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_LastModifiedUserId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_CreatedUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_DeletedUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_LastModifiedUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_CreatedUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_DeletedUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_LastModifiedUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_CreatedUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_DeletedUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_LastModifiedUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_CreatedUserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_DeletedUserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_LastModifiedUserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_CreatedUserId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_DeletedUserId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_LastModifiedUserId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_CreatedUserId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_DeletedUserId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_LastModifiedUserId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_Likes_CreatedUserId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_DeletedUserId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_LastModifiedUserId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CreatedUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_DeletedUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_LastModifiedUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatedUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DeletedUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_LastModifiedUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreatedUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DeletedUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_LastModifiedUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_CreatedUserId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_DeletedUserId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_LastModifiedUserId",
                table: "Abouts");

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "NewsletterPersons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "NewsletterPersons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedUserId",
                table: "NewsletterPersons",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "MyProjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifiedUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "NewsletterPersons");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "NewsletterPersons");

            migrationBuilder.DropColumn(
                name: "LastModifiedUserId",
                table: "NewsletterPersons");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "MyProjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Likes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedUserId",
                table: "Abouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_CreatedUserId",
                table: "MyProjects",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_DeletedUserId",
                table: "MyProjects",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_LastModifiedUserId",
                table: "MyProjects",
                column: "LastModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CreatedUserId",
                table: "Likes",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_DeletedUserId",
                table: "Likes",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_LastModifiedUserId",
                table: "Likes",
                column: "LastModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CreatedUserId",
                table: "Contacts",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DeletedUserId",
                table: "Contacts",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LastModifiedUserId",
                table: "Contacts",
                column: "LastModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedUserId",
                table: "Comments",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DeletedUserId",
                table: "Comments",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LastModifiedUserId",
                table: "Comments",
                column: "LastModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedUserId",
                table: "Categories",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DeletedUserId",
                table: "Categories",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LastModifiedUserId",
                table: "Categories",
                column: "LastModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_CreatedUserId",
                table: "Abouts",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_DeletedUserId",
                table: "Abouts",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_LastModifiedUserId",
                table: "Abouts",
                column: "LastModifiedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_CreatedUserId",
                table: "Abouts",
                column: "CreatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_DeletedUserId",
                table: "Abouts",
                column: "DeletedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_LastModifiedUserId",
                table: "Abouts",
                column: "LastModifiedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_CreatedUserId",
                table: "Categories",
                column: "CreatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_DeletedUserId",
                table: "Categories",
                column: "DeletedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_LastModifiedUserId",
                table: "Categories",
                column: "LastModifiedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_CreatedUserId",
                table: "Comments",
                column: "CreatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_DeletedUserId",
                table: "Comments",
                column: "DeletedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_LastModifiedUserId",
                table: "Comments",
                column: "LastModifiedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_CreatedUserId",
                table: "Contacts",
                column: "CreatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_DeletedUserId",
                table: "Contacts",
                column: "DeletedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_LastModifiedUserId",
                table: "Contacts",
                column: "LastModifiedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_CreatedUserId",
                table: "Likes",
                column: "CreatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_DeletedUserId",
                table: "Likes",
                column: "DeletedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_LastModifiedUserId",
                table: "Likes",
                column: "LastModifiedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_CreatedUserId",
                table: "MyProjects",
                column: "CreatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_DeletedUserId",
                table: "MyProjects",
                column: "DeletedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_LastModifiedUserId",
                table: "MyProjects",
                column: "LastModifiedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
