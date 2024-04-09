namespace Application.Interfaces
{
  using Domain.Dtos.LeaveAllocation;
  using Domain.Enties.Leaves;
  using FluentResults;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public interface ILeaveAllocationService
  {
    Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocationsByEmployee(int employeeId);
    Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocations();
    Task<Result<List<EmployeeLeaveAllocationDto>>> GetLeaveAllocationsByLeaveType(int leaveTypeId);
    Task<Result<int>> CreateLeaveAllocation(int createLeaveAllocation);
  }
}
