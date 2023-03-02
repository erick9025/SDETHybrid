using System.Text.Json.Serialization;

namespace CoreFramework.API.Serialize
{
    public class PutLocationUpdateBody
    {
        [JsonPropertyName("place_id")]
        public string PlaceId { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        public PutLocationUpdateBody(string placeId, string address, string key)
        {
            this.PlaceId = placeId;
            this.Address = address;
            this.Key = key;
        }
    }
}
