using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultDays = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seniority = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitles_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    LineManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Seniority = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TimesheetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimesheetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeSpent = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimesheetEntries_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserToken_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "ClientName", "CreatedAt", "Email", "Fax", "IsActive", "IsDeleted", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Eskom Holdings SOC Ltd", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9904), "info@EskomHoldingsSOCLtd.com", "+27 11 123 4560", true, false, "+27 11 123 4560", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9913) },
                    { 2, "Sasol Limited", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9949), "info@SasolLimited.com", "+27 11 123 4561", true, false, "+27 11 123 4561", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9949) },
                    { 3, "MTN Group Limited", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9961), "info@MTNGroupLimited.com", "+27 11 123 4562", true, false, "+27 11 123 4562", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9961) },
                    { 4, "Naspers Limited", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9970), "info@NaspersLimited.com", "+27 11 123 4563", true, false, "+27 11 123 4563", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9971) },
                    { 5, "Standard Bank Group Limited", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9982), "info@StandardBankGroupLimited.com", "+27 11 123 4564", true, false, "+27 11 123 4564", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9982) },
                    { 6, "Shoprite Holdings Limited", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9997), "info@ShopriteHoldingsLimited.com", "+27 11 123 4565", true, false, "+27 11 123 4565", new DateTime(2024, 6, 6, 13, 23, 51, 103, DateTimeKind.Local).AddTicks(9998) },
                    { 7, "Absa Group Limited", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(8), "info@AbsaGroupLimited.com", "+27 11 123 4566", true, false, "+27 11 123 4566", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(8) },
                    { 8, "Sibanye Stillwater Limited", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(18), "info@SibanyeStillwaterLimited.com", "+27 11 123 4567", true, false, "+27 11 123 4567", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(19) },
                    { 9, "Anglo American Platinum Limited", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(28), "info@AngloAmericanPlatinumLimited.com", "+27 11 123 4568", true, false, "+27 11 123 4568", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(29) },
                    { 10, "Vodacom Group Limited", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(125), "info@VodacomGroupLimited.com", "+27 11 123 4569", true, false, "+27 11 123 4569", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(126) }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DepartmentName", "Description", "IsActive", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(150), "Department 1", "Description for Department 1", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(151) },
                    { 2, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(162), "Department 2", "Description for Department 2", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(163) },
                    { 3, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(171), "Department 3", "Description for Department 3", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(171) },
                    { 4, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(179), "Department 4", "Description for Department 4", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(179) },
                    { 5, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(187), "Department 5", "Description for Department 5", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(188) },
                    { 6, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(196), "Department 6", "Description for Department 6", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(197) },
                    { 7, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(204), "Department 7", "Description for Department 7", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(205) },
                    { 8, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(212), "Department 8", "Description for Department 8", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(213) },
                    { 9, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(220), "Department 9", "Description for Department 9", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(221) },
                    { 10, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(230), "Department 10", "Description for Department 10", true, false, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(231) }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedAt", "DefaultDays", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(384), 10, true, false, "Sick", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(385) },
                    { 2, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(386), 20, true, false, "Annual", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(386) },
                    { 3, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(387), 5, true, false, "Family", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(388) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "IsDeleted", "TeamName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(406), "Description for Team 1", true, false, "Team 1", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(407) },
                    { 2, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(417), "Description for Team 2", true, false, "Team 2", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(417) },
                    { 3, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(425), "Description for Team 3", true, false, "Team 3", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(426) },
                    { 4, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(433), "Description for Team 4", true, false, "Team 4", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(434) },
                    { 5, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(441), "Description for Team 5", true, false, "Team 5", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(442) },
                    { 6, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(451), "Description for Team 6", true, false, "Team 6", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(451) },
                    { 7, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(459), "Description for Team 7", true, false, "Team 7", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(459) },
                    { 8, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(467), "Description for Team 8", true, false, "Team 8", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(468) },
                    { 9, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(475), "Description for Team 9", true, false, "Team 9", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(476) },
                    { 10, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(485), "Description for Team 10", true, false, "Team 10", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(486) }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Description", "IsActive", "IsDeleted", "Seniority", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(250), 1, "Description for Job Title 1", true, false, 0, "Job Title 1", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(251) },
                    { 2, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(261), 2, "Description for Job Title 2", true, false, 1, "Job Title 2", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(261) },
                    { 3, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(269), 3, "Description for Job Title 3", true, false, 2, "Job Title 3", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(269) },
                    { 4, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(276), 4, "Description for Job Title 4", true, false, 3, "Job Title 4", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(277) },
                    { 5, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(285), 5, "Description for Job Title 5", true, false, 0, "Job Title 5", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(285) },
                    { 6, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(294), 6, "Description for Job Title 6", true, false, 1, "Job Title 6", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(295) },
                    { 7, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(302), 7, "Description for Job Title 7", true, false, 2, "Job Title 7", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(303) },
                    { 8, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(349), 8, "Description for Job Title 8", true, false, 3, "Job Title 8", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(350) },
                    { 9, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(359), 9, "Description for Job Title 9", true, false, 0, "Job Title 9", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(360) },
                    { 10, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(369), 10, "Description for Job Title 10", true, false, 1, "Job Title 10", new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(369) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ClientId", "CreatedAt", "Description", "EndDate", "IsActive", "IsDeleted", "ProjectName", "StartDate", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(513), "Description of Project 1", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 1", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(513) },
                    { 2, 2, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(525), "Description of Project 2", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 2", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(525) },
                    { 3, 3, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(534), "Description of Project 3", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 3", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 3, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(535) },
                    { 4, 4, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(544), "Description of Project 4", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 4", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(544) },
                    { 5, 5, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(553), "Description of Project 5", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 5", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(553) },
                    { 6, 6, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(604), "Description of Project 6", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 6", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(605) },
                    { 7, 7, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(615), "Description of Project 7", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 7", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(615) },
                    { 8, 8, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(624), "Description of Project 8", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 8", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(625) },
                    { 9, 9, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(634), "Description of Project 9", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 9", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 9, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(634) },
                    { 10, 10, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(645), "Description of Project 10", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Project 10", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(2024, 6, 6, 13, 23, 51, 104, DateTimeKind.Local).AddTicks(646) }
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_DepartmentId",
                table: "JobTitles",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApplicationUserId",
                table: "LeaveRequests",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetEntries_ProjectId",
                table: "TimesheetEntries",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_JobTitleId",
                table: "Users",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeamId",
                table: "Users",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TimesheetEntries");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
