using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class BuildingCompany
    {
        [Key]
        public Guid Id { get; set; }
        public int NumberOfEmployees { get; set; }
        public int Income { get; set; }
        public int NumberOfProjects { get; set; }
        public IEnumerable<Employee> EmployeeId { get; set; }
          = new List<Employee>();
        public IEnumerable<Project> ProjectId { get; set; }
          = new List<Project>();

    }
}
