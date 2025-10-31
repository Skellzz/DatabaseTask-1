using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{

    public class Supplys
    {
        public Guid Id { get; set; }
        public string Unit { get; set; } = string.Empty;
        public int PriceInBulk { get; set; }
        public string SupplyType { get; set; } = string.Empty;


    }
}
