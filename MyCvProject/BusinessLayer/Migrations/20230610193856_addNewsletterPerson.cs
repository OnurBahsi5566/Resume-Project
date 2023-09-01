using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class addNewsletterPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatePersonId",
                table: "MyProjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "MyProjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletePersonId",
                table: "MyProjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyDate",
                table: "MyProjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastModifyPersonId",
                table: "MyProjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatePersonId",
                table: "Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletePersonId",
                table: "Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastModifyPersonId",
                table: "Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatePersonId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletePersonId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastModifyPersonId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatePersonId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletePersonId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastModifyPersonId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatePersonId",
                table: "Abouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletePersonId",
                table: "Abouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyDate",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastModifyPersonId",
                table: "Abouts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NewsletterPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatePersonId = table.Column<int>(type: "int", nullable: true),
                    LastModifyPersonId = table.Column<int>(type: "int", nullable: true),
                    DeletePersonId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsletterPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsletterPersons_Users_CreatePersonId",
                        column: x => x.CreatePersonId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsletterPersons_Users_DeletePersonId",
                        column: x => x.DeletePersonId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsletterPersons_Users_LastModifyPersonId",
                        column: x => x.LastModifyPersonId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_CreatePersonId",
                table: "MyProjects",
                column: "CreatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_DeletePersonId",
                table: "MyProjects",
                column: "DeletePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_LastModifyPersonId",
                table: "MyProjects",
                column: "LastModifyPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CreatePersonId",
                table: "Contacts",
                column: "CreatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DeletePersonId",
                table: "Contacts",
                column: "DeletePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LastModifyPersonId",
                table: "Contacts",
                column: "LastModifyPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatePersonId",
                table: "Comments",
                column: "CreatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DeletePersonId",
                table: "Comments",
                column: "DeletePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LastModifyPersonId",
                table: "Comments",
                column: "LastModifyPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatePersonId",
                table: "Categories",
                column: "CreatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DeletePersonId",
                table: "Categories",
                column: "DeletePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LastModifyPersonId",
                table: "Categories",
                column: "LastModifyPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_CreatePersonId",
                table: "Abouts",
                column: "CreatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_DeletePersonId",
                table: "Abouts",
                column: "DeletePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_LastModifyPersonId",
                table: "Abouts",
                column: "LastModifyPersonId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_MyProjects_Users_CreatePersonId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_DeletePersonId",
                table: "MyProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Users_LastModifyPersonId",
                table: "MyProjects");

            migrationBuilder.DropTable(
                name: "NewsletterPersons");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_CreatePersonId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_DeletePersonId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_LastModifyPersonId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CreatePersonId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_DeletePersonId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_LastModifyPersonId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatePersonId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DeletePersonId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_LastModifyPersonId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreatePersonId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DeletePersonId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_LastModifyPersonId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_CreatePersonId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_DeletePersonId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_LastModifyPersonId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifyDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatePersonId",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "DeletePersonId",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "LastModifyDate",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "LastModifyPersonId",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "CreatePersonId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DeletePersonId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "LastModifyDate",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "LastModifyPersonId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CreatePersonId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletePersonId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LastModifyDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LastModifyPersonId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatePersonId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletePersonId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifyDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifyPersonId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatePersonId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "DeletePersonId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "LastModifyDate",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "LastModifyPersonId",
                table: "Abouts");
        }
    }
}
