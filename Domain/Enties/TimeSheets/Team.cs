namespace Domain.Enties.TimeSheets
{
  using Domain.Account;
  using Domain.Entities;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class Team : BaseEntity<int>
  {
    public string TeamName { get; set; }
    public string Description { get; set; }
    public TeamMember? TeamMembers { get; set; }
  }
}