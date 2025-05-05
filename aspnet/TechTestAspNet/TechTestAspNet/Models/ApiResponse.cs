using System.Text.Json.Serialization;

namespace TechTestAspNet.Models
{
    public class ApiResponse
    {
        [JsonPropertyName("Success")]
        public bool Success { get; set; }

        [JsonPropertyName("Message")]
        public string? Message { get; set; }

        [JsonPropertyName("StatusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("StatusDescription")]
        public string? StatusDescription { get; set; }

        [JsonPropertyName("Data")]
        public CruiseData? Data { get; set; }
    }
}
