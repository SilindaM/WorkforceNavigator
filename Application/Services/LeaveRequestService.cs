namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using Application.Interfaces.Auth;
  using AutoMapper;
  using Domain.Account;
  using Domain.Dtos.Account;
  using Domain.Dtos.General;
  using Domain.Dtos.LeaveAllocation;
  using Domain.Dtos.LeaveRequest;
  using Domain.Enties.Leaves;
  using Domain.Entities;
  using Domain.Enums;
  using FluentResults;
  using Microsoft.AspNetCore.Identity;
  using Microsoft.EntityFrameworkCore;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Security.Claims;
  using System.Text;
  using System.Threading.Tasks;

  public class LeaveRequestService : ILeaveRequestService
  {
    private readonly DataContext dataContext;
    private readonly ILogService logService;

    public LeaveRequestService(DataContext dataContext,ILogService logService)
    {
      this.dataContext = dataContext;
      this.logService = logService;
    }

    public async Task<GeneralServiceResponseDto> CreateLeaveRequest(ClaimsPrincipal user, CreateLeaveRequestDto createLeaveRequestDto)
    {
      // Check if the start date is before today
      if (createLeaveRequestDto.StartDate.Date <= DateTime.Today)
      {
        return (GeneralServiceResponseDto)ResponseHelper.CreateResponse(false, 400, "Leave cannot start before today");
      }

      int requestedDays = (int)(createLeaveRequestDto.EndDate.Date - createLeaveRequestDto.StartDate.Date).TotalDays + 1;

      // Check if requested days are greater than zero
      if (requestedDays <= 0)
      {
        return (GeneralServiceResponseDto)ResponseHelper.CreateResponse(false, 400, "Invalid number of days requested");
      }

      var allocation = await dataContext.LeaveAllocations
          .Where(x => x.Username == user.Identity.Name && x.LeaveType.Id == createLeaveRequestDto.LeaveTypeId)
          .FirstOrDefaultAsync();

      if (allocation == null)
      {
        return (GeneralServiceResponseDto)ResponseHelper.CreateResponse(false, 400, "Leave Type not allocated for the user");
      }

      if (requestedDays > allocation.NumberOfDays)
      {
        return (GeneralServiceResponseDto)ResponseHelper.CreateResponse(false, 400, "You don't have enough days for the applied leave");
      }
      // Check for overlapping leave requests within the specified range
      var overlappingLeave = await CheckForOverlappingLeaveRequest(user,createLeaveRequestDto);

      if (overlappingLeave != null)
      {
        return (GeneralServiceResponseDto)ResponseHelper.CreateResponse(false, 400, "Leave request overlaps with an existing leave request");
      }

      //var name = this.userManager.FindByNameAsync(user.Identity.Name);
      // Create the leave request
      var newLeaveRequest = new LeaveRequest
      {
        LeaveTypeId = createLeaveRequestDto.LeaveTypeId,
        StartDate = createLeaveRequestDto.StartDate,
        EndDate = createLeaveRequestDto.EndDate,
        NumberOfDays = requestedDays,
        UserName = user.Identity.Name,
        Status=Status.Pending,
        DateRequested = DateTime.Now,
        RequestComments =""
      };
      // Save the leave request to the database
      dataContext.LeaveRequests.Add(newLeaveRequest);
      await dataContext.SaveChangesAsync();

      dataContext.LeaveAllocations.Update(allocation);
      await DeductLeaveDays(user, createLeaveRequestDto.LeaveTypeId, requestedDays);
      await logService.SaveNewLog(user.Identity.Name, "Leave Request");
      await dataContext.SaveChangesAsync();

      return (GeneralServiceResponseDto)ResponseHelper.CreateResponse(true, 200, "LeaveRequestCreatedSuccessfully"); // Return the created leave request DTO
    }
    //    public async Task<IEnumerable<bool>> DeleteLeaveRequest(ClaimsPrincipal User,int leaveRequestId)
    //    {
    //      try
    //      {
    //        // Attempt to find the leave request with the given ID
    //        var leaveRequest = await dataContext.LeaveRequests
    //            .Include(lr => lr.UserName) // Include related entities if needed
    //            .Include(lr => lr.LeaveType) // Include related entities if needed
    //            .FirstOrDefaultAsync(lr => lr.Id == leaveRequestId);

    //        if (leaveRequest == null)
    //        {
    //          // Leave request not found
    //          return (IEnumerable<bool>)ResponseHelper.CreateResponse(false, 400, "Leave request not found.");
    //        }

    //        // Mark the leave request as deleted
    //        leaveRequest.IsDeleted = true;
    //        await AddLeaveDays(User.Identity.Name, leaveRequest.LeaveType.Id, leaveRequest.NumberOfDays);

    //        // Save changes to the database
    //        await dataContext.SaveChangesAsync();

    //        // Return success result
    //        return (IEnumerable<bool>)ResponseHelper.CreateResponse(false, 400, "Delete Successfully");
    //      }
    //      catch (Exception ex)
    //      {
    //        // Log the exception or handle it as needed
    //        return (IEnumerable<bool>)ResponseHelper.CreateResponse(false, 400,ex.Message);
    //      }
    //    }

    //    public async Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequests()
    //    {
    //      var leaveRequests = await dataContext.LeaveRequests
    //         .Include(la => la.ApplicationUser)
    //         .Include(la => la.LeaveType)
    //         .Where(la => la.IsDeleted == false)
    //         .ToListAsync();

    //      if (leaveRequests == null)
    //      {
    //        return (IEnumerable<LeaveRequestDto>)ResponseHelper.CreateResponse(false, 400, "Failed to retrieve leave allocations from the database.");
    //      }

    //      var leaveRequestDtos = new List<LeaveRequestDto>();

    //      foreach (var request in leaveRequests)
    //      {
    //        var leaveRequestDto = new LeaveRequestDto
    //        {
    //          FirstName = request.ApplicationUser.FirstName,
    //          LastName = request.ApplicationUser.LastName,
    //          NumberOfDays = request.NumberOfDays,
    //          LeaveName = request.LeaveType.Name,
    //          StartDate = request.StartDate,
    //          EndDate = request.EndDate,
    //          Status = request.Status
    //        };
    //        leaveRequestDtos.Add(leaveRequestDto);
    //      }
    //      return mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);

    //    }

    //    public async Task<IEnumerable<LeaveRequestDto>> GetLeaveRequestsByEmployee(int employeeId)
    //{
    //    var leaveRequests = await dataContext.LeaveRequests
    //        .Include(la => la.ApplicationUser)
    //        .Include(la => la.LeaveType)
    //        .Where(la => la.ApplicationUserId == employeeId && la.IsDeleted == false)
    //        .ToListAsync();

    //    var leaveRequestDtos = leaveRequests.Select(lr => new LeaveRequestDto
    //    {
    //        FirstName = lr.ApplicationUser.FirstName,
    //        LastName = lr.ApplicationUser.LastName,
    //        NumberOfDays = lr.NumberOfDays,
    //        LeaveName = lr.LeaveType.Name,
    //        StartDate = lr.StartDate,
    //        EndDate = lr.EndDate,
    //        Status = lr.Status
    //    });

    //    return leaveRequestDtos;
    //}

    //    public async Task<IEnumerable<LeaveRequestDto>> GetLeaveRequestsById(int requestId)
    //    {
    //      var requests = await dataContext.LeaveRequests
    //        .Where(z => z.Id == requestId)
    //        .FirstOrDefaultAsync();

    //      if (requests is null)
    //      {
    //        return (IEnumerable<LeaveRequestDto>)ResponseHelper.CreateResponse(false, 400, "No leaves for the requestId");
    //      }
    //      var leaveRequests = dataContext.LeaveRequests
    //          .Include(la => la.ApplicationUser)
    //          .Include(la => la.LeaveType)
    //          .Where(la => la.Id == requestId)
    //          .Select(la => new LeaveRequestDto
    //          {
    //            FirstName = la.ApplicationUser.FirstName,
    //            LastName = la.ApplicationUser.LastName,
    //            LeaveName = la.LeaveType.Name,
    //            NumberOfDays = la.NumberOfDays
    //          })
    //      .ToList();

    //      return mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);
    //    }
    //    public async Task<IEnumerable<bool>> ProcessLeaveRequest(int leaveRequestId, Status status)
    //    {
    //      // Fetch the actual entity from the database
    //      var leaveRequestEntity = await dataContext.LeaveRequests.FindAsync(leaveRequestId);
    //      if (leaveRequestEntity == null )
    //      {
    //        // If the entity is null or IsDeleted is true, return an appropriate error message
    //        return (IEnumerable<bool>)ResponseHelper.CreateResponse(false, 400, "Leave request not found.");
    //      }
    //      if (leaveRequestEntity.IsDeleted == true)
    //      {
    //        // If the entity is null or IsDeleted is true, return an appropriate error message
    //        return (IEnumerable<bool>)ResponseHelper.CreateResponse(false, 400, "The leave request has been deleted and cannot be processed.");
    //      }

    //      // Update the status of the entity
    //      leaveRequestEntity.Status = status;
    //      //get the employeeId
    //      var leaveRequestDetails = await dataContext.LeaveRequests
    //     .Include(la => la.ApplicationUser)
    //     .Where(lr => lr.Id == leaveRequestId) // Correctly filter by leaveRequestId
    //     .Select(x => new { x.UserName, x.LeaveType.Id, x.NumberOfDays })
    //     .SingleOrDefaultAsync();


    //      if (status == Status.Declined)
    //      {
    //        await AddLeaveDays(leaveRequestDetails.UserName, leaveRequestDetails.Id, leaveRequestEntity.NumberOfDays);
    //      }
    //      else if (status == Status.Approved)
    //      {
    //        await DeductLeaveDays(leaveRequestDetails.ApplicationUserId, leaveRequestDetails.Id, leaveRequestEntity.NumberOfDays);
    //      }
    //      // Save the updated entity to the database
    //      await dataContext.SaveChangesAsync();

    //      return (IEnumerable<bool>)ResponseHelper.CreateResponse(true, 200, "Leave Processes Succesasfully");
    //    }


    //    public async Task<IEnumerable<GeneralServiceResponseDto>> UpdateLeaveRequest(ClaimsPrincipal user, int leaveRequestId, UpdateLeaveRequestDto updateLeaveRequestDto)
    //    {
    //      // Get the original leave request
    //      var leaveRequest = await dataContext.LeaveRequests.FindAsync(leaveRequestId);
    //      if (leaveRequest == null)
    //      {
    //        return (IEnumerable<GeneralServiceResponseDto>)ResponseHelper.CreateResponse(true, 200, "Leave request not found");
    //      }

    //      // Check if available days are sufficient
    //      var result = await CheckAvailableDays(leaveRequest.ApplicationUserId, updateLeaveRequestDto.StartDate, updateLeaveRequestDto.EndDate);
    //      if (!result.IsSuccess)
    //      {
    //        return (IEnumerable<GeneralServiceResponseDto>)ResponseHelper.CreateResponse(true, 200, result.Errors.First().Message);
    //      }
    //      // Check for overlapping leave requests within the specified range
    //      CreateLeaveRequestDto requestDto = new CreateLeaveRequestDto
    //      {
    //        ApplicationUserId = dataContext.Users
    //    .Where(user => user.UserName.Equals(user.UserName))
    //    .Select(user => user.Id)
    //    .FirstOrDefault(),
    //      StartDate = updateLeaveRequestDto.StartDate,
    //        EndDate = updateLeaveRequestDto.EndDate,
    //        LeaveTypeId = leaveRequest.LeaveType.Id,
    //        NumberOfDays = leaveRequest.NumberOfDays,
    //      };
    //      var overlappingLeave = await CheckForOverlappingLeaveRequest(requestDto);

    //      if (overlappingLeave != null)
    //      {
    //        return (IEnumerable<GeneralServiceResponseDto>)ResponseHelper.CreateResponse(true, 200, "Leave Overlaps With Existing Leave Application");
    //      }

    //      // Subtract number of days from allocation
    //      await AddLeaveDays(leaveRequest.ApplicationUserId, leaveRequest.LeaveType.Id, leaveRequest.NumberOfDays);
    //      // Update the leave request
    //      leaveRequest.StartDate = updateLeaveRequestDto.StartDate;
    //      leaveRequest.EndDate = updateLeaveRequestDto.EndDate;
    //      leaveRequest.Status = Status.Pending;

    //      dataContext.LeaveRequests.Update(leaveRequest);
    //      await dataContext.SaveChangesAsync();

    //      return (IEnumerable<GeneralServiceResponseDto>)ResponseHelper.CreateResponse(true, 200, "Leave updated successfully");
    //    }
    //    private async Task<Result> CheckAvailableDays(int employeeId, DateTime startDate, DateTime endDate)
    //    {
    //      var allocation = await dataContext.LeaveAllocations
    //          .Where(x => x.ApplicationUserId == employeeId)
    //          .FirstOrDefaultAsync();

    //      if (allocation == null)
    //      {
    //        return Result.Fail("Leave Type not allocated for the user");
    //      }

    //      int requestedDays = (int)(endDate - startDate).TotalDays;

    //      if (requestedDays > allocation.NumberOfDays)
    //      {
    //        return Result.Fail("You don't have enough days for the applied leave");
    //      }

    //      return Result.Ok();
    //    }
    private async Task<LeaveRequest> CheckForOverlappingLeaveRequest(ClaimsPrincipal user,CreateLeaveRequestDto createLeaveRequestDto)
    {
      // Check for overlapping leave requests within the specified range
      var overlaps = await this.dataContext.LeaveRequests
          .Where(x => x.UserName.Equals(user.Identity.Name) &&
                      x.LeaveType.Id == createLeaveRequestDto.LeaveTypeId &&
                      ((x.StartDate <= createLeaveRequestDto.StartDate && x.EndDate >= createLeaveRequestDto.StartDate) ||
                       (x.StartDate <= createLeaveRequestDto.EndDate && x.EndDate >= createLeaveRequestDto.EndDate)))
          .FirstOrDefaultAsync();
      return overlaps;
    }
    private async Task<Result> DeductLeaveDays(ClaimsPrincipal user, int leaveTypeId, int days)
    {
      var allocation = await dataContext.LeaveAllocations
          .Where(x => x.Username == user.Identity.Name && x.LeaveType.Id == leaveTypeId)
          .FirstOrDefaultAsync();

      if (allocation == null)
      {
        return Result.Fail("Leave Type not allocated for the user");
      }

      allocation.NumberOfDays -= days;
      dataContext.LeaveAllocations.Update(allocation);
      await dataContext.SaveChangesAsync();

      return Result.Ok();
    }
    //    private async Task<Result<int>> AddLeaveDays(string UserName, int leaveTypeId, int days)
    //    {
    //      var allocation = await dataContext.LeaveAllocations
    //          .Where(x => x.ApplicationUserId == employeeId && x.LeaveType.Id == leaveTypeId)
    //          .FirstOrDefaultAsync();

    //      if (allocation == null)
    //      {
    //        return Result.Fail<int>("Leave Type not allocated for the user");
    //      }

    //      allocation.NumberOfDays += days; // Add days back to the allocation
    //      dataContext.LeaveAllocations.Update(allocation);
    //      await dataContext.SaveChangesAsync();

    //      return Result.Ok(allocation.NumberOfDays); // Return the updated number of days
    //    }
  }
}