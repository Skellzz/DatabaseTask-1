using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Machine
    {
        public Guid Id { get; set; }
        public IEnumerable<Employee> EmployeeId { get; set; }
            = new List<Employee>();
        public IEnumerable<Employee> EmployeeName { get; set; }
            = new List<Employee>();
        public string MachineType { get; set; } = string.Empty;
        public int NumberOfMachines { get; set; }
        public string MachineCondition { get; set; } = string.Empty;


    }
}
