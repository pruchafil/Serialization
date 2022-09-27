using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.NASA
{
    class Link
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
