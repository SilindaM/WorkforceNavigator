namespace Domain.Dtos.Timesheet
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TimesheetEntryDto
  {
    public DateTime TimesheetDate { get; set; }
    public string Username { get; set; }
    public string Description { get; set; }
    public int TimeSpent { get; set; }
    public int ProjectId { get; set; }
  }
}