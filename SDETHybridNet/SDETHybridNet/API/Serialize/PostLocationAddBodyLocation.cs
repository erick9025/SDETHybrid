using System.Text.Json.Serialization;

namespace CoreFramework.API.Serialize
{
    public class PostLocationAddBodyLocation
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lng")]
        public double Longitude { get; set; }

        public PostLocationAddBodyLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
