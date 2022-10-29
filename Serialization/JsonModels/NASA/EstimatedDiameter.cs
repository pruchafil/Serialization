using Newtonsoft.Json;

namespace Serialization.JsonModels.NASA;

public class EstimatedDiameter
{
    [JsonProperty("kilometers")]
    public Estimate Kilometers { get; set; }

    [JsonProperty("meters")]
    public Estimate Meters { get; set; }

    [JsonProperty("miles")]
    public Estimate Miles { get; set; }

    [JsonProperty("feet")]
    public Estimate Feet { get; set; }

    public override string ToString()
    {
        return $"EstimatedDiameter: ((Kilometers: {Kilometers}); (Meters: {Meters}); " +
            $"(Miles: {Miles}); (Feet: {Feet}))";
    }
}