using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.API.Deserialize
{
    internal class GetLocationResponse
    {
        [JsonProperty("location")]
        internal GetLocationResponseLocation Location { get; set; }

        [JsonProperty("accuracy")]
        internal int Accuracy { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("phone_number")]
        internal string PhoneNumber { get; set; }

        [JsonProperty("address")]
        internal string Address { get; set; }

        [JsonProperty("types")]
        internal string Types { get; set; }

        [JsonProperty("website")]
        internal string Website { get; set; }

        [JsonProperty("language")]
        internal string Language { get; set; }
    }
}

