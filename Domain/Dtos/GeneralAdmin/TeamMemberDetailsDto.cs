namespace Domain.Dtos.GeneralAdmin
{
  using Domain.Enties.TimeSheets;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TeamMemberDetailsDto
  {
    public string TeamName { get; set; }
    public List<MemberDetails> MemberDetails { get; set; }
  }
  public class MemberDetails
  {
    public string FirstName { get; set;}
    public string LastName { get; set; }
    public string? JobTitle { get; set; }
  }
}