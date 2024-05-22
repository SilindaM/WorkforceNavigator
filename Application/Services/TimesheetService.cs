namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using AutoMapper;
  using Domain.Account;
  using Domain.Dtos.General;
  using Domain.Dtos.LeaveAllocation;
  using Domain.Dtos.Timesheet;
  using Domain.Enties.TimeSheets;
  using Microsoft.AspNetCore.Identity;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Security.Claims;
  using System.Text;
  using System.Threading.Tasks;

  public class TimesheetService : ITimesheetService
  {
    private readonly DataContext dataContext;
    private readonly IMapper mapper;

    public TimesheetService(DataContext dataContext,IMapper mapper)
    {
      this.dataContext = dataContext;
      this.mapper = mapper;
    }

    public Task<IEnumerable<LeaveAllocationDto>> GetLeaveAllocations()
    {
      throw new NotImplementedException();
    }

    public async Task<GeneralServiceResponseDto> TimesheetEntry(ClaimsPrincipal User, TimesheetEntryDto TimesheetEntry)
    {
      var TimeEntry = new TimesheetEntryDto
      {
        Description = TimesheetEntry.Description,
        ProjectId = TimesheetEntry.ProjectId,
        TimesheetDate = TimesheetEntry.TimesheetDate,
        TimeSpent = TimesheetEntry.TimeSpent,
        Username = User.Identity.Name,
      };

      var destination = mapper.Map<TimesheetEntry>(TimeEntry);
      dataContext.TimesheetEntries.Add(destination);
      await dataContext.SaveChangesAsync();
      return ResponseHelper.CreateResponse(true, 200, "Timesheet Entry successfully");
    }
  }
}