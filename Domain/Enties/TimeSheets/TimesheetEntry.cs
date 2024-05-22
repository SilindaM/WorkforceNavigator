namespace Domain.Enties.TimeSheets
{
  using Domain.Entities;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TimesheetEntry : BaseEntity<int>
  {
    public DateTime TimesheetDate {
      get => TimesheetDate;
      set
      {
        // Ensure that the TimesheetDate falls within Monday to Friday of the current week
        if (value.DayOfWeek >= DayOfWeek.Monday && value.DayOfWeek <= DayOfWeek.Friday)
        {
          TimesheetDate = value.Date; // Ensure only the date part is used
        }
        else
        {
          throw new ArgumentException("TimesheetDate must be between Monday and Friday of the current week.");
        }
      }
    
    }
    public string Username { get; set; }
    public string Description { get; set; }
    public int TimeSpent { get; set; }
    public int ProjectId { get; set; }
  }
}