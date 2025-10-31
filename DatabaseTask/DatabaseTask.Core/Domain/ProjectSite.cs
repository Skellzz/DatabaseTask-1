using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    
    public class ProjectSite
    {
        public Guid Id { get; set; }

        public IEnumerable<Project> ProjectId { get; set; }
         = new List<Project>();

        public string Aadress { get; set; } = string.Empty;

        public string Area { get; set; } = string.Empty;

        public string ProjectType { get; set; } = string.Empty;

        public IEnumerable<Machine> MachineId { get; set; }
            = new List<Machine>();

    }
}
