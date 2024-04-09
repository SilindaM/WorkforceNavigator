namespace Domain.Dtos.LeaveAllocation
{
  using Domain.Enties.Leaves;
  using Domain.Enties;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using Domain.Enums;
  using Domain.Account;

  public class LeaveAllocationDto
  {
    public int NumberOfDays { get; set; }

    //public LeaveType? LeaveType { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    public string ApplicationUserId { get; set; }
  }
}
