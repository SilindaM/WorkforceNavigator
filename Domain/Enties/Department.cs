using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enties
{
    public class Department : BaseEntity<int>
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
    }
}
