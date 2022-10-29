using System.Net.Http;
using System.Threading.Tasks;

namespace Serialization
{
    public class HttpResolver
    {
        internal const string _uri = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=2xMpH3hY2Fyn0imx1BVyKqSstHw2TWXrXGq5IODk";

        public static async Task<string> Get()
        {
            HttpClient hc = new HttpClient();
            HttpResponseMessage rm = await hc.GetAsync(_uri);

            return !rm.IsSuccessStatusCode
                ? throw new HttpRequestException("Operation was not successful.")
                : await rm.Content.ReadAsStringAsync();
        }
    }
}