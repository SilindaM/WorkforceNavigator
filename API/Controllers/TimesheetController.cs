namespace API.Controllers
{
  using Application.Interfaces;
  using Application.Services;
  using Domain.Dtos.LeaveRequest;
  using Domain.Dtos.Timesheet;
  using Domain.Entities.TimeSheets;
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
    public async Task<IActionResult> CreateTimesheetEntry([FromBody] TimesheetCreateModifyDto timesheetEntry)
    {
      var result = await timesheetService.TimesheetEntry(User, timesheetEntry);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpGet]
    [Authorize]
    public async Task<ActionResult<IEnumerable<GroupedTimesheetDetailDto>>> GetTimeSheetByDate(DateTime date)
    {
      var timesheets = await timesheetService.GetTimesheetEntries(User,date);

      if (timesheets == null)
      {
        return NotFound(); // Return HTTP 404 Not Found if user not found
      }
      return Ok(timesheets);
    }
  }
}