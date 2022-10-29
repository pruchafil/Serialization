using Newtonsoft.Json;

namespace Serialization.JsonModels.NASA
{
    public class NearbyObject
    {
        [JsonProperty("links")]
        public Link Links { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("neo_reference_id")]
        public int NeoID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJPLURL { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public EstimatedDiameter EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool PotenciallyHazardous { get; set; }

        [JsonProperty("close_approach_data")]
        public Data[] Data { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }

        public override string ToString()
        {
            return $"NearbyObject: ((Links: {Links}); (ID: {ID}); (NeoID: {NeoID}); (Name: {Name}); " +
                $"(NasaJPLURL: {NasaJPLURL}); (AbsoluteMagnitude: {AbsoluteMagnitude}); " +
                $"(EstimatedDiameter: {EstimatedDiameter}); (PotenciallyHazardous: {PotenciallyHazardous}); " +
                $"(Data: {string.Join<Data>("; ", Data)}); (IsSentryObject: {IsSentryObject}))";
        }
    }
}