using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class LeaveAlloxatiobfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_Users_ApplicationUserId1",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_ApplicationUserId1",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "LeaveAllocations");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "LeaveAllocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_Users_ApplicationUserId",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_ApplicationUserId",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "LeaveAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "LeaveAllocations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_ApplicationUserId1",
                table: "LeaveAllocations",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_Users_ApplicationUserId1",
                table: "LeaveAllocations",
                column: "ApplicationUserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
