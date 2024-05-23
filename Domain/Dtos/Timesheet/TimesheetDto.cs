namespace Domain.Dtos.Timesheet
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Text.Json.Serialization;
  using System.Threading.Tasks;

  public class TimesheetDto
  {
    public DateTime TimesheetDate { get; set; }
    public string Description { get; set; }
    public int TimeSpent { get; set; }
    public int ProjectId { get; set; }
  }
}