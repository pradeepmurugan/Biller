﻿using AmudhaApp.Library.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmudhaApp.Library.Models
{
    [JsonObject(Title = "product")]
    public class Product
    {
        public Product()
        {

        }

        [JsonProperty(PropertyName = "id"), JsonConverter(typeof(GuidConverter))]
        public Guid Id { get; set; } = Guid.Empty;

        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; } = "";

        [JsonProperty(PropertyName = "defaultPrice")]
        public ProductPrice Price { get; set; } = new ProductPrice();

        [JsonProperty(PropertyName = "hsn")]
        public String Hsn { get; set; } = "";

        [JsonProperty(PropertyName = "nickname")]
        public String Nickname { get; set; } = "";

        [JsonProperty(PropertyName = "createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }
}
