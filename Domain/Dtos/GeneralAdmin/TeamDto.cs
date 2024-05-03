namespace Domain.Dtos.GeneralAdmin
{
  using Domain.Account;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TeamDto
  {
    public int Id { get; set; }
    public string TeamName { get; set; }
    public List<MemberDetails> Members { get; set; } // Updated to include MemberDetails
  }
  public class MemberDetails
  {
    public string JobTitle { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}