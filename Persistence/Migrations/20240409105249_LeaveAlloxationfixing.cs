using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class LeaveAlloxationfixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_Users_ApplicationUserId",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_ApplicationUserId",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "LeaveAllocations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "LeaveAllocations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_ApplicationUserId",
                table: "LeaveAllocations",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_Users_ApplicationUserId",
                table: "LeaveAllocations",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
