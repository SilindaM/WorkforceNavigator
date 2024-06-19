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
    public string Description { get; set; }
  }
}