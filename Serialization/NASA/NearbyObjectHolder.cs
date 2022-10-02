using Newtonsoft.Json;

namespace Serialization.NASA;

internal class NearbyObjectHolder
{
    [JsonProperty("2015-09-08")]
    public NearbyObject[] _2015_09_08 { get; set; }

    [JsonProperty("2015-09-07")]
    public NearbyObject[] _2015_09_07 { get; set; }

    public override string ToString()
    {
        return $"NearbyObjectHolder: (2015-09-08: ({string.Join<NearbyObject>("; ", _2015_09_08)}); " +
            $"2015-09-07: ({string.Join<NearbyObject>("; ", _2015_09_07)}))";
    }
}