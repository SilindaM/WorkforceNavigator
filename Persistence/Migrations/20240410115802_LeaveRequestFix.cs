using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class LeaveRequestFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApplicationUserId",
                table: "LeaveRequests",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_Users_ApplicationUserId",
                table: "LeaveRequests",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_Users_ApplicationUserId",
                table: "LeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequests_ApplicationUserId",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "LeaveRequests");
        }
    }
}
