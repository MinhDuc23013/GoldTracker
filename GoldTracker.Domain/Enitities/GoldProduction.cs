using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldTracker.Domain.Enitities
{
    public class GoldProduction
    {
        public GoldProduction() 
        {
            Name = string.Empty;
            Code = string.Empty;
            Unit = string.Empty;
        }
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public Decimal Purity { get; set; }
        public String Unit { get; set; }
    }
}
