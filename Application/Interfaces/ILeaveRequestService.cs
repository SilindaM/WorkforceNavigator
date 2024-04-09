namespace Application.Interfaces
{
  using System;
  using System.Collections.Generic;
  using System.Security.Claims;
  using System.Threading.Tasks;
  using Domain.Dtos.General;
  using Domain.Dtos.LeaveRequest;
  using Domain.Enums;
  using FluentResults;

  public interface ILeaveRequestService
  {
    //Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequests();
    ////Task<IEnumerable<LeaveRequestDto>> GetLeaveRequestsByEmployee(int employeeId);
    ////Task<IEnumerable<LeaveRequestDto>> GetLeaveRequestsById(int requestId);
    Task<GeneralServiceResponseDto> CreateLeaveRequest(ClaimsPrincipal User,CreateLeaveRequestDto createLeaveRequestDto);
    //Task<IEnumerable<GeneralServiceResponseDto>> UpdateLeaveRequest(ClaimsPrincipal User, int leaveRequestId, UpdateLeaveRequestDto updateLeaveRequestDto);
    //Task<IEnumerable<bool>> DeleteLeaveRequest(int leaveRequestId);
    //Task<IEnumerable<bool>> ProcessLeaveRequest(int leaveRequestId, Status status);
  }
}
//079 81 63 585