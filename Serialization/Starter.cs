using Newtonsoft.Json;
using Serialization.NASA;

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

        NASA.Objects o = JsonConvert.DeserializeObject<NASA.Objects>(str);

        var objectstr = o.ToString();
        Objects.ToFormattedString(objectstr);

        //str = JsonConvert.SerializeObject(o, Formatting.Indented);

    }
}