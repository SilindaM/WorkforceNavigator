﻿namespace Domain.Dtos.Timesheet
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TimesheetDetailDto
  {
    public string Description { get; set; }
    public int TimeSpent { get; set; }
    public string ProjectName { get; set; }
  }
  public class GroupedTimesheetDetailDto
  {
    public DateTime TimesheetDate { get; set; }
    public string Username { get; set; }
    public List<TimesheetDetailDto> TimesheetDetails { get; set; }
  }
}