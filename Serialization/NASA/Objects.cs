using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.NASA
{
    class Objects
    {
        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("element_count")]
        public int Count { get; set; }
    }
}
