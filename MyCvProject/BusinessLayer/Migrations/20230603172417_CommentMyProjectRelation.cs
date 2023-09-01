using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class CommentMyProjectRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_MyProjects_MyProjectId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MyProjectId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MyProjectId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "MyProjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyProjects_CommentId",
                table: "MyProjects",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProjects_Comments_CommentId",
                table: "MyProjects",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProjects_Comments_CommentId",
                table: "MyProjects");

            migrationBuilder.DropIndex(
                name: "IX_MyProjects_CommentId",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "MyProjects");

            migrationBuilder.AddColumn<int>(
                name: "MyProjectId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MyProjectId",
                table: "Comments",
                column: "MyProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_MyProjects_MyProjectId",
                table: "Comments",
                column: "MyProjectId",
                principalTable: "MyProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
