using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.API.Deserialize
{
    internal class PostLocationAddResponse
    {
        [JsonProperty("status")]
        internal string Status { get; set; }

        [JsonProperty("place_id")]
        internal string PlaceId { get; set; }

        [JsonProperty("scope")]
        internal string Scope { get; set; }

        [JsonProperty("reference")]
        internal string Reference { get; set; }

        [JsonProperty("id")]
        internal string Id { get; set; }
    }
}
