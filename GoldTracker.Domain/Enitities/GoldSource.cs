using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldTracker.Domain.Enitities
{
    public class GoldSource
    {
        public GoldSource()
        {
            Name = string.Empty;
            WebsiteUrl = string.Empty;
        }
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String WebsiteUrl { get; set; }
        public Boolean IsActive { get; set; }
    }
}
