﻿using AmudhaApp.Library.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmudhaApp.Library.Models
{
    [JsonObject(Title = "customer")]
    public class Customer
    {
        [JsonProperty(PropertyName = "id"), JsonConverter(typeof(GuidConverter))]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "address")]
        public String Address { get; set; }

        [JsonProperty(PropertyName = "contactNumber")]
        public String ContactNumber { get; set; }

        [JsonProperty(PropertyName = "gstin")]
        public String GSTIN { get; set; }

        [JsonProperty(PropertyName = "nickname")]
        public String Nickname { get; set; }

        [JsonProperty(PropertyName = "updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

    }
}