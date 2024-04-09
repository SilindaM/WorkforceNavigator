namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using Application.Interfaces.Auth;
  using AutoMapper;
  using Domain.Dtos;
  using Domain.Dtos.General;
  using Domain.Dtos.LeaveAllocation;
  using Domain.Dtos.LeaveRequest;
  using Domain.Enties;
  using Domain.Enties.Leaves;
  using Domain.Enums;
  using FluentResults;
  using Microsoft.AspNetCore.Identity;
  using Microsoft.EntityFrameworkCore;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class LeaveAllocationService : ILeaveAllocationService
  {
    private readonly DataContext dataContext;
    private readonly ILogService logService;

    public LeaveAllocationService(DataContext dataContext,ILogService logService)
    {
      this.dataContext = dataContext;
      this.logService = logService;
    }

    public async Task<GeneralServiceResponseDto> CreateLeaveAllocation(string username)
    {
      // Retrieve the user based on the username
      var user = await dataContext.Users.FirstOrDefaultAsync(u => u.UserName == username);

      if (user == null)
      {
        return ResponseHelper.CreateResponse(false, 400, "User not found");
      }

      // Retrieve all leave types
      var leaveTypes = await dataContext.LeaveTypes.ToListAsync();

      // Create leave allocations for each leave type for the user
      var newAllocations = leaveTypes.Select(leaveType => new LeaveAllocation
      {
        Username =username, // Assuming there's an EmployeeId property in the User entity
        LeaveTypeId = leaveType.Id,
        NumberOfDays = leaveType.DefaultDays, // You may adjust this based on your leave type properties
                                              // ... other properties
      }).ToList();

      dataContext.LeaveAllocations.AddRange(newAllocations);
      await logService.SaveNewLog(username, "Leaves Allocated");
      await dataContext.SaveChangesAsync();

        return ResponseHelper.CreateResponse(true, 200, "LeaveAllocated Successfully");
    }



    //public async Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocationByLeaveType(int leaveTypeId)
    //{
    //  var allocation = await dataContext.LeaveAllocations
    //      .Where(z => z.LeaveTypeId == leaveTypeId)
    //      .FirstOrDefaultAsync();

    //  if (allocation is null)
    //  {
    //    return Result.Fail<List<EmployeeLeaveAllocationDto>>("No leaves for the leaveTypeId");
    //  }

    //  var leaveAllocations = dataContext.LeaveAllocations
    //      .Include(la => la.Employee)
    //      .Include(la => la.LeaveType)
    //      .Where(la => la.LeaveTypeId == leaveTypeId)
    //      .Select(la => new EmployeeLeaveAllocationDto
    //      {
    //        FirstName = la.Employee.FirstName,
    //        LastName = la.Employee.LastName,
    //        LeaveName = la.LeaveType.Name,
    //        NumberOfDays = la.NumberOfDays
    //      })
    //      .ToList();

    //  return Result.Ok(leaveAllocations);
    //}

    //public async Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocationsByEmployee(int employeeId)
    //{
    //  var employee = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == employeeId);
    //  if (employee == null)
    //  {
    //    return Result.Fail(UserError.NonExistingEmployee);
    //  }

    //  var leaveAllocations = await dataContext.LeaveAllocations
    //      .Include(x => x.Employee)
    //      .Include(x => x.LeaveType) // Include related LeaveType
    //      .Where(x => x.EmployeeId == employeeId) // Filter by employeeId
    //      .ToListAsync();

    //  // Map leave allocations to DTOs
    //  var leaveAllocationDtos = leaveAllocations.Select(x => new EmployeeLeaveAllocationDto
    //  {
    //    FirstName = x.Employee.FirstName,
    //    LastName = x.Employee.LastName,
    //    LeaveName = x.LeaveType.Name,
    //    NumberOfDays = x.NumberOfDays
    //    // Add other properties as needed
    //  }).ToList();

    //  return Result.Ok(leaveAllocationDtos);
    //}

    //public async Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocationsByLeaveType(int leaveTypeId)
    //{
    //  var leaveAllocations = await dataContext.LeaveAllocations
    //      .Where(x => x.LeaveTypeId == leaveTypeId).Include(x => x.Employee)
    //      .Select(x => new EmployeeLeaveAllocationDto
    //      {
    //        FirstName = x.Employee.FirstName,
    //        LastName = x.Employee.LastName,
    //        LeaveName = x.LeaveType.Name,
    //        NumberOfDays = x.NumberOfDays
    //      })
    //      .ToListAsync();

    //  if (leaveAllocations.Count == 0)
    //  {
    //    return Result.Fail<List<EmployeeLeaveAllocationDto>>("No leave allocations found for the specified leave type");
    //  }
    //  return Result.Ok(leaveAllocations);
    //}

    //public async Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocations()
    //{
    //  var leaveAllocations = await dataContext.LeaveAllocations
    //      .Include(la => la.Employee)
    //      .Include(la => la.LeaveType)
    //      .ToListAsync();

    //  if (leaveAllocations == null)
    //  {
    //    return Result.Fail<List<EmployeeLeaveAllocationDto>>("Failed to retrieve leave allocations from the database.");
    //  }

    //  var leaveAllocationDtos = new List<EmployeeLeaveAllocationDto>();
    //  foreach (var allocation in leaveAllocations)
    //  {
    //    var leaveAllocationDto = new EmployeeLeaveAllocationDto
    //    {
    //      FirstName = allocation.Employee.FirstName,
    //      LastName = allocation.Employee.LastName,
    //      NumberOfDays = allocation.NumberOfDays,
    //      LeaveName = allocation.LeaveType.Name
    //    };
    //    leaveAllocationDtos.Add(leaveAllocationDto);
    //  }

    //  return Result.Ok(leaveAllocationDtos);
    //}
  }
}