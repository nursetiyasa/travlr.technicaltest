using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Travlr.TechnicalTest.Domain
{
    public class ImageUrl
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
