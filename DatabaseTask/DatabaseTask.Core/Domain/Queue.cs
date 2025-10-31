using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class Queue
    {
        [Key]
        public int Id { get; set; }
        public string RegDate { get; set; } = string.Empty;
        [ForeignKey("Child")]
        public int ChildId { get; set; }
        [ForeignKey("")]
        public int GroupId { get; set; }



    }
}
