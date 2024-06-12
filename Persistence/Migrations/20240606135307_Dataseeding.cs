

namespace Persistence.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
  public partial class Dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "ClientName", "CreatedAt", "Email", "Fax", "IsActive", "IsDeleted", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Eskom Holdings SOC Ltd", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5439), "info@EskomHoldingsSOCLtd.com", "+27 11 123 4560", true, false, "+27 11 123 4560", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5449) },
                    { 2, "Sasol Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5476), "info@SasolLimited.com", "+27 11 123 4561", true, false, "+27 11 123 4561", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5476) },
                    { 3, "MTN Group Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5487), "info@MTNGroupLimited.com", "+27 11 123 4562", true, false, "+27 11 123 4562", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5487) },
                    { 4, "Naspers Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5496), "info@NaspersLimited.com", "+27 11 123 4563", true, false, "+27 11 123 4563", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5497) },
                    { 5, "Standard Bank Group Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5507), "info@StandardBankGroupLimited.com", "+27 11 123 4564", true, false, "+27 11 123 4564", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5508) },
                    { 6, "Shoprite Holdings Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5519), "info@ShopriteHoldingsLimited.com", "+27 11 123 4565", true, false, "+27 11 123 4565", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5520) },
                    { 7, "Absa Group Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5528), "info@AbsaGroupLimited.com", "+27 11 123 4566", true, false, "+27 11 123 4566", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5529) },
                    { 8, "Sibanye Stillwater Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5578), "info@SibanyeStillwaterLimited.com", "+27 11 123 4567", true, false, "+27 11 123 4567", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5579) },
                    { 9, "Anglo American Platinum Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5590), "info@AngloAmericanPlatinumLimited.com", "+27 11 123 4568", true, false, "+27 11 123 4568", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5590) },
                    { 10, "Vodacom Group Limited", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5601), "info@VodacomGroupLimited.com", "+27 11 123 4569", true, false, "+27 11 123 4569", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5601) }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DepartmentName", "Description", "IsActive", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5616), "Department 1", "Description for Department 1", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5617) },
                    { 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5627), "Department 2", "Description for Department 2", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5627) },
                    { 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5636), "Department 3", "Description for Department 3", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5636) },
                    { 4, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5643), "Department 4", "Description for Department 4", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5644) },
                    { 5, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5651), "Department 5", "Description for Department 5", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5651) },
                    { 6, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5659), "Department 6", "Description for Department 6", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5660) },
                    { 7, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5667), "Department 7", "Description for Department 7", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5667) },
                    { 8, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5675), "Department 8", "Description for Department 8", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5675) },
                    { 9, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5682), "Department 9", "Description for Department 9", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5683) },
                    { 10, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5691), "Department 10", "Description for Department 10", true, false, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5692) }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedAt", "DefaultDays", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5821), 10, true, false, "Sick", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5821) },
                    { 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5822), 20, true, false, "Annual", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5823) },
                    { 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5824), 5, true, false, "Family", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5824) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "IsDeleted", "TeamName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5841), "Description for Team 1", true, false, "Team 1", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5841) },
                    { 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5851), "Description for Team 2", true, false, "Team 2", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5851) },
                    { 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5859), "Description for Team 3", true, false, "Team 3", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5860) },
                    { 4, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5867), "Description for Team 4", true, false, "Team 4", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5867) },
                    { 5, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5875), "Description for Team 5", true, false, "Team 5", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5875) },
                    { 6, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5883), "Description for Team 6", true, false, "Team 6", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5884) },
                    { 7, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5891), "Description for Team 7", true, false, "Team 7", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5892) },
                    { 8, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5899), "Description for Team 8", true, false, "Team 8", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5899) },
                    { 9, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5906), "Description for Team 9", true, false, "Team 9", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5907) },
                    { 10, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5916), "Description for Team 10", true, false, "Team 10", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5917) }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Description", "IsActive", "IsDeleted", "Seniority", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5705), 1, "Description for Job Title 1", true, false, 0, "Job Title 1", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5706) },
                    { 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5715), 2, "Description for Job Title 2", true, false, 1, "Job Title 2", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5715) },
                    { 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5722), 3, "Description for Job Title 3", true, false, 2, "Job Title 3", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5723) },
                    { 4, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5730), 4, "Description for Job Title 4", true, false, 3, "Job Title 4", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5730) },
                    { 5, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5737), 5, "Description for Job Title 5", true, false, 0, "Job Title 5", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5738) },
                    { 6, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5779), 6, "Description for Job Title 6", true, false, 1, "Job Title 6", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5779) },
                    { 7, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5787), 7, "Description for Job Title 7", true, false, 2, "Job Title 7", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5787) },
                    { 8, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5794), 8, "Description for Job Title 8", true, false, 3, "Job Title 8", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5794) },
                    { 9, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5801), 9, "Description for Job Title 9", true, false, 0, "Job Title 9", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5802) },
                    { 10, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5810), 10, "Description for Job Title 10", true, false, 1, "Job Title 10", new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5810) }
                });

            migrationBuilder.InsertData(
                table: "LeaveAllocations",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsDeleted", "LeaveTypeId", "NumberOfDays", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6070), true, false, 1, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6071), "John" },
                    { 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6078), true, false, 2, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6078), "Jane" },
                    { 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6084), true, false, 3, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6084), "Mike" },
                    { 4, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6090), true, false, 1, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6090), "Sarah" },
                    { 5, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6096), true, false, 2, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6096), "David" },
                    { 6, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6103), true, false, 3, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6103), "Emily" },
                    { 7, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6109), true, false, 1, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6109), "Ryan" },
                    { 8, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6114), true, false, 2, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6115), "Lisa" },
                    { 9, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6120), true, false, 3, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6121), "Chris" },
                    { 10, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6147), true, false, 1, 20, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6148), "Jessica" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ClientId", "CreatedAt", "Description", "EndDate", "IsActive", "IsDeleted", "ProjectName", "StartDate", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5940), "Description of Project 1", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 1", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5941) },
                    { 2, 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5951), "Description of Project 2", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 2", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5951) },
                    { 3, 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5960), "Description of Project 3", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 3", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 3, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(5960) },
                    { 4, 4, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6002), "Description of Project 4", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 4", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6002) },
                    { 5, 5, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6011), "Description of Project 5", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 5", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6012) },
                    { 6, 6, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6022), "Description of Project 6", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 6", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6022) },
                    { 7, 7, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6030), "Description of Project 7", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 7", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6031) },
                    { 8, 8, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6039), "Description of Project 8", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 8", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6040) },
                    { 9, 9, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6049), "Description of Project 9", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 9", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 9, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6049) },
                    { 10, 10, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6059), "Description of Project 10", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 10", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(2024, 6, 6, 15, 53, 7, 60, DateTimeKind.Local).AddTicks(6060) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Projects");
        }
    }
}
