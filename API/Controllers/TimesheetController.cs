namespace API.Controllers
{
  using Application.Interfaces;
  using Application.Services;
  using Domain.Dtos.LeaveRequest;
  using Domain.Dtos.Timesheet;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  [ApiController]
  public class TimesheetController : ControllerBase
  {
    private readonly ITimesheetService timesheetService;

    public TimesheetController(ITimesheetService timesheetService)
    {
      this.timesheetService = timesheetService;
    }
    [HttpPost]
    [Authorize]
    [Route("Create")]
    public async Task<IActionResult> CreateTimesheetEntry([FromBody] TimesheetEntryDto timesheetEntry)
    {
      var result = await timesheetService.TimesheetEntry(User, timesheetEntry);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }
  }
}