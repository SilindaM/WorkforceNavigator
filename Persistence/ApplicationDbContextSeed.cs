
namespace Persistence
{
  using Domain.Enties.Leaves;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public static class ApplicationDbContextSeed
  {
    public static async Task SeedAsync(DataContext context)
    {
      // Ensure the database is created
      context.Database.EnsureCreated();

      // Seed LeaveTypes
      if (!context.LeaveTypes.Any())
      {
        context.LeaveTypes.AddRange(
            new LeaveType { Name = "Sick", DefaultDays = 30, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsActive = true, IsDeleted = false },
            new LeaveType { Name = "Annual", DefaultDays = 15, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsActive = true, IsDeleted = false },
            new LeaveType { Name = "Study", DefaultDays = 8, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsActive = true, IsDeleted = false },
            new LeaveType { Name = "Family", DefaultDays = 7, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsActive = true, IsDeleted = false }
        );
        await context.SaveChangesAsync();
      }
    }
  }
}