using Newtonsoft.Json;

namespace Serialization.JsonModels;

public class Config
{
    [JsonProperty("auto_update")]
    public bool AutoUpdate { get; set; }

    [JsonProperty("dark_mode")]
    public bool DarkMode { get; set; }
}