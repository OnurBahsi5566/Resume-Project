using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class LogsEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_CreateUserId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_DeleteUserId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_LastModifyUserId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_CreateUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_DeleteUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_LastModifyUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_CreateUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_DeleteUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_LastModifyUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_CreateUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_DeleteUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_LastModifyUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_CreateUserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_DeleteUserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_LastModifyUserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_CreateUserId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_DeleteUserId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_LastModifyUserId",
                table: "MyProjects");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "Users",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Users",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "NewsletterPersons",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "NewsletterPersons",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "NewsletterPersons",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "MyProjects",
                newName: "LastModifiedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "MyProjects",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "MyProjects",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "MyProjects",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "MyProjects",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "MyProjects",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_LastModifyUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_LastModifiedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_DeleteUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_DeletedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_CreateUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Likes",
                newName: "LastModifiedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "Likes",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Likes",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Likes",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Likes",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Likes",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_LastModifyUserId",
                table: "Likes",
                newName: "IX_Likes_LastModifiedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_DeleteUserId",
                table: "Likes",
                newName: "IX_Likes_DeletedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_CreateUserId",
                table: "Likes",
                newName: "IX_Likes_CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Contacts",
                newName: "LastModifiedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "Contacts",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Contacts",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Contacts",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Contacts",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Contacts",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_LastModifyUserId",
                table: "Contacts",
                newName: "IX_Contacts_LastModifiedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_DeleteUserId",
                table: "Contacts",
                newName: "IX_Contacts_DeletedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_CreateUserId",
                table: "Contacts",
                newName: "IX_Contacts_CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Comments",
                newName: "LastModifiedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "Comments",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Comments",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Comments",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Comments",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Comments",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_LastModifyUserId",
                table: "Comments",
                newName: "IX_Comments_LastModifiedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DeleteUserId",
                table: "Comments",
                newName: "IX_Comments_DeletedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CreateUserId",
                table: "Comments",
                newName: "IX_Comments_CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Categories",
                newName: "LastModifiedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "Categories",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Categories",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Categories",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Categories",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Categories",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_LastModifyUserId",
                table: "Categories",
                newName: "IX_Categories_LastModifiedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_DeleteUserId",
                table: "Categories",
                newName: "IX_Categories_DeletedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreateUserId",
                table: "Categories",
                newName: "IX_Categories_CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Abouts",
                newName: "LastModifiedUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyDate",
                table: "Abouts",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Abouts",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Abouts",
                newName: "DeletedDate");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Abouts",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Abouts",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_LastModifyUserId",
                table: "Abouts",
                newName: "IX_Abouts_LastModifiedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_DeleteUserId",
                table: "Abouts",
                newName: "IX_Abouts_DeletedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_CreateUserId",
                table: "Abouts",
                newName: "IX_Abouts_CreatedUserId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Users",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Users",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "NewsletterPersons",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "NewsletterPersons",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "NewsletterPersons",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUserId",
                table: "MyProjects",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "MyProjects",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "MyProjects",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "MyProjects",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "MyProjects",
                newName: "CreateUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "MyProjects",
                newName: "CreateDate");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_LastModifiedUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_DeletedUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_CreatedUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUserId",
                table: "Likes",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Likes",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Likes",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Likes",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Likes",
                newName: "CreateUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Likes",
                newName: "CreateDate");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_LastModifiedUserId",
                table: "Likes",
                newName: "IX_Likes_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_DeletedUserId",
                table: "Likes",
                newName: "IX_Likes_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_CreatedUserId",
                table: "Likes",
                newName: "IX_Likes_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUserId",
                table: "Contacts",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Contacts",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Contacts",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Contacts",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Contacts",
                newName: "CreateUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Contacts",
                newName: "CreateDate");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_LastModifiedUserId",
                table: "Contacts",
                newName: "IX_Contacts_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_DeletedUserId",
                table: "Contacts",
                newName: "IX_Contacts_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_CreatedUserId",
                table: "Contacts",
                newName: "IX_Contacts_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUserId",
                table: "Comments",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Comments",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Comments",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Comments",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Comments",
                newName: "CreateUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Comments",
                newName: "CreateDate");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_LastModifiedUserId",
                table: "Comments",
                newName: "IX_Comments_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DeletedUserId",
                table: "Comments",
                newName: "IX_Comments_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CreatedUserId",
                table: "Comments",
                newName: "IX_Comments_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUserId",
                table: "Categories",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Categories",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Categories",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Categories",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Categories",
                newName: "CreateUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "CreateDate");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_LastModifiedUserId",
                table: "Categories",
                newName: "IX_Categories_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_DeletedUserId",
                table: "Categories",
                newName: "IX_Categories_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreatedUserId",
                table: "Categories",
                newName: "IX_Categories_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUserId",
                table: "Abouts",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Abouts",
                newName: "LastModifyDate");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Abouts",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Abouts",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Abouts",
                newName: "CreateUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Abouts",
                newName: "CreateDate");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_LastModifiedUserId",
                table: "Abouts",
                newName: "IX_Abouts_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_DeletedUserId",
                table: "Abouts",
                newName: "IX_Abouts_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_CreatedUserId",
                table: "Abouts",
                newName: "IX_Abouts_CreateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_CreateUserId",
                table: "Abouts",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_DeleteUserId",
                table: "Abouts",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_LastModifyUserId",
                table: "Abouts",
                column: "LastModifyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_CreateUserId",
                table: "Categories",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_DeleteUserId",
                table: "Categories",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_LastModifyUserId",
                table: "Categories",
                column: "LastModifyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_CreateUserId",
                table: "Comments",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_DeleteUserId",
                table: "Comments",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_LastModifyUserId",
                table: "Comments",
                column: "LastModifyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_CreateUserId",
                table: "Contacts",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_DeleteUserId",
                table: "Contacts",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_LastModifyUserId",
                table: "Contacts",
                column: "LastModifyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_CreateUserId",
                table: "Likes",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_DeleteUserId",
                table: "Likes",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_LastModifyUserId",
                table: "Likes",
                column: "LastModifyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_CreateUserId",
                table: "MyProjects",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_DeleteUserId",
                table: "MyProjects",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_LastModifyUserId",
                table: "MyProjects",
                column: "LastModifyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
