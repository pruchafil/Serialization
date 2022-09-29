﻿using Newtonsoft.Json;

namespace Serialization.NASA;

public class Velocity
{
    [JsonProperty("kilometers_per_second")]
    public double KilometersPerSecond { get; set; }

    [JsonProperty("kilometers_per_hour")]
    public double KilometersPerHour { get; set; }

    [JsonProperty("miles_per_hour")]
    public double MilesPerHour { get; set; }
}