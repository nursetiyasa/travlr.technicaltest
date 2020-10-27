using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Travlr.TechnicalTest.Domain
{
    public class ProductResult
    {
        [JsonPropertyName("searchTime")]
        public decimal SearchTime { get; set; }

        [JsonPropertyName("numberResults")]
        public int NumberResults { get; set; }

        [JsonPropertyName("products")]
        public IEnumerable<Products> Products { get; set; }
    }
}
