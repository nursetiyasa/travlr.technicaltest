using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Travlr.TechnicalTest.Domain
{
    public class BookingProducts
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("productId")]
        public string ProductId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("dateCheckIn")]
        public string DateCheckIn { get; set; }

        [JsonPropertyName("nights")]
        public int Nights { get; set; }

        [JsonPropertyName("agentReference")]
        public string AgentReference { get; set; }

        [JsonPropertyName("supplierReference")]
        public string SupplierReference { get; set; }

        [JsonPropertyName("voucherNotes")]
        public string VoucherNotes { get; set; }

        [JsonPropertyName("pickup")]
        public string Pickup { get; set; }
        
        [JsonPropertyName("rrp")]
        public decimal Rrp { get; set; }

        [JsonPropertyName("rateCode")]
        public string RateCode { get; set; }

        [JsonPropertyName("paxId")]
        public List<string> PaxId { get; set; }

        [JsonPropertyName("paxRoomId")]
        public List<string> PaxRoomId { get; set; }

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }
}
