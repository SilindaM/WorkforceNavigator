namespace Persistence.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
  public partial class Initial : Migration
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
          name: "Projects",
          columns: table => new
          {
            Id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            ClientId = table.Column<int>(type: "int", nullable: false),
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
