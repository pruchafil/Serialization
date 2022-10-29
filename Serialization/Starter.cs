using Newtonsoft.Json;
using Serialization.JsonModels.NASA;

namespace Serialization;

internal class Starter
{
    internal void Run()
    {
        Proceed();
    }

    private async void Proceed()
    {
        string str = await HttpResolver.Get();

        Objects o = JsonConvert.DeserializeObject<Objects>(str);

        System.Console.WriteLine(o.ToFormattedString().ToString());

        //str = JsonConvert.SerializeObject(o, Formatting.Indented);
    }
}