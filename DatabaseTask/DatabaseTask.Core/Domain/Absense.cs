using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Absense
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Child")]
        public int ChildId { get; set; } 
        public string StartDate { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;

    }
}
