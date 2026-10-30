using GoldTracker.Domain.Enums;
using GoldTracker.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldTracker.Domain.Enitities
{
    public class GoldPriceEtlLogs
    {
        public GoldPriceEtlLogs()
        {
            Id = GuidV7.NewGuid();
            SourceId = Guid.Empty;
            Status = GoldPriceEtlStatus.Pending;
            ErrorMessage = string.Empty;
            BuyPrice = 0;
            SellPrice = 0;
            CreatedAt = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public Guid SourceId { get; set; }
        public GoldPriceEtlStatus Status { get; set; }
        public string ErrorMessage { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
