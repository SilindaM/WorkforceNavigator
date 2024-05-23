namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using AutoMapper;
  using Domain.Account;
  using Domain.Dtos.General;
  using Domain.Dtos.LeaveAllocation;
  using Domain.Dtos.Timesheet;
  using Domain.Entities.TimeSheets;
  using Microsoft.AspNetCore.Identity;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Security.Claims;
  using System.Text;
  using Application.Interfaces.GenericInterfaces;
  using System.Threading.Tasks;
  using Domain.Enties;
  using Domain.Dtos.GeneralAdmin;
  using Microsoft.EntityFrameworkCore;
  using AutoMapper.QueryableExtensions;
  using System.Data.Entity;

  public class TimesheetService : ITimesheetService
  {
    private readonly DataContext dataContext;
    private readonly IMapper mapper;
    private readonly IGenericService<Project, ProjectDto> genericService;

    public TimesheetService(DataContext dataContext, IMapper mapper, IGenericService<Project, ProjectDto> genericService)
    {
      this.dataContext = dataContext;
      this.mapper = mapper;
      this.genericService = genericService;
    }

    public Task<IEnumerable<LeaveAllocationDto>> GetLeaveAllocations()
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<GroupedTimesheetDetailDto>> GetTimesheetEntries(ClaimsPrincipal User, DateTime date)
    {
      var timesheetEntries = (from ts in dataContext.TimesheetEntries
                              join p in dataContext.Projects
                              on ts.ProjectId equals p.Id
                              where (ts.TimesheetDate == date) && (ts.Username == User.Identity.Name)
                              select new TimesheetDetailDto
                              {
                                TimesheetDate = ts.TimesheetDate,
                                Description = ts.Description,
                                ProjectName = p.ProjectName,
                                TimeSpent = ts.TimeSpent,
                                Username = ts.Username,
                              }).ToList();

      if (timesheetEntries == null)
      {
        return null;
      }
      var groupedEntries = timesheetEntries.GroupBy(x => x.Username)
                                  .Select(g => new GroupedTimesheetDetailDto
                                  {
                                    Username = g.Key,
                                    TimesheetDetails = g.ToList()
                                  });
      return groupedEntries;
    }

    public async Task<int> GetTotalTimeSpentByDate(ClaimsPrincipal user, DateTime date)
    {
      var username = user.Identity.Name;
      var timeSpent = dataContext.TimesheetEntries
                             .Where(t => t.TimesheetDate.Date == date.Date && t.Username == username)
                             .Sum(t => t.TimeSpent);
      return timeSpent;
    }

    public async Task<GeneralServiceResponseDto> TimesheetEntry(ClaimsPrincipal user, TimesheetCreateModifyDto timesheetEntryDto)
    {
      try
      {
        var username = user.Identity.Name;

        // Retrieve the project and ensure it exists
        var project = await genericService.GetByIdAsync(timesheetEntryDto.ProjectId);
        if (project == null)
        {
          return ResponseHelper.CreateResponse(false, 404, "Project not found.");
        }
        //user can insert many entry for a specific day as much as they are less than 8 hours
        var hourSpent = await GetTotalTimeSpentByDate(user, timesheetEntryDto.TimesheetDate);
        var updateHours = hourSpent +timesheetEntryDto.TimeSpent;

        if (hourSpent < 8 && updateHours <=8)
        {
          var timesheetEntry = new TimesheetCreateModifyDto
          {
            TimesheetDate = timesheetEntryDto.TimesheetDate,
            Description = timesheetEntryDto.Description,
            TimeSpent = timesheetEntryDto.TimeSpent,
            ProjectId = timesheetEntryDto.ProjectId
          };

          var map = mapper.Map<TimesheetEntry>(timesheetEntry);
          map.Username = username;
          dataContext.TimesheetEntries.Add(map);
          await dataContext.SaveChangesAsync();

          // Return a success response
          return ResponseHelper.CreateResponse(true, 200, "Timesheet entry successfully created.");
        }
        return ResponseHelper.CreateResponse(false, 501, "You can only work 8 hours per day " + "You have already worked " + hourSpent + "Hours");
      }
      catch (Exception ex)
      {
        return ResponseHelper.CreateResponse(false, 500, ex.Message);
      }
    }
  }
}