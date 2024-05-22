namespace Application.Interfaces
{
  using Domain.Dtos.General;
  using Domain.Dtos.LeaveAllocation;
  using Domain.Dtos.Timesheet;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Security.Claims;
  using System.Text;
  using System.Threading.Tasks;

  public interface ITimesheetService
  {
    Task<GeneralServiceResponseDto> TimesheetEntry(ClaimsPrincipal User, TimesheetEntryDto TimesheetEntry);
    Task<IEnumerable<LeaveAllocationDto>> GetLeaveAllocations();
  }
}