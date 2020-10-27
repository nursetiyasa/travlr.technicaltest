using System.Text.Json.Serialization;

namespace Travlr.TechnicalTest.Domain
{
    public class SearchResult
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Score")]
        public decimal Score { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("SupplierName")]
        public string SupplierName { get; set; }
        [JsonPropertyName("SupplierProductCode")]
        public string SupplierProductCode { get; set; }
        [JsonPropertyName("BranchName")]
        public string BranchName { get; set; }
        [JsonPropertyName("Category")]
        public int Category { get; set; }
        [JsonPropertyName("DurationInMinutes")]
        public int DurationInMinutes { get; set; }
        [JsonPropertyName("NumberOfNights")]
        public int NumberOfNights { get; set; }
        [JsonPropertyName("FormattedAddressName")]
        public string FormattedAddressName { get; set; }
        [JsonPropertyName("ShortDescription")]
        public string ShortDescription { get; set; }
        [JsonPropertyName("FullDescription")]
        public string FullDescription { get; set; }
    }
}
