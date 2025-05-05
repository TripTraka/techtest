using System.Text.Json.Serialization;

namespace TechTestAspNet.Models
{
    public class CruiseData
    {
        [JsonPropertyName("Cruises")]
        public List<Cruise>? Cruises { get; set; }

        [JsonPropertyName("TotalCount")]
        public int TotalCount { get; set; }
    }
}
