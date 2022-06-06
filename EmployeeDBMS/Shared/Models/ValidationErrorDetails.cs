using System.Text.Json.Serialization;

namespace EmployeeDBMS.Shared.Models
{
    public class ValidationErrorDetails
    {
        [JsonPropertyName("errors")]
        public IDictionary<string, string[]>? Errors { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("status")]
        public int? Status { get; set; }

        [JsonPropertyName("traceId")]
        public string? TraceId { get; set; }
    }
}
