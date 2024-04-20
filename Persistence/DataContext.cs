
namespace Persistence
{
  using Domain.Account;
  using Domain.Enties;
  using Domain.Enties.Leaves;
  using Domain.Entities;
  using Microsoft.AspNetCore.Identity;
  using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
  using Microsoft.EntityFrameworkCore;
  using System.Reflection.Emit;
  using Department = Domain.Enties.Department;

  public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    public DbSet<Log> Logs { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      base.OnModelCreating(builder);

      builder.Entity<JobTitle>()
        .HasOne(x=>x.Department)
        .WithMany(c=> c.JobTitles)
        .HasForeignKey(x=>x.DepartmentId)
        .OnDelete(DeleteBehavior.Restrict);


      builder.Entity<LeaveRequest>()
       .HasKey(lr => lr.Id); // Assuming 'Id' is the primary key property

      builder.Entity<ApplicationUser>(e =>
      {
        e.ToTable("Users");
      });
      builder.Entity<IdentityUserClaim<string>>(e =>
      {
        e.ToTable("UserClaims");
      });
      builder.Entity<IdentityUserLogin<string>>(e =>
      {
        e.ToTable("UserLogins");
      });
      builder.Entity<IdentityUserToken<string>>(e =>
      {
        e.ToTable("UserToken");
      });

      builder.Entity<IdentityRole<string>>(e =>
      {
        e.ToTable("Roles");
      });

      builder.Entity<IdentityRoleClaim<string>>(e =>
      {
        e.ToTable("RoleClaims");
      });
    }
  }
}