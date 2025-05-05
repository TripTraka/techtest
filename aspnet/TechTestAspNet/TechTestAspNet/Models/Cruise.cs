using System.Text.Json.Serialization;

namespace TechTestAspNet.Models
{
    public class Cruise
    {
        [JsonPropertyName("Trip_Key")]
        public string? TripKey { get; set; }

        [JsonPropertyName("TripName")]
        public string? TripName { get; set; }

        [JsonPropertyName("ItineraryKey")]
        public string? ItineraryKey { get; set; }

        [JsonPropertyName("ItineraryName")]
        public string? ItineraryName { get; set; }

        [JsonPropertyName("StartDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("EmbarkationPort")]
        public string? EmbarkationPort { get; set; }

        [JsonPropertyName("ShipKey")]
        public string? ShipKey { get; set; }

        [JsonPropertyName("Ship")]
        public string? Ship { get; set; }

        [JsonPropertyName("Terms")]
        public string? Terms { get; set; }

        [JsonPropertyName("Inclusions")]
        public string? Inclusions { get; set; }

        [JsonPropertyName("EmbarkationDateShort")]
        public string? EmbarkationDateShort { get; set; }

        [JsonPropertyName("EmbarkationDateLong")]
        public string? EmbarkationDateLong { get; set; }

        [JsonPropertyName("ShowLandPackages")]
        public bool ShowLandPackages { get; set; }
    }
}
