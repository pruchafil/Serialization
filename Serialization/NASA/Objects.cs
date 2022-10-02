using Newtonsoft.Json;
using System;
using System.Text;

namespace Serialization.NASA;

class Objects
{
    [JsonProperty("links")]
    public Links Links { get; set; }

    [JsonProperty("element_count")]
    public int Count { get; set; }

    [JsonProperty("near_earth_objects")]
    public NearbyObjectHolder NearEarthObjects { get; set; }

    public static ReadOnlySpan<char> ToFormattedString(Object obj)
    {
        var str = obj.ToString();
        int space = 0;

        StringBuilder sb = new();

        foreach (var item in str)
        {
            if (item is '(')
            {
                sb.Append(Environment.NewLine);

                for (int i = 0; i < space; i++)
                {
                    sb.Append(' ');
                }

                sb.Append(item);
                sb.Append(Environment.NewLine);

                space += 4;

                for (int i = 0; i < space; i++)
                {
                    sb.Append(' ');
                }
            }
            else if (item is ')')
            {
                sb.Append(Environment.NewLine);

                space -= 4;

                for (int i = 0; i < space; i++)
                {
                    sb.Append(' ');
                }

                sb.Append(item);
            }
            else
            {
                sb.Append(item);
            }
        }

        return sb.ToString().AsSpan();
    }

    public override string ToString()
    {
        return $"Objects: ((Links: {Links}); (Count: {Count}); (NearEarthObjects: {NearEarthObjects}))";
    }
}
