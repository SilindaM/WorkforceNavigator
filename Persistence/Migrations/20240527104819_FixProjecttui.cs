using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FixProjecttui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TimesheetEntries_ProjectId",
                table: "TimesheetEntries",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetEntries_Projects_ProjectId",
                table: "TimesheetEntries",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetEntries_Projects_ProjectId",
                table: "TimesheetEntries");

            migrationBuilder.DropIndex(
                name: "IX_TimesheetEntries_ProjectId",
                table: "TimesheetEntries");
        }
    }
}
