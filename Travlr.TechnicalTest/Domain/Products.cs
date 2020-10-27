using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Travlr.TechnicalTest.Domain
{
    public class Products
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("liveAvailability")]
        public bool LiveAvailability { get; set; }

        [JsonPropertyName("confirmationType")]
        public int ConfirmationType { get; set; }

        [JsonPropertyName("availability")]
        public string Availability { get; set; }

        [JsonPropertyName("minStay")]
        public string MinStay { get; set; }

        [JsonPropertyName("maxStay")]
        public string MaxStay { get; set; }

        [JsonPropertyName("cta")]
        public bool Cta { get; set; }

        [JsonPropertyName("ctd")]
        public bool Ctd { get; set; }

        [JsonPropertyName("stopsell")]
        public bool Stopsell { get; set; }

        [JsonPropertyName("durationMinutes")]
        public int DurationMinutes { get; set; }

        [JsonPropertyName("durationText")]
        public string DurationText { get; set; }

        [JsonPropertyName("supplierId")]
        public string SupplierId { get; set; }

        [JsonPropertyName("supplierName")]
        public string SupplierName { get; set; }

        [JsonPropertyName("supplierBranchName")]
        public string SupplierBranchName { get; set; }

        [JsonPropertyName("supplierBranchId")]
        public int SupplierBranchId { get; set; }

        [JsonPropertyName("supplierProductCode")]
        public string SupplierProductCode { get; set; }

        [JsonPropertyName("category")]
        public int Category { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("longDescription")]
        public string LongDescription { get; set; }

        [JsonPropertyName("imageUrls")]
        public IEnumerable<ImageUrl> ImageUrls { get; set; }

        [JsonPropertyName("addons")]
        public string Addons { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("locations")]
        public IEnumerable<Location> Locations { get; set; }

        [JsonPropertyName("mapUrls")]
        public List<string> MapUrls { get; set; }

        [JsonPropertyName("subProducts")]
        public string SubProducts { get; set; }

        [JsonPropertyName("advertisedPrice")]
        public decimal AdvertisedPrice { get; set; }

        [JsonPropertyName("commission")]
        public decimal Commission { get; set; }

        [JsonPropertyName("levy")]
        public decimal Levy { get; set; }

        [JsonPropertyName("rrp")]
        public decimal Rrp { get; set; }

        [JsonPropertyName("variablePrice")]
        public bool VariablePrice { get; set; }

        [JsonPropertyName("saleFare")]
        public bool SaleFare { get; set; }
        
        [JsonPropertyName("currencyIso")]
        public string CurrencyIso { get; set; }

        [JsonPropertyName("pricedPerXPax")]
        public int PricedPerXPax { get; set; }

        [JsonPropertyName("propertyId")]
        public int PropertyId { get; set; }

        [JsonPropertyName("validFrom")]
        public string ValidFrom { get; set; }

        [JsonPropertyName("validTo")]
        public string ValidTo { get; set; }

        [JsonPropertyName("canSellSetDate")]
        public bool CanSellSetDate { get; set; }

        [JsonPropertyName("canSellOpenDated")]
        public bool CanSellOpenDated { get; set; }

        [JsonPropertyName("canOverrideRrp")]
        public bool CanOverrideRrp { get; set; }
    }
}
