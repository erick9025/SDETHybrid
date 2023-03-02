using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoreFramework.API.Serialize
{
    public class PostLocationAddBody
    {
        [JsonPropertyName("location")]
        public PostLocationAddBodyLocation Location { get; set; } 

        [JsonPropertyName("accuracy")]
        public int Accuracy { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("types")]
        public List<string> Types { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }
    }
}
