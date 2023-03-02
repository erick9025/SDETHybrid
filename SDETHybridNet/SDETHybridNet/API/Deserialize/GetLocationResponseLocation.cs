using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.API.Deserialize
{
    internal class GetLocationResponseLocation
    {
        [JsonProperty("latitude")]
        internal double Latitude { get; set; }

        [JsonProperty("longitude")]
        internal double Longitude { get; set; }
    }
}
