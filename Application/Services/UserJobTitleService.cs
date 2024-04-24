namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using Application.Interfaces.Auth;
  using Application.Interfaces.GenericInterfaces;
  using Domain.Account;
  using Domain.Dtos.General;
  using Domain.Dtos.JobTitles;
  using Domain.Enties;
  using Domain.Enums;
  using Microsoft.EntityFrameworkCore;
  using Persistence;
  using Persistence.Migrations;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Security.Claims;
  using System.Text;
  using System.Threading.Tasks;

  public class UserJobTitleService : IUserJobTitleService
  {
    private readonly DataContext dataContext;
    private readonly ILogService logService;

    public UserJobTitleService(DataContext dataContext,ILogService logService)
    {
      this.dataContext = dataContext;
      this.logService = logService;
    }

    public async Task<GeneralServiceResponseDto> AssignJobTitleToUser(ClaimsPrincipal User, string username, int jobTitleId)
    {
      var user = await dataContext.Users.FirstOrDefaultAsync(x => x.UserName == username);
      //assign the jobTitle id
      user.JobTitleId = jobTitleId;
      await dataContext.SaveChangesAsync();
      await logService.SaveNewLog(User.Identity.Name,"Assigned JobTitle");
      return ResponseHelper.CreateResponse(true,200,"JobTitle Assigned Successfully");
    }


    public Task<IEnumerable<ApplicationUser>> GetUsersByJobTitle(string title)
    {
      throw new NotImplementedException();
    }

    public async Task<JobTitleDto> GetJobTitleForUser(string username)
    {
      var user = await dataContext.Users.SingleAsync(u => u.UserName == username);

      // Check if JobTitleId is null before calling GetJobTitleInfo
      if (user.JobTitleId.HasValue)
      {
        var jobTitleInfo = await GetJobTitleInfo(user.JobTitleId.Value);
        return jobTitleInfo;
      }
      else
      {
        // Handle the case where JobTitleId is null
        // For example, return a default JobTitleDto or throw an exception
        throw new Exception("JobTitleId is null for the user.");
      }
    }
 


    //will get the jobTitle including department name
    private async Task<JobTitleDto> GetJobTitleInfo(int jobTitleId)
    {
      return await (from jobTitle in dataContext.JobTitles
                    join department in dataContext.Departments on jobTitle.DepartmentId equals department.Id
                    where jobTitle.Id == jobTitleId
                    select new JobTitleDto
                    {
                      Title = jobTitle.Title,
                      DepartmentName = department.DepartmentName,
                      Seniority = jobTitle.Seniority.ToString() // Assuming Seniority is an enum
                    }).FirstOrDefaultAsync();
    }
  }
}
