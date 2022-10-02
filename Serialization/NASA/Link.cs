using Newtonsoft.Json;

namespace Serialization.NASA;

class Link
{
    [JsonProperty("self")]
    public string Self { get; set; }

    public override string ToString() => $"Link: ((Self: {Self}))";
}
