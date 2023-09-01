using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class TableRelations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
