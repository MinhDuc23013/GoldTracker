using GoldTracker.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldTracker.Domain.Enitities
{
    public class GoldPrice
    {
        public GoldPrice() { 
            Id = GuidV7.NewGuid();
            SourceId = Guid.Empty;
            ProductionId = Guid.Empty;
        }

        public Guid Id { get; set; }
        public Guid SourceId { get; set; }
        public Guid ProductionId { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime CreatedAt { get; set; }

        //thời điểm giá vàng được ghi nhận
        public DateTime RecordAt { get; set; }

    }
}
