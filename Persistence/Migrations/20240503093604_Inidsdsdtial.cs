

namespace Persistence.Migrations
{
  using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
  public partial class Inidsdsdtial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Teams_TeamId",
                table: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_JobTitles_TeamId",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "JobTitles");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "JobTitles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_TeamId",
                table: "JobTitles",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Teams_TeamId",
                table: "JobTitles",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
