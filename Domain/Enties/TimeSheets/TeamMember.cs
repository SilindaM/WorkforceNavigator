namespace Domain.Enties.TimeSheets
{
  using Domain.Account;
  using Domain.Entities;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TeamMember : BaseEntity<int>
  {
    public ApplicationUser User { get; private set; }
    public Team Team { get; private set; }
    public string Role { get; private set; }
    public DateTime JoinedDate { get; private set; }
  }
}