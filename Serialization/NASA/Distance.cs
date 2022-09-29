﻿using Newtonsoft.Json;

namespace Serialization.NASA;

public class Distance
{
    [JsonProperty("astronomical")]
    public double Astronomical { get; set; }

    [JsonProperty("lunar")]
    public double Lunar { get; set; }
    
    [JsonProperty("kilometers")]
    public double Kilometers { get; set; }

    [JsonProperty("miles")]
    public double Miles { get; set; }
}