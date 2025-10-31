using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public enum SupplyType
    { 
        Cement,
        Concrete,
        Wood,

    }
    public class Supplys
    {
        public Guid Id { get; set; }
        public string Unit { get; set; }
        public int PriceInBulk { get; set; }
        public Enum SupplyType { get; set; }


    }
}
