using Newtonsoft.Json;

namespace Serialization.NASA;

class Objects
{
    [JsonProperty("links")]
    public Links Links { get; set; }

    [JsonProperty("element_count")]
    public int Count { get; set; }

    [JsonProperty("near_earth_objects")]
    public NearbyObjectHolderTopHolder NearEarthObjects { get; set; }
}
