using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FixProjedcttui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamLeader",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(6883), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7147), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7289), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7322), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7358), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7403), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7468), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7585), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7613), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7723), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7966), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7994), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8026), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8054), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8108), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9027), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9079), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9252), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9279), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8884), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8918), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8989), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8240), "John", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8277), "Jane", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8307), "Mike", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8337), "Sarah", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8366), "David", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8399), "Emily", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8519), "Ryan", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8550), "Lisa", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8579), "Chris", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TeamLeader", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8613), "Jessica", new DateTime(2024, 6, 25, 14, 12, 44, 689, DateTimeKind.Local).AddTicks(8614) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamLeader",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9840), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9850), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 6, 6, 16, 1, 3, 920, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(146), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(155), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(164), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(171), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(188), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(491), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(497), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(546), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(558), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(564), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(371), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(404), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(413), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(424), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(227), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(238), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 6, 6, 16, 1, 3, 921, DateTimeKind.Local).AddTicks(343) });
        }
    }
}
