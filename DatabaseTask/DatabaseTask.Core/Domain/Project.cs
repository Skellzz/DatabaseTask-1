using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public IEnumerable<Employee> EmployeeId { get; set; }
          = new List<Employee>(); 
        public DateTime StartDate { get; set;  }
        public DateTime EndDate { get; set;  }
        public int Budget { get; set; }
        public IEnumerable<Supplys> SupplyId { get; set; }
         = new List<Supplys>();


    }
}
