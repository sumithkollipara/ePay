using System.Diagnostics.CodeAnalysis;

namespace CustomerManagement.Infrastructure
{
    [ExcludeFromCodeCoverage]
    public class AppSettings
    {
        public string DataPruneThresholdHours { get; set; } = "12";
    }
}
