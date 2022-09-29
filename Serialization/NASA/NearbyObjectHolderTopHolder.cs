using Newtonsoft.Json;

namespace Serialization.NASA;

internal class NearbyObjectHolderTopHolder
{
    [JsonProperty("2015-09-08")]
    public NearbyObjectHolder _2015_09_08 { get; set; }

    [JsonProperty("2015-09-07")]
    public NearbyObjectHolder _2015_09_07 { get; set; }
}