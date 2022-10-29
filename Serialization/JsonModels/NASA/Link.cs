using Newtonsoft.Json;

namespace Serialization.JsonModels.NASA;

public class Link
{
    [JsonProperty("self")]
    public string Self { get; set; }

    public override string ToString() => $"Link: ((Self: {Self}))";
}