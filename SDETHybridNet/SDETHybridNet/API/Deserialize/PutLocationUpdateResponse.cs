using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.API.Deserialize
{
    internal class PutLocationUpdateResponse
    {
        [JsonProperty("msg")]
        internal string Message { get; set; }
    }
}
