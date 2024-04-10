
namespace API.Controllers
{
  using Application.Interfaces;
  using Domain.Dtos.LeaveRequest;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Mvc;
  using Domain.Dtos.Account;
  using Application.Services.Auth;
  using Domain.Constants;
  using Application.Services;
  using Domain.Dtos.LeaveAllocation;
  using Application.Interfaces.Auth;
  using Domain.Enums;

  [ApiController]
  [Route("api/[controller]")]
  public class LeaveRequestController : ControllerBase
  {
    private readonly ILeaveRequestService leaveRequestService;

    public LeaveRequestController(ILeaveRequestService leaveRequestService)
    {
      this.leaveRequestService = leaveRequestService;
    }

    //[HttpGet]
    //public async Task<ActionResult<IEnumerable<LeaveRequestDto>>> GetLeaveRequests()
    //{
    //  var logs = await leaveRequestService.GetAllLeaveRequests();
    //  return Ok(logs);
    //}
    [HttpPost]
    [Authorize]
    [Route("Create")]
    public async Task<IActionResult> CreateLeaveRequest([FromBody] CreateLeaveRequestDto createLeave)
    {
      var result = await leaveRequestService.CreateLeaveRequest(User,createLeave);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }
    [HttpGet]
    [Route("LeaveRequests")]
    public async Task<ActionResult<IEnumerable<LeaveRequestDto>>> GetLeaveRequests()
    {
      var leaveRequests = await leaveRequestService.GetAllLeaveRequests();
      return Ok(leaveRequests);
    }
    [HttpGet]
    [Route("LeaveRequestsByUsereName")]
    public async Task<ActionResult<IEnumerable<EmployeeLeaveAllocationDto>>> GetUserAllocationByUserNamesync(string userName)
    {
      var leaveRequests = await leaveRequestService.GetLeaveRequestsByUser(userName);

      if (leaveRequests == null)
      {
        return NotFound(); // Return HTTP 404 Not Found if user not found
      }

      return Ok(leaveRequests); // Return HTTP 200 OK with the allocations
    }
    [HttpGet]
    [Route("LeaveRequest/{requestId}")]
    public async Task<ActionResult<LeaveRequestDto>> GetLeaveRequestById([FromRoute] int requestId)
    {
      var leaveRequests = await leaveRequestService.GetLeaveRequestsById(requestId);
      if (leaveRequests is null)
      {
        return NotFound("leaveRequestId not found");
      }
      else
      {
        return Ok(leaveRequests);
      }
    }
    [HttpPost]
    [Route("UpdateLeaveRequest")]
    [Authorize(Roles = StaticUserRoles.ADMIN)]
    public async Task<IActionResult> UpdateLeaveRequest(int leaveRequestId, [FromBody] UpdateLeaveRequestDto updateLeaveRequestDto)
    {
      var updateLeaveRequest = await leaveRequestService.UpdateLeaveRequest(User, leaveRequestId, updateLeaveRequestDto);
      if (updateLeaveRequest.IsSucceed)
      {
        return Ok(updateLeaveRequest.Message);
      }
      else
      {
        return StatusCode(updateLeaveRequest.StatusCode, updateLeaveRequest.Message);
      }
    }
    [HttpPost]
    [Route("ProcessLeaveRequest")]
    [Authorize(Roles = StaticUserRoles.ADMIN)]
    public async Task<IActionResult> ProcessLeaveRequest(int leaveRequestId, [FromBody] Status status)
    {
      var processLeaveRequest = await leaveRequestService.ProcessLeaveRequest(User, leaveRequestId, status);
      if (processLeaveRequest.IsSucceed)
      {
        return Ok(processLeaveRequest.Message);
      }
      else
      {
        return StatusCode(processLeaveRequest.StatusCode, processLeaveRequest.Message);
      }
    }
    [HttpPost]
    [Route("deleteLeaveRequest")]
    [Authorize(Roles = StaticUserRoles.ADMIN)]
    public async Task<IActionResult> DeleteLeaveRequest(int leaveRequestId)
    {
      var deleteLeaveRequest = await leaveRequestService.DeleteLeaveRequest(User, leaveRequestId);
      if (deleteLeaveRequest.IsSucceed)
      {
        return Ok(deleteLeaveRequest.Message);
      }
      else
      {
        return StatusCode(deleteLeaveRequest.StatusCode, deleteLeaveRequest.Message);
      }
    }
  }
}