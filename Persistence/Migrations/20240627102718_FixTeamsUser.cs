using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FixTeamsUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5719), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5761), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6006), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6041), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6052), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6104), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6116), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6133), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6204), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6214), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6244), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6264), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6659), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6678), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6694), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6757), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6296), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6585), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6598), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6609), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6621), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6632), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6320), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6375), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6385), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6395), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6495), new DateTime(2024, 6, 27, 12, 27, 18, 180, DateTimeKind.Local).AddTicks(6496) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1151), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1218), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1258), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1278), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1344), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1524), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1586), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1601), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1673), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1751), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1919), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2486), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2501), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2554), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2577), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2588), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2638), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2004), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2237), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2275), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2392), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2410), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2426), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2443), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2462), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2041), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2062), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2078), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2127), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2157), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2173), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 6, 27, 12, 12, 46, 467, DateTimeKind.Local).AddTicks(2191) });
        }
    }
}
