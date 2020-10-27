using System.Text.Json.Serialization;
using Travlr.TechnicalTest.Domain.Enums;

namespace Travlr.TechnicalTest.Domain
{
    public class Pax
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("nationalityIso")]
        public string NationalityIso { get; set; }

        [JsonPropertyName("gender")]
        public Gender Gender { get; set; }

        [JsonPropertyName("externalReference")]
        public string ExternalReference { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
