using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class ChildGroupHistory
    {
        [Key]
        public int Id { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        [ForeignKey("Child")]
        public int ChildId { get; set; }

    }
}
