using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class ChangeFulllogName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_CreatePersonId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_DeletePersonId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Users_LastModifyPersonId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_CreatePersonId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_DeletePersonId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_LastModifyPersonId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_CreatePersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_DeletePersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_LastModifyPersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_CreatePersonId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_DeletePersonId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_LastModifyPersonId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_CreatePersonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_DeletePersonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_LastModifyPersonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_CreatePersonId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_DeletePersonId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_LastModifyPersonId",
                table: "MyProjects");

            migrationBuilder.RenameColumn(
                name: "LastModifyPersonId",
                table: "MyProjects",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "DeletePersonId",
                table: "MyProjects",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "CreatePersonId",
                table: "MyProjects",
                newName: "CreateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_LastModifyPersonId",
                table: "MyProjects",
                newName: "IX_MyProjects_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_DeletePersonId",
                table: "MyProjects",
                newName: "IX_MyProjects_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_CreatePersonId",
                table: "MyProjects",
                newName: "IX_MyProjects_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyPersonId",
                table: "Likes",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "DeletePersonId",
                table: "Likes",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "CreatePersonId",
                table: "Likes",
                newName: "CreateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_LastModifyPersonId",
                table: "Likes",
                newName: "IX_Likes_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_DeletePersonId",
                table: "Likes",
                newName: "IX_Likes_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_CreatePersonId",
                table: "Likes",
                newName: "IX_Likes_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyPersonId",
                table: "Contacts",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "DeletePersonId",
                table: "Contacts",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "CreatePersonId",
                table: "Contacts",
                newName: "CreateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_LastModifyPersonId",
                table: "Contacts",
                newName: "IX_Contacts_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_DeletePersonId",
                table: "Contacts",
                newName: "IX_Contacts_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_CreatePersonId",
                table: "Contacts",
                newName: "IX_Contacts_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyPersonId",
                table: "Comments",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "DeletePersonId",
                table: "Comments",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "CreatePersonId",
                table: "Comments",
                newName: "CreateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_LastModifyPersonId",
                table: "Comments",
                newName: "IX_Comments_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DeletePersonId",
                table: "Comments",
                newName: "IX_Comments_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CreatePersonId",
                table: "Comments",
                newName: "IX_Comments_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyPersonId",
                table: "Categories",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "DeletePersonId",
                table: "Categories",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "CreatePersonId",
                table: "Categories",
                newName: "CreateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_LastModifyPersonId",
                table: "Categories",
                newName: "IX_Categories_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_DeletePersonId",
                table: "Categories",
                newName: "IX_Categories_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreatePersonId",
                table: "Categories",
                newName: "IX_Categories_CreateUserId");

            migrationBuilder.RenameColumn(
                name: "LastModifyPersonId",
                table: "Abouts",
                newName: "LastModifyUserId");

            migrationBuilder.RenameColumn(
                name: "DeletePersonId",
                table: "Abouts",
                newName: "DeleteUserId");

            migrationBuilder.RenameColumn(
                name: "CreatePersonId",
                table: "Abouts",
                newName: "CreateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_LastModifyPersonId",
                table: "Abouts",
                newName: "IX_Abouts_LastModifyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_DeletePersonId",
                table: "Abouts",
                newName: "IX_Abouts_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_CreatePersonId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "LastModifyUserId",
                table: "MyProjects",
                newName: "LastModifyPersonId");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "MyProjects",
                newName: "DeletePersonId");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "MyProjects",
                newName: "CreatePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_LastModifyUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_LastModifyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_DeleteUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_DeletePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProjects_CreateUserId",
                table: "MyProjects",
                newName: "IX_MyProjects_CreatePersonId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Likes",
                newName: "LastModifyPersonId");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Likes",
                newName: "DeletePersonId");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Likes",
                newName: "CreatePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_LastModifyUserId",
                table: "Likes",
                newName: "IX_Likes_LastModifyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_DeleteUserId",
                table: "Likes",
                newName: "IX_Likes_DeletePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_CreateUserId",
                table: "Likes",
                newName: "IX_Likes_CreatePersonId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Contacts",
                newName: "LastModifyPersonId");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Contacts",
                newName: "DeletePersonId");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Contacts",
                newName: "CreatePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_LastModifyUserId",
                table: "Contacts",
                newName: "IX_Contacts_LastModifyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_DeleteUserId",
                table: "Contacts",
                newName: "IX_Contacts_DeletePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_CreateUserId",
                table: "Contacts",
                newName: "IX_Contacts_CreatePersonId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Comments",
                newName: "LastModifyPersonId");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Comments",
                newName: "DeletePersonId");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Comments",
                newName: "CreatePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_LastModifyUserId",
                table: "Comments",
                newName: "IX_Comments_LastModifyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DeleteUserId",
                table: "Comments",
                newName: "IX_Comments_DeletePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CreateUserId",
                table: "Comments",
                newName: "IX_Comments_CreatePersonId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Categories",
                newName: "LastModifyPersonId");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Categories",
                newName: "DeletePersonId");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Categories",
                newName: "CreatePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_LastModifyUserId",
                table: "Categories",
                newName: "IX_Categories_LastModifyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_DeleteUserId",
                table: "Categories",
                newName: "IX_Categories_DeletePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreateUserId",
                table: "Categories",
                newName: "IX_Categories_CreatePersonId");

            migrationBuilder.RenameColumn(
                name: "LastModifyUserId",
                table: "Abouts",
                newName: "LastModifyPersonId");

            migrationBuilder.RenameColumn(
                name: "DeleteUserId",
                table: "Abouts",
                newName: "DeletePersonId");

            migrationBuilder.RenameColumn(
                name: "CreateUserId",
                table: "Abouts",
                newName: "CreatePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_LastModifyUserId",
                table: "Abouts",
                newName: "IX_Abouts_LastModifyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_DeleteUserId",
                table: "Abouts",
                newName: "IX_Abouts_DeletePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Abouts_CreateUserId",
                table: "Abouts",
                newName: "IX_Abouts_CreatePersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_CreatePersonId",
                table: "Abouts",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_DeletePersonId",
                table: "Abouts",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Users_LastModifyPersonId",
                table: "Abouts",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_CreatePersonId",
                table: "Categories",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_DeletePersonId",
                table: "Categories",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_LastModifyPersonId",
                table: "Categories",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_CreatePersonId",
                table: "Comments",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_DeletePersonId",
                table: "Comments",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_LastModifyPersonId",
                table: "Comments",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_CreatePersonId",
                table: "Contacts",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_DeletePersonId",
                table: "Contacts",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_LastModifyPersonId",
                table: "Contacts",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_CreatePersonId",
                table: "Likes",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_DeletePersonId",
                table: "Likes",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_LastModifyPersonId",
                table: "Likes",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_CreatePersonId",
                table: "MyProjects",
                column: "CreatePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_DeletePersonId",
                table: "MyProjects",
                column: "DeletePersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Users_LastModifyPersonId",
                table: "MyProjects",
                column: "LastModifyPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
