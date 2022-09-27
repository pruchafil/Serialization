using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner r = new();
            r.Run();
            Console.ReadKey();
        }
    }
}

class Runner
{
    const string uri = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=2xMpH3hY2Fyn0imx1BVyKqSstHw2TWXrXGq5IODk";

    public async void Run()
    {
        try
        {
            HttpClient hc = new();
            HttpResponseMessage rm = await hc.GetAsync(uri);

            if (!rm.IsSuccessStatusCode)
                throw new HttpRequestException("Operation was not successful.");

            string res = await rm.Content.ReadAsStringAsync();

            Console.WriteLine(res);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Error! {0}", ex.Message);
        }
    }
}