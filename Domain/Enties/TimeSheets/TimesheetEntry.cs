namespace Domain.Entities.TimeSheets
{
  using System;
  using System.ComponentModel.DataAnnotations.Schema;
  public class TimesheetEntry : BaseEntity<int>
  {
    public DateTime TimesheetDate { get;  set; } 
    public string Username { get; set; }
    public string Description { get; set; }
    public int TimeSpent { get; set; }
    public int ProjectId { get; set; }
  }
}