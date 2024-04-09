using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class IAdduswernamel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_Users_ApplicationUserId1",
                table: "LeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequests_ApplicationUserId1",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "LeaveRequests");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "UserName",
                table: "LeaveRequests");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApplicationUserId1",
                table: "LeaveRequests",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_Users_ApplicationUserId1",
                table: "LeaveRequests",
                column: "ApplicationUserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
