using Newtonsoft.Json;

namespace Serialization.JsonModels.NASA
{
    public class Objects
    {
        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("element_count")]
        public int Count { get; set; }

        [JsonProperty("near_earth_objects")]
        public NearbyObjectHolder NearEarthObjects { get; set; }

        public override string ToString()
        {
            return $"Objects: ((Links: {Links}); (Count: {Count}); (NearEarthObjects: {NearEarthObjects}))";
        }
    }
}