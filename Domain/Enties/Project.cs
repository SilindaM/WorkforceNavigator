﻿
namespace Domain.Enties
{
  using Domain.Enties.TimeSheets;
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
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Client Client { get; set; }
  }
}