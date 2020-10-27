using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Travlr.TechnicalTest.Domain
{
    public class Booking
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("created")]
        public string Created { get; set; }

        [JsonPropertyName("rrp")]
        public decimal Rrp { get; set; }

        [JsonPropertyName("paid")]
        public decimal Paid { get; set; }

        [JsonPropertyName("payable")]
        public decimal Payable { get; set; }

        [JsonPropertyName("commission")]
        public decimal Commission { get; set; }

        [JsonPropertyName("adjustment")]
        public decimal Adjustment { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("bookingProducts")]
        public IEnumerable<BookingProducts> BookingProducts { get; set; }
    }
}
