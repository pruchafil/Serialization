﻿using Newtonsoft.Json;

namespace Serialization.NASA;

class Links
{
    [JsonProperty("next")]
    public string Next { get; set; }

    [JsonProperty("previous")]
    public string Previous { get; set; }

    [JsonProperty("self")]
    public string Self { get; set; }
}
