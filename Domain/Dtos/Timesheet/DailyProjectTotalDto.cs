namespace Domain.Dtos.Timesheet
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  public class DailyProjectTotalDto
  {
    public DateTime Date { get; set; }
    public int TotalHours { get; set; }
    public string DayName { get; set; }
    public HashSet<string> ProjectNames { get; set; }
  }

}