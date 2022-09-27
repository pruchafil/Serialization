using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.NASA
{
    class NearbyObject
    {
        [JsonProperty("links")]
        public Link Links { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }
    }
}
