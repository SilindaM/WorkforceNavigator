namespace Domain.Enties.TimeSheets
{
  using Domain.Entities;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class Project : BaseEntity<int>
  {
    public int ClientId { get; set; }
    public string ProjectName { get; set; }
    public int DeliveryTeamID { get; set; }
  }
}