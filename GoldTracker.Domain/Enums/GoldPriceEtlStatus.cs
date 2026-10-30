using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldTracker.Domain.Enums
{
    public enum GoldPriceEtlStatus
    {
        Success = 1,
        Failed = 2,
        Pending = 3
    }

    public static class GoldPriceEtlStatusExtensions
    {
        public static string ToFriendlyString(this GoldPriceEtlStatus status)
        {
            return status switch
            {
                GoldPriceEtlStatus.Success => "Success",
                GoldPriceEtlStatus.Failed => "Failed",
                GoldPriceEtlStatus.Pending => "Pending",
                _ => throw new ArgumentOutOfRangeException(nameof(status), status, null)
            };
        }
    }
}
